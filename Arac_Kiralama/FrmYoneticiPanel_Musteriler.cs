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
    public partial class FrmYoneticiPanel_Musteriler : Form
    {
        public FrmYoneticiPanel_Musteriler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        void MusteriListele()
        {
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TblMusteri", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            
            dataGridView1.Columns["MusteriAd"].HeaderText = "Ad";
            dataGridView1.Columns["MusteriSoyad"].HeaderText = "Soyad";
            dataGridView1.Columns["MusteriTC"].HeaderText = "TC Kimlik";
            dataGridView1.Columns["MusteriTelefon"].HeaderText = "Telefon";
            dataGridView1.Columns["MusteriDogumTarihi"].HeaderText = "Doğum Tarihi";
            dataGridView1.Columns["MusteriSifre"].HeaderText = "Şifre";
            dataGridView1.Columns["MusteriEhliyetNo"].HeaderText = "Ehliyet No";
            dataGridView1.Columns["MusteriEhliyetYer"].HeaderText = "Ehliyet Yer";
            dataGridView1.Columns["MusteriEhliyetSinif"].HeaderText = "Ehliyet Sınıfı";
            dataGridView1.Columns["MusteriEhliyetTarihi"].HeaderText = "Ehliyet Alınma Tarihi";
            dataGridView1.Columns["MusteriHesap"].HeaderText = "Hesap";

        }

        private void FrmMusteriKayit_Load(object sender, EventArgs e)
        {
          
        }
        private void FrmYoneticiPanel_Musteriler_Load(object sender, EventArgs e)
        {
            MusteriListele();
        }
    }
}
