using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kiralama
{
    public partial class UC_AracKart : UserControl
    {
        public UC_AracKart()
        {
            InitializeComponent();
        }
        public void BilgiBas(string markaModel, string fiyat, string vites, string yakit,string resimYolu)
        {
            lblMarkaModel.Text = markaModel;
            lblFiyat.Text = fiyat + " TL'den başlayan...";
            lblVites.Text = vites;
            lblYakit.Text = yakit;
            MessageBox.Show("Yüklenmeye çalışılan yol: " + resimYolu);
            // Resim işini şimdilik geçiyorum, önce metinler gelsin.
            if (!string.IsNullOrEmpty(resimYolu))
            {
                // Yolu temizleyip öyle yükleyelim
                picArac.ImageLocation = resimYolu;
                picArac.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
