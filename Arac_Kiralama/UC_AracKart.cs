using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Arac_Kiralama
{
    public partial class UC_AracKart : UserControl
    {

        public int secilenAracID;
        public string resimYoluGecici;
        public string gunlukFiyat;
        public UC_AracKart()
        {
            InitializeComponent();
        }
        public void BilgiBas(int id, string markaModel, string fiyat, string vites, string yakit, string resimYolu)
        {
            this.secilenAracID = id;
            this.gunlukFiyat = fiyat;
            lblMarkaModel.Text = markaModel;
            lblFiyat.Text = fiyat + " TL'den başlayan...";
            lblVites.Text = vites;
            lblYakit.Text = yakit;
            this.resimYoluGecici = resimYolu;

            try
            {
                if (!string.IsNullOrEmpty(resimYolu))
                {
                    // Dosyanın gerçekten orada olup olmadığını kodla kontrol et
                    if (System.IO.File.Exists(resimYolu))
                    {
                        // Resmi yükle
                        picArac.Image = Image.FromFile(resimYolu);
                        picArac.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        // DOSYA BULUNAMAZSA SANA MESAJ VERECEK
                        MessageBox.Show("Sistem şu dosyayı bulamıyor: " + resimYolu);
                    }
                }
            }
            catch (Exception ex)
            {
                // BAŞKA BİR HATA VARSA (YETKİ VB.) SANA SÖYLEYECEK
                MessageBox.Show("Resim yükleme hatası: " + ex.Message);

            }
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeriDeposu.SecilenAracID = this.secilenAracID;

            VeriDeposu.SecilenAracAdi = lblMarkaModel.Text;
            VeriDeposu.SecilenVites = lblVites.Text;
            VeriDeposu.SecilenYakit = lblYakit.Text;
            VeriDeposu.SecilenResimYolu = this.resimYoluGecici;
            VeriDeposu.GunlukFiyat = lblFiyat.Text.Split(' ')[0];

            // Ödeme formunu aç
            FrmOdeme fr = new FrmOdeme();
            fr.ShowDialog();
        }
    }
}
