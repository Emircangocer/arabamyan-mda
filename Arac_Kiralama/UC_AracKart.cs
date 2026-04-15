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
        public void BilgiBas(int id, string markaModel, string fiyat, string vites, string yakit, string resimYolu,string km)
        {
            this.secilenAracID = id;
            this.gunlukFiyat = fiyat;
            lblMarkaModel.Text = markaModel;
            lblFiyat.Text = fiyat + " TL'den başlayan...";
            lblVites.Text = vites;
            lblYakit.Text = yakit;
            lblKm.Text = km + " KM";
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

            if (lblKm.Text != "label1" && !string.IsNullOrEmpty(lblKm.Text))
            {
                // "427300 KM" gibi bir yazı varsa sadece sayı kısmını alalım:
                string sadeceSayi = lblKm.Text.Replace(" KM", "").Trim();
                VeriDeposu.SecilenAracKm = Convert.ToInt32(sadeceSayi);
            }
            else
            {
                // Eğer label dolmadıysa SQL'den gelen orijinal değişkeni kullan (En güvenlisi budur)
                // VeriDeposu.SecilenAracKm = bu_kartin_sql_km_degiskeni;
            }
            VeriDeposu.SecilenAracDepozito = 3000; // Veya SQL'den gelen depozito miktarı

            // Yakıt miktarını da unutma!
            VeriDeposu.SecilenAracYakit = 100; //
            // Ödeme formunu aç
            FrmOdeme fr = new FrmOdeme();
            fr.ShowDialog();
        }
    }
}
