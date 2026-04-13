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
                string ad = dr["AracMarka"].ToString() + " " + dr["AracModel"].ToString();
                string fiyat = dr["AracGunlukUcret"].ToString();
                string vites = dr["AracSanziman"].ToString();
                string yakit = dr["AracYakitTipi"].ToString();
                string resim = dr["AracResim"].ToString(); // SQL'deki resim yolunu çekiyoruz

                // Karta gönderiyoruz (artık resim parametresi de var!)
                kart.BilgiBas(ad, fiyat, vites, yakit, resim);

                flpAraclar.Controls.Add(kart);

                

               

            }
            bgl.baglanti().Close();
        }
        private void flpAraclar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
