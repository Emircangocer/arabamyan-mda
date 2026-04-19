using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace Arac_Kiralama
{
    public partial class FrmYoneticiPanel : Form
    {
        public FrmYoneticiPanel()
        {
            InitializeComponent();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            FrmYoneticiPanel_Musteriler fr = new FrmYoneticiPanel_Musteriler();
            fr.anaForm = this; // "Beni bu form açtı" bilgisini gönderiyoruz
            fr.Show();
            this.Hide();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public void RezervasyonlariGetir()
        {
            // Inner Join kullanarak tabloları birleştiriyoruz
            string sorgu = @"SELECT 
                        R.Kiralamaid, 
                        M.MusteriAd + ' ' + M.MusteriSoyad AS [Müşteri], 
                        A.AracPlaka AS [Plaka], 
                        A.AracMarka + ' ' + A.AracModel AS [Araç], 
                        R.AracTeslimTarihi AS [Alış Tarihi], 
                        R.PlanlananDonusTarihi AS [İade Tarihi], 
                        R.AlisKm AS [Alış KM],
                        R.AlinanDepozito AS [Depozito], 
                        R.KiralamaStatu AS [Durum]
                     FROM TblRezervasyon R
                     INNER JOIN TblMusteri M ON R.Musteriid = M.Musteriid
                     INNER JOIN TblAraclar A ON R.Aracid = A.Aracid
                     WHERE R.KiralamaStatu = 'Aktif / Depozito Alındı'"; // Sadece aktifleri görelim

            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRezervasyonlar.DataSource = dt;
            bgl.baglanti().Close();
        }
        private void FrmYoneticiPanel_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;

            lblYoneticiAd.Text = VeriDeposu.YoneticiAdSoyad;

            // 2. 🔥 Resmi Yükle
            if (!string.IsNullOrEmpty(VeriDeposu.YoneticiResimYolu) && File.Exists(VeriDeposu.YoneticiResimYolu))
            {
                // Eğer veritabanında resim yolu varsa ve dosya gerçekten oradaysa yükle
                pbYoneticiResim.Image = Image.FromFile(VeriDeposu.YoneticiResimYolu);
            }
            else
            {
                // Eğer resim yoksa varsayılan bir "profil" resmi koyabilirsin (Resources'tan)
                // pbYoneticiResim.Image = Properties.Resources.default_profile;
            }
            RezervasyonlariGetir();
            IstatistikleriYukle();
            YaklasanBakimListesi();
        }

        private void dgvRezervasyonlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRezervasyonlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 0. sütunda Kiralamaid olduğunu varsayıyoruz
                VeriDeposu.SecilenRezervasyonID = Convert.ToInt32(dgvRezervasyonlar.Rows[e.RowIndex].Cells[0].Value);

                // Bu ID'yi aldık, artık iade butonuna bastığımızda hangisini iade edeceğimizi biliyoruz!
                MessageBox.Show("Rezervasyon seçildi kanka, iade işlemine hazırız!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmYoneticiIadeOnay fr = new FrmYoneticiIadeOnay();
            fr.anaForm = this; // "Beni bu form açtı" bilgisini gönderiyoruz
            fr.Show();
            this.Hide();
            RezervasyonlariGetir();
        }

        public void IstatistikleriYukle()
        {
            try
            {
                // 1. TOPLAM KAZANÇ (Tamamlanmış kiralamalardan gelen ciro)
                // NOT: Eğer tablonuzda 'KiralamaTutari' yerine farklı bir isim varsa onu yazın kanka.
                string ciroSorgu = @"SELECT 
                (SELECT ISNULL(SUM(ToplamKiraBedeli), 0) FROM TblRezervasyon WHERE KiralamaStatu = 'Tamamlandı') - 
                (SELECT ISNULL(SUM(BakimMaaliyeti), 0) FROM TblBakim) AS NetKazanc";

                SqlCommand cmd = new SqlCommand(ciroSorgu, bgl.baglanti());
                object sonuc = cmd.ExecuteScalar();
                lblToplamKazanc.Text = Convert.ToDouble(sonuc).ToString("N2") + " TL";

                // 2. KAÇ ARAÇ MÜŞTERİDE? (Aktif veya İade Bekleyen durumdakiler)
                string sorguYoldaki = "SELECT COUNT(*) FROM TblRezervasyon WHERE KiralamaStatu LIKE '%Aktif%' OR KiralamaStatu = 'İade Bekliyor'";
                SqlCommand cmd2 = new SqlCommand(sorguYoldaki, bgl.baglanti());
                lblYoldakiAraclar.Text = cmd2.ExecuteScalar().ToString() + " Araç Yolda";

                // 3. KAÇ ARAÇ DÜKKANDA? (Müsait olanlar)
                string sorguMusait = "SELECT COUNT(*) FROM TblAraclar WHERE AracStatu = 'Müsait'";
                SqlCommand cmd3 = new SqlCommand(sorguMusait, bgl.baglanti());
                lblMusaitAraclar.Text = cmd3.ExecuteScalar().ToString() + " Araç Müsait";

                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İstatistik hatası: " + ex.Message);
            }


        }
        public void YaklasanBakimListesi()
        {
            // Bugün ile 7 gün sonrasını kapsayan araçları çeker
            string sorgu = @"SELECT AracPlaka, AracMarka, AracModel, GelecekBakimTarihi 
                     FROM TblAraclar 
                     WHERE GelecekBakimTarihi BETWEEN GETDATE() AND DATEADD(day, 7, GETDATE())
                     ORDER BY GelecekBakimTarihi ASC";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvYaklasanBakimlar.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmBakimTakvimi fr = new FrmBakimTakvimi();
            fr.anaForm = this; // "Beni bu form açtı" bilgisini gönderiyoruz
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYoneticiAracEkle fr = new FrmYoneticiAracEkle();
            fr.anaForm = this; // "Beni bu form açtı" bilgisini gönderiyoruz
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmYoneticiPanel_Rezervasyonlar fr = new FrmYoneticiPanel_Rezervasyonlar();
            fr.anaForm = this; // "Beni bu form açtı" bilgisini gönderiyoruz
            fr.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmRaporlar fr = new FrmRaporlar();
            fr.anaForm = this; // "Beni bu form açtı" bilgisini gönderiyoruz
            fr.Show();
            this.Hide();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Oturumu kapatmak istediğinize emin misiniz?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (secim == DialogResult.Yes)
            {
                // 1. Zaten açık olan ama gizli bekleyen o ilk formu (Form1) buluyoruz
                Form anaGirisFormu = Application.OpenForms["FrmAnaSayfa"]; // İsmi Form1 ise böyle kalmalı

                if (anaGirisFormu != null)
                {
                    anaGirisFormu.Show(); // Gizli olan formu geri getir
                    this.Close(); // Mevcut Yönetici Panelini imha et
                }
                else
                {
                    // Eğer bir aksilik olduysa ve o form kapandıysa mecbur yenisini açarız
                    FrmAnaSayfa fr = new FrmAnaSayfa();
                    fr.Show();
                    this.Close();
                }
            }
        }
    }
}
    
    

