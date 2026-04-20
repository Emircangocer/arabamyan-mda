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
    public partial class FrmYoneticiIadeOnay : Form
    {
        public Form anaForm;
        public FrmYoneticiIadeOnay()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        public void RezervasyonlariGetir()
        {
            string sorgu = @"SELECT 
                R.Kiralamaid, 
                R.Musteriid, 
                R.Aracid, 
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
             WHERE R.KiralamaStatu = 'Aktif / Depozito Alındı'";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRezervasyonlar.DataSource = dt;

            // Kanka bu ID'ler tabloda çirkin durmasın dersen gizleyebilirsin:
            dgvRezervasyonlar.Columns["Musteriid"].Visible = false;
            dgvRezervasyonlar.Columns["Aracid"].Visible = false;

            bgl.baglanti().Close();
        }
        private void btnIadeOnayla_Click(object sender, EventArgs e)
        {


            try
            {
                // 1. Formdaki verileri alalım
                int donusKm = Convert.ToInt32(txtDonusKm.Text);
                int donusYakit = Convert.ToInt32(txtKalanYakit.Text);
                string hasarliParca = cmbHasarDurumu.Text;
                string hasarAciklama = txtHasarAciklama.Text;
                double hasarMaliyeti = string.IsNullOrEmpty(txtHasarMaliyeti.Text) ? 0 : Convert.ToDouble(txtHasarMaliyeti.Text);

                // 2. SQL'den başlangıç verilerini ve tarihleri çek
                // PlanlananDonusTarihi ve GunlukFiyat'ı da çekiyoruz ki gecikmeyi hesaplayalım
                string cekSorgu = @"SELECT AlisKm, AlisYakitMiktar, AlinanDepozito, Musteriid, Aracid, 
                           PlanlananDonusTarihi, ToplamKiraBedeli / DATEDIFF(day, AracTeslimTarihi, PlanlananDonusTarihi) as GunlukFiyat 
                           FROM TblRezervasyon WHERE Kiralamaid = @id";

                SqlCommand cekKomut = new SqlCommand(cekSorgu, bgl.baglanti());
                cekKomut.Parameters.AddWithValue("@id", VeriDeposu.SecilenRezervasyonID);
                SqlDataReader dr = cekKomut.ExecuteReader();

                if (dr.Read())
                {
                    int alisKm = Convert.ToInt32(dr["AlisKm"]);
                    int alisYakit = Convert.ToInt32(dr["AlisYakitMiktar"]);
                    double alinanDepozito = Convert.ToDouble(dr["AlinanDepozito"]);
                    int musteriId = Convert.ToInt32(dr["Musteriid"]);
                    int aracId = Convert.ToInt32(dr["Aracid"]);
                    DateTime planlananDonus = Convert.ToDateTime(dr["PlanlananDonusTarihi"]);
                    double gunlukFiyat = dr["GunlukFiyat"] == DBNull.Value ? 1000 : Convert.ToDouble(dr["GunlukFiyat"]);

                    dr.Close();

                    // --- YENİ KURALLAR: CEZA VE HESAPLAMALAR ---

                    // A) Gecikme Cezası (Belge Kuralı: 2 saatten fazla gecikme = +1 gün ücret)
                    double gecikmeCezasi = 0;
                    if (DateTime.Now > planlananDonus.AddHours(2))
                    {
                        gecikmeCezasi = gunlukFiyat;
                    }

                    // B) Yakıt Cezası
                    double yakitCezasi = (donusYakit < alisYakit) ? (alisYakit - donusYakit) * 50 : 0;

                    // C) Hasar & Depozito Mahsuplaşması (Belge Kuralı: Kalan tutar borç yazılır)
                    double iadeEdilecekDepozito = 0;
                    double ekBorc = 0;

                    if (hasarMaliyeti > alinanDepozito)
                    {
                        ekBorc = hasarMaliyeti - alinanDepozito; // Depozito bitti, üstü borç
                        iadeEdilecekDepozito = 0;
                    }
                    else
                    {
                        iadeEdilecekDepozito = alinanDepozito - hasarMaliyeti; // Hasar düştü, kalanı iade
                    }

                    // D) Nihai Bakiye Değişimi
                    // Müşteriye iade edilen depozitodan, yakıt ve gecikme cezaları ile varsa ek hasar borcu düşülür.
                    double netBakiyeDegisimi = iadeEdilecekDepozito - yakitCezasi - gecikmeCezasi - ekBorc;

                    lblDepozitoBilgi.Text = netBakiyeDegisimi.ToString("N2") + " TL";

                    // --- SQL İŞLEMLERİ ---

                    // 4. HASAR TABLOSUNA KAYIT
                    if (hasarMaliyeti > 0)
                    {
                        string hasarSql = "INSERT INTO TblHasarlar (Kiralamaid, Aracid, HasarliParca, HasarAciklama, HasarMaliyeti, MusteriSorumlumu) VALUES (@h1, @h2, @h3, @h4, @h5, 1)";
                        SqlCommand hKomut = new SqlCommand(hasarSql, bgl.baglanti());
                        hKomut.Parameters.AddWithValue("@h1", VeriDeposu.SecilenRezervasyonID);
                        hKomut.Parameters.AddWithValue("@h2", aracId);
                        hKomut.Parameters.AddWithValue("@h3", hasarliParca);
                        hKomut.Parameters.AddWithValue("@h4", hasarAciklama);
                        hKomut.Parameters.AddWithValue("@h5", hasarMaliyeti);
                        hKomut.ExecuteNonQuery();
                    }

                    // 5. MÜŞTERİ BAKİYESİNİ GÜNCELLE
                    string bakiyeSql = "UPDATE TblMusteri SET MusteriBakiye = MusteriBakiye + @degisim WHERE Musteriid = @mid";
                    SqlCommand bKomut = new SqlCommand(bakiyeSql, bgl.baglanti());
                    bKomut.Parameters.AddWithValue("@degisim", netBakiyeDegisimi);
                    bKomut.Parameters.AddWithValue("@mid", musteriId);
                    bKomut.ExecuteNonQuery();

                    // 6. ARACI GÜNCELLE
                    string aracSql = "UPDATE TblAraclar SET AracKm = @yeniKm, AracStatu = 'Müsait' WHERE Aracid = @aid";
                    SqlCommand aKomut = new SqlCommand(aracSql, bgl.baglanti());
                    aKomut.Parameters.AddWithValue("@yeniKm", donusKm);
                    aKomut.Parameters.AddWithValue("@aid", aracId);
                    aKomut.ExecuteNonQuery();

                    // 7. REZERVASYONU KAPAT
                    string rezKapatSql = "UPDATE TblRezervasyon SET KiralamaStatu = 'Tamamlandı', iadeKm = @ikm, iadeYakitMiktar = @iyakit WHERE Kiralamaid = @rid";
                    SqlCommand rKomut = new SqlCommand(rezKapatSql, bgl.baglanti());
                    rKomut.Parameters.AddWithValue("@ikm", donusKm);
                    rKomut.Parameters.AddWithValue("@iyakit", donusYakit);
                    rKomut.Parameters.AddWithValue("@rid", VeriDeposu.SecilenRezervasyonID);
                    rKomut.ExecuteNonQuery();

                    // 8. BİLGİLENDİRME
                    string mesaj = $"İşlem Başarılı!\n\n" +
                                   $"Gecikme Cezası: {gecikmeCezasi} TL\n" +
                                   $"Yakıt Cezası: {yakitCezasi} TL\n" +
                                   $"Hasar Maliyeti: {hasarMaliyeti} TL\n" +
                                   $"Net Bakiye Değişimi: {netBakiyeDegisimi} TL";

                    MessageBox.Show(mesaj, "İade Özeti");

                    PrintPreviewDialog ppd = new PrintPreviewDialog();
                    ppd.Document = printDocumentTutanak;
                    ppd.WindowState = FormWindowState.Maximized;
                    ppd.ShowDialog(); // İşlem bitince şak diye önizleme açılır

                    this.Close();
                }
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmYoneticiIadeOnay_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // VeriDeposu'ndaki ID ile müşteri ve plaka bilgisini çekiyoruz
            string sorgu = @"SELECT M.MusteriAd + ' ' + M.MusteriSoyad as AdSoyad, A.AracPlaka 
                    FROM TblRezervasyon R 
                    JOIN TblMusteri M ON R.Musteriid = M.Musteriid 
                    JOIN TblAraclar A ON R.Aracid = A.Aracid 
                    WHERE R.Kiralamaid = @id";

            SqlCommand cmd = new SqlCommand(sorgu, bgl.baglanti());
            cmd.Parameters.AddWithValue("@id", VeriDeposu.SecilenRezervasyonID);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblMusteriAd.Text = dr["AdSoyad"].ToString();
                lblAracPlaka.Text = dr["AracPlaka"].ToString();
            }
            bgl.baglanti().Close();

            RezervasyonlariGetir();
        }

        private void dgvRezervasyonlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 1. Önce ID'yi alıyoruz (Veritabanı işlemleri için)
                VeriDeposu.SecilenRezervasyonID = Convert.ToInt32(dgvRezervasyonlar.Rows[e.RowIndex].Cells["Kiralamaid"].Value);

                // 2. Seçilen satırdaki verileri Labellara aktarıyoruz (Görsel şov için)
                // Tabloda "Müşteri" ve "Plaka" sütun isimlerini kullandığın için aynen öyle çağırıyoruz
                lblMusteriAd.Text = dgvRezervasyonlar.Rows[e.RowIndex].Cells["Müşteri"].Value.ToString();
                lblAracPlaka.Text = dgvRezervasyonlar.Rows[e.RowIndex].Cells["Plaka"].Value.ToString();

                // 3. (Opsiyonel) Dönüş yakıtı veya KM için başlangıç değerlerini de çekebilirsin
                MessageBox.Show(lblMusteriAd.Text + " seçildi, iade işlemine hazırız!");
            }
        }

        private void printDocumentTutanak_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Başlık ve Logo
            e.Graphics.DrawString("ARABAMYANIMDA ARAÇ KİRALAMA", new Font("Arial", 20, FontStyle.Bold), Brushes.DarkBlue, 200, 50);
            e.Graphics.DrawString("TESLİM VE İADE TUTANAĞI", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 280, 100);
            e.Graphics.DrawString("Tarih: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm"), new Font("Arial", 10), Brushes.Black, 600, 100);

            e.Graphics.DrawLine(Pens.Black, 100, 130, 750, 130);

            // Müşteri ve Araç Bilgileri
            e.Graphics.DrawString("MÜŞTERİ BİLGİLERİ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 100, 150);
            e.Graphics.DrawString("Ad Soyad: " + lblMusteriAd.Text, new Font("Arial", 11), Brushes.Black, 100, 180);

            e.Graphics.DrawString("ARAÇ BİLGİLERİ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 450, 150);
            e.Graphics.DrawString("Plaka: " + lblAracPlaka.Text, new Font("Arial", 11), Brushes.Black, 450, 180);
            e.Graphics.DrawString("Dönüş KM: " + txtDonusKm.Text, new Font("Arial", 11), Brushes.Black, 450, 210);

            e.Graphics.DrawLine(Pens.Gray, 100, 250, 750, 250);

            // Finansal Döküm (İşin can alıcı kısmı)
            e.Graphics.DrawString("FİNANSAL DETAYLAR", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 100, 280);

            int y = 310;
            e.Graphics.DrawString("Hasar Maliyeti: " + txtHasarMaliyeti.Text + " TL", new Font("Arial", 11), Brushes.Black, 120, y);
            y += 30;

            // 🔥 YAKIT CEZASINI BURAYA EKLE:
            // Burada iade butonunda hesapladığın 'yakitCezasi' değişkenini kullanacağız.
            // Eğer o değişkene buradan erişemiyorsan, yakıt cezasını bir Label'a yazdırıp oradan çekebilirsin.
            int dYakit = Convert.ToInt32(txtKalanYakit.Text);

            int aYakit = 100;

            double yakitCezasiHesaplanan = (dYakit < aYakit) ? (aYakit - dYakit) * 50 : 0;


            e.Graphics.DrawString("Yakıt Eksik Ücreti: " + yakitCezasiHesaplanan.ToString("N2") + " TL", new Font("Arial", 11), Brushes.Black, 120, y);
            y += 30;

            // Gecikme ve Yakıt Cezası bilgilerini değişkenlerden alıyoruz
            e.Graphics.DrawString("Hasar Durumu: " + cmbHasarDurumu.Text, new Font("Arial", 11), Brushes.Black, 120, y);
            y += 30;

            e.Graphics.DrawString("Açıklama: " + txtHasarAciklama.Text, new Font("Arial", 11), Brushes.Gray, 120, y);
            y += 50;

            e.Graphics.DrawLine(Pens.Black, 100, y, 750, y);
            y += 20;

            e.Graphics.DrawString("NET İADE EDİLEN TUTAR:", new Font("Arial", 14, FontStyle.Bold), Brushes.DarkGreen, 100, y);
            // Buradaki tutarı iade butonunda hesapladığın değişkenden çekebilirsin
            e.Graphics.DrawString(lblDepozitoBilgi.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.DarkGreen, 450, y);

            // İmzalar
            e.Graphics.DrawString("Teslim Eden (Müşteri)", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 150, y + 100);
            e.Graphics.DrawString("Teslim Alan (Yetkili)", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 500, y + 100);
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            if (this.anaForm != null)
            {
                this.anaForm.Show(); // Gizli olan o tek yönetici panelini geri getir
            }
            this.Close();
        }

        private void FrmYoneticiIadeOnay_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FrmYoneticiIadeOnay_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Sadece bu formu gizle, Application.Exit() yazma!
                this.Hide();
                e.Cancel = true; // Kapanma işlemini iptal edip sadece gizliyoruz
            }
        }
    }

}
