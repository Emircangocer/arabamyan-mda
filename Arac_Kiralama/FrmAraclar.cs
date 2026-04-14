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


            flpAraclar.Controls.Clear(); // Ne olur ne olmaz temiz başla
            UC_AracKart testKart = new UC_AracKart();


            // Meşhur Müsaitlik Sorgusu
            string sorgu = "SELECT * FROM TblAraclar";

            SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", baslangicTarihi);
            komut.Parameters.AddWithValue("@p2", bitisTarihi);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {


                UC_AracKart kart = new UC_AracKart();

                // SQL'den verileri değişkenlere alalım
                int id = Convert.ToInt32(dr["Aracid"]);
                string ad = dr["AracMarka"].ToString() + " " + dr["AracModel"].ToString();
                string fiyat = dr["AracGunlukUcret"].ToString();
                string vites = dr["AracSanziman"].ToString();
                string yakit = dr["AracYakitTipi"].ToString();
                string resim = dr["AracResim"].ToString(); // SQL'deki resim yolunu çekiyoruz
                
                // Karta gönderiyoruz (artık resim parametresi de var!)
                kart.BilgiBas(id,ad, fiyat, vites, yakit, resim);

                flpAraclar.Controls.Add(kart);





            }
            bgl.baglanti().Close();
        }

        public void AracListele(string filtreSorgusu = "")
        {
            flpAraclar.Controls.Clear(); // Önce eskileri bir temizle

            // Temel sorgumuz (Müsait olanlar)
            string sql = "SELECT * FROM TblAraclar WHERE AracStatu = 'Müsait' " + filtreSorgusu;

            SqlCommand komut = new SqlCommand(sql, bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                UC_AracKart kart = new UC_AracKart();

                // 1. Önce ID'yi alıyoruz (Hata buydu!)
                int aracID = Convert.ToInt32(dr["Aracid"]);

                // 2. Metoda tam 6 tane bilgiyi sırasıyla gönderiyoruz
                kart.BilgiBas(
                    aracID, // Eksik olan birinci parametre
                    dr["AracMarka"].ToString() + " " + dr["AracModel"].ToString(),
                    dr["AracGunlukUcret"].ToString(),
                    dr["AracSanziman"].ToString(),
                    dr["AracYakitTipi"].ToString(),
                    dr["AracResim"].ToString()
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
    
    }
}
