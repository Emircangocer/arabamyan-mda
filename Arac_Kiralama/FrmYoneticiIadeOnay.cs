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
        public FrmYoneticiIadeOnay()
        {
            InitializeComponent();
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
        private void btnIadeOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Formdaki verileri güvenli bir şekilde alalım
                int donusKm = Convert.ToInt32(txtDonusKm.Text);
                int donusYakit = Convert.ToInt32(txtKalanYakit.Text);
                string hasarliParca = cmbHasarDurumu.Text; // ComboBox'tan seçilen parça
                string hasarAciklama = txtHasarAciklama.Text;
                // Maliyet boşsa 0 kabul et
                decimal hasarMaliyeti = string.IsNullOrEmpty(txtHasarMaliyeti.Text) ? 0 : Convert.ToDecimal(txtHasarMaliyeti.Text);

                // 2. SQL'den başlangıç verilerini çek (Alış yakıtı ve depozito miktarını bilmemiz lazım)
                string cekSorgu = "SELECT AlisKm, AlisYakitMiktar, AlinanDepozito, Musteriid, Aracid FROM TblRezervasyon WHERE Kiralamaid = @id";
                SqlCommand cekKomut = new SqlCommand(cekSorgu, bgl.baglanti());
                cekKomut.Parameters.AddWithValue("@id", VeriDeposu.SecilenRezervasyonID);
                SqlDataReader dr = cekKomut.ExecuteReader();

                if (dr.Read())
                {
                    int alisKm = (dr["AlisKm"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["AlisKm"]);
                    int alisYakit = (dr["AlisYakitMiktar"] == DBNull.Value) ? 100 : Convert.ToInt32(dr["AlisYakitMiktar"]);
                    double alinanDepozito = (dr["AlinanDepozito"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["AlinanDepozito"]);

                    int musteriId = Convert.ToInt32(dr["Musteriid"]);
                    int aracId = Convert.ToInt32(dr["Aracid"]);

                    dr.Close(); // Okuma bitti, bağlantıyı diğer işlemler için serbest bırakıyoruz

                    // 3. CEZA HESAPLARI
                    // Yakıt Cezası: Her %1 eksik için 50 TL (Rakamı kafana göre değiştirebilirsin kanka)
                    double yakitCezasi = (donusYakit < alisYakit) ? (alisYakit - donusYakit) * 50 : 0;

                    // Toplam Kesinti = Yakıt Cezası + Hasar Maliyeti
                    double toplamKesinti = yakitCezasi + (double)hasarMaliyeti;
                    double iadeEdilecekDepozito = alinanDepozito - toplamKesinti;

                    if (iadeEdilecekDepozito < 0) iadeEdilecekDepozito = 0;

                    // 4. HASAR TABLOSUNA KAYIT (Eğer hasar maliyeti girildiyse)
                    if (hasarMaliyeti > 0)
                    {
                        string hasarSql = "INSERT INTO TblHasarlar (Kiralamaid, Aracid, HasarliParca, HasarAciklama, HasarMaliyeti, MusteriSorumlumu) " +
                                          "VALUES (@h1, @h2, @h3, @h4, @h5, @h6)";
                        SqlCommand hKomut = new SqlCommand(hasarSql, bgl.baglanti());
                        hKomut.Parameters.AddWithValue("@h1", VeriDeposu.SecilenRezervasyonID);
                        hKomut.Parameters.AddWithValue("@h2", aracId);
                        hKomut.Parameters.AddWithValue("@h3", hasarliParca);
                        hKomut.Parameters.AddWithValue("@h4", hasarAciklama);
                        hKomut.Parameters.AddWithValue("@h5", hasarMaliyeti);
                        hKomut.Parameters.AddWithValue("@h6", 1); // Müşteri sorumlu (bit tipi olduğu için 1=true)
                        hKomut.ExecuteNonQuery();
                    }

                    // 5. MÜŞTERİ BAKİYESİNE İADE
                    string bakiyeSql = "UPDATE TblMusteri SET MusteriBakiye = MusteriBakiye + @iade WHERE Musteriid = @mid";
                    SqlCommand bKomut = new SqlCommand(bakiyeSql, bgl.baglanti());
                    bKomut.Parameters.AddWithValue("@iade", iadeEdilecekDepozito);
                    bKomut.Parameters.AddWithValue("@mid", musteriId);
                    bKomut.ExecuteNonQuery();

                    // 6. ARACI GÜNCELLE (KM'yi arttır ve statüyü müsait yap)
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

                    MessageBox.Show($"Araç Başarıyla İade Alındı !\n\nYakıt Cezası: {yakitCezasi} TL\nHasar Maliyeti: {hasarMaliyeti} TL\nİade Edilen Depozito: {iadeEdilecekDepozito} TL");
                    this.Close(); // Formu kapat
                }
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata kanka: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmYoneticiIadeOnay_Load(object sender, EventArgs e)
        {
            RezervasyonlariGetir();
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
    }
}
