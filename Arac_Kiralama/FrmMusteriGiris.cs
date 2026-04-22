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
    public partial class FrmMusteriGiris : Form
    {
        public FrmMusteriGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMusteriKayıt fr = new FrmMusteriKayıt();
            fr.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM TblMusteri WHERE MusteriTC=@p1 AND MusteriSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                VeriDeposu.GirisYapildiMi = true;
                VeriDeposu.MusteriID = Convert.ToInt32(dr["Musteriid"]);
                VeriDeposu.MusteriBakiye = Convert.ToDouble(dr["MusteriBakiye"]);
                VeriDeposu.GirisYapanMusteriAdSoyad = dr["MusteriAd"].ToString() + " " + dr["MusteriSoyad"].ToString();
                VeriDeposu.MusteriBakiye = (dr["MusteriBakiye"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["MusteriBakiye"]);
                // Ana sayfadaki metotları tetiklemek için formu kapatmadan önce:
                this.DialogResult = DialogResult.OK;
                this.Close();



            }
            else
            {
                MessageBox.Show("TC veya Şifre hatalı!");
            }
            bgl.baglanti().Close();
        }
    }
}
