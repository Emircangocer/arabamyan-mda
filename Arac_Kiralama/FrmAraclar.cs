using Microsoft.Data.SqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Arac_Kiralama
{
    public partial class FrmAraclar : Form
    {
        public FrmAraclar()
        {
            InitializeComponent();
        }
        public DateTime baslangicTarihi;
        public DateTime bitisTarihi;
        SqlBaglantisi bgl = new SqlBaglantisi();


        private void FrmAraclar_Load(object sender, EventArgs e)
        {
           
        
            this.WindowState = FormWindowState.Maximized;
            flpAraclar.Controls.Clear(); // Ne olur ne olmaz temiz başla

            try
            {
                // 1. ADIM: SÜPÜRGE - Bakım günü bugün olanları pasife al (Müşteri görmesin)
                string bakimGuncelleSorgu = @"UPDATE TblAraclar 
                                     SET AracStatu = 'Bakımda' 
                                     WHERE CAST(GelecekBakimTarihi AS DATE) <= CAST(GETDATE() AS DATE) 
                                     AND AracStatu = 'Müsait'";

                SqlCommand cmdBakim = new SqlCommand(bakimGuncelleSorgu, bgl.baglanti());
                cmdBakim.ExecuteNonQuery();
                bgl.baglanti().Close();

                // 2. ADIM: LİSTELEME - Sadece müsait ve iade tarihinden sonra bakımı olanlar
                // VeriDeposu'ndaki iade tarihini kullanıyoruz
                string sorgu = @"SELECT * FROM TblAraclar 
                         WHERE AracStatu = 'Müsait' 
                         AND (CAST(GelecekBakimTarihi AS DATE) > CAST(@paramIade AS DATE) 
                              OR GelecekBakimTarihi IS NULL)";

                SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
                komut.Parameters.AddWithValue("@paramIade", VeriDeposu.IadeTarihi);

                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    UC_AracKart kart = new UC_AracKart();

                    int id = Convert.ToInt32(dr["Aracid"]);
                    string ad = dr["AracMarka"].ToString() + " " + dr["AracModel"].ToString();
                    string fiyat = dr["AracGunlukUcret"].ToString();
                    string vites = dr["AracSanziman"].ToString();
                    string yakit = dr["AracYakitTipi"].ToString();
                    string resim = dr["AracResim"].ToString();
                    string km = dr["AracKm"].ToString();

                    // Karta gönderiyoruz
                    kart.BilgiBas(id, ad, fiyat, vites, yakit, resim, km);
                    flpAraclar.Controls.Add(kart);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                bgl.baglanti().Close();
            }
        }

        public void AracListele(string filtreSorgusu = "")
        {
            flpAraclar.Controls.Clear(); // Önce eskileri bir temizle

            // VeriDeposu'ndan müşterinin seçtiği iade tarihini alıyoruz
            DateTime musteriIadeTarihi = VeriDeposu.IadeTarihi;

            // SORGUMUZ: Müsait olan VE bakım tarihi müşterinin iade tarihinden SONRA olan araçlar
            // Not: Bakım tarihi boş olan araçlar da gelsin diye IS NULL kontrolü ekledik
            string sql = @"SELECT * FROM TblAraclar 
               WHERE AracStatu = 'Müsait' 
               AND (CAST(GelecekBakimTarihi AS DATE) > CAST(@paramIade AS DATE) 
                    OR GelecekBakimTarihi IS NULL) " + filtreSorgusu;

            SqlCommand komut = new SqlCommand(sql, bgl.baglanti());
            komut.Parameters.AddWithValue("@paramIade", musteriIadeTarihi);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                UC_AracKart kart = new UC_AracKart();

                // 1. Önce ID'yi alıyoruz
                int aracID = Convert.ToInt32(dr["Aracid"]);

                // 2. Metoda bilgileri sırasıyla gönderiyoruz
                kart.BilgiBas(
                    aracID,
                    dr["AracMarka"].ToString() + " " + dr["AracModel"].ToString(),
                    dr["AracGunlukUcret"].ToString(),
                    dr["AracSanziman"].ToString(),
                    dr["AracYakitTipi"].ToString(),
                    dr["AracResim"].ToString(),
                    dr["AracKm"].ToString()
                );

                flpAraclar.Controls.Add(kart);
            }
            bgl.baglanti().Close();
        }
        private void flpAraclar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            string ekSorgu = "";

            // 1. Vites Filtresi Kontrolü
            if (cmbVites.Text == "Otomatik")
                ekSorgu += " AND AracSanziman = 'Otomatik'";
            else if (cmbVites.Text == "Manuel")
                ekSorgu += " AND AracSanziman = 'Manuel'";

            // 2. Yakıt Tipi Filtresi Kontrolü (Yeni Eklediğin ComboBox)
            if (cmbYakit.Text == "Benzin")
                ekSorgu += " AND AracYakitTipi = 'Benzin'";
            else if (cmbYakit.Text == "Benzin/LPG")
                ekSorgu += " AND AracYakitTipi='Benzin/LPG'";
            else if (cmbYakit.Text == "Dizel")
                ekSorgu += " AND AracYakitTipi = 'Dizel'";

            else if (cmbYakit.Text == "Hibrit")
                ekSorgu += " AND AracYakitTipi = 'Hibrit'";

            // Hazırlanan tüm şartları tek seferde metoda gönderiyoruz
            AracListele(ekSorgu);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa fr=new FrmAnaSayfa();
            fr.Show();
            this.Dispose();
        }
    }
}
