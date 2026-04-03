using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Arac_Kiralama
{
    public partial class FrmMusteriKayıt : Form
    {
        public FrmMusteriKayıt()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {


        }

        private void FrmMusteriKayıt_Load(object sender, EventArgs e)
        {

        }

        private void btnÜyeOl_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut=new SqlCommand("INSERT INTO TblMusteri (MusteriAd, MusteriSoyad, MusteriTC, MusteriTelefon, MusteriSifre, MusteriDogumTarihi, MusteriEhliyetNo,MusteriEhliyetYer,MusteriEhliyetSinif,MusteriEhliyetTarihi) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTC.Text);
            komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.Parameters.AddWithValue("@p6", dateTimePicker1.Value.Date);
            komut.Parameters.AddWithValue("@p7", txtEhliyetNo.Text);
            komut.Parameters.AddWithValue("@p8", txtEhliyetYer.Text);
            komut.Parameters.AddWithValue("@p9", cmbEhliyetSınıfı.Text);
            komut.Parameters.AddWithValue("@p10", dateTimePicker2.Value.Date);
           


            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Üyeliğiniz başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmMusteriGiris fr=new FrmMusteriGiris();
            fr.Show();
            this.Close();
        }
    }
}
