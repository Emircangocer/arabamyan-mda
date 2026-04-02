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
            

           
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM TblYonetici WHERE YoneticiTC=@p1 AND YoneticiSifre=@p2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", mskTC.Text);
            cmd.Parameters.AddWithValue("@p2", txtSifre.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı!");
                FrmYoneticiPanel fr=new FrmYoneticiPanel();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya Şifre yanlış!");
            }
            dr.Close();
            bgl.baglanti().Close(); 
        }
    }
}
