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
        SqlBaglantisi bgl=new SqlBaglantisi();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            try
            {
                // Sorguda TC ve Sifre kontrolü yaparken aynı zamanda Ad-Soyad ve ResimYolu'nu alıyoruz
                string sorgu = @"SELECT 
                        YoneticiAd + ' ' + YoneticiSoyad, 
                        YoneticiResimYolu 
                     FROM TblYonetici 
                     WHERE YoneticiTC = @p1 AND YoneticiSifre = @p2";

                SqlCommand cmd = new SqlCommand(sorgu, bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", mskTC.Text); // Kullanıcı adı yerine TC kutun
                cmd.Parameters.AddWithValue("@p2", txtSifre.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // 1. Giriş başarılı! Bilgileri ortak hafızaya (VeriDeposu) alıyoruz
                    VeriDeposu.YoneticiAdSoyad = dr[0].ToString();

                    // Resim yolu boşsa hata vermemesi için kontrol
                    VeriDeposu.YoneticiResimYolu = dr[1] != DBNull.Value ? dr[1].ToString() : "";

                    // 2. Paneli Aç
                    FrmYoneticiPanel fr = new FrmYoneticiPanel();
                    fr.Show();
                    this.Hide(); // Giriş formunu gizle
                }
                else
                {
                    MessageBox.Show("TC Kimlik No veya Şifre hatalı kanka!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası kanka: " + ex.Message);
            }
        }
    }
}
