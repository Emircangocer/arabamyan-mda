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
    public partial class FrmYoneticiGiris : Form
    {
        public FrmYoneticiGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            try
            {
                
                string sorgu = @"SELECT 
                        YoneticiAd + ' ' + YoneticiSoyad, 
                        YoneticiResimYolu 
                     FROM TblYonetici 
                     WHERE YoneticiTC = @p1 AND YoneticiSifre = @p2";

                SqlCommand cmd = new SqlCommand(sorgu, bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", mskTC.Text); 
                cmd.Parameters.AddWithValue("@p2", txtSifre.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    
                    VeriDeposu.YoneticiAdSoyad = dr[0].ToString();

                    // Resim yolu boşsa hata vermemesi için kontrol
                    VeriDeposu.YoneticiResimYolu = dr[1] != DBNull.Value ? dr[1].ToString() : "";

                    
                    FrmYoneticiPanel fr = new FrmYoneticiPanel();
                    fr.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("TC Kimlik No veya Şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası : " + ex.Message);
            }
        }

        private void FrmYoneticiGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
