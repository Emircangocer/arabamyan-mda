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
    public partial class FrmOdeme : Form
    {
        public int aracID;
        public string fiyat;
        public FrmOdeme()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmOdeme_Load(object sender, EventArgs e)
        {
            lblAracAdi.Text = VeriDeposu.SecilenAracAdi;
            lblVites.Text = "Vites: " + VeriDeposu.SecilenVites;
            lblYakit.Text = "Yakıt: " + VeriDeposu.SecilenYakit;

            if (!string.IsNullOrEmpty(VeriDeposu.SecilenResimYolu))
            {
                // Dosya gerçekten var mı diye kontrol edelim (opsiyonel ama sağlam olur)
                if (System.IO.File.Exists(VeriDeposu.SecilenResimYolu))
                {
                    // picSecilenArac senin Ödeme Formundaki PictureBox'ın adı
                    picSecilenArac.ImageLocation = VeriDeposu.SecilenResimYolu;
                    picSecilenArac.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            // Tarihleri ve Saatleri yazdır
            lblAlisTarihi.Text = VeriDeposu.AlisTarihi.ToString("dd.MM.yyyy HH:mm");
            lblIadeTarihi.Text = VeriDeposu.IadeTarihi.ToString("dd.MM.yyyy HH:mm");

            // Fiyat hesabını yap (Gün x Fiyat)
            int gun = (VeriDeposu.IadeTarihi - VeriDeposu.AlisTarihi).Days;
            if (gun <= 0) gun = 1;

            // "N2" sayesinde 1200,00 TL gibi janti durur
            lblKiralamaBedeli.Text = (gun * Convert.ToDouble(VeriDeposu.GunlukFiyat)).ToString("N2") + " TL";
        }



        public void FiyatHesapla()
        {
            int gun = (VeriDeposu.IadeTarihi - VeriDeposu.AlisTarihi).Days;
            if (gun <= 0) gun = 1;

            double aracTutar = gun * Convert.ToDouble(VeriDeposu.GunlukFiyat);
            double anaToplam = aracTutar + VeriDeposu.GuvenceTutari;

            // TOPLAM TUTAR = (Arac + Güvence) - İndirim
            double sonToplam = anaToplam - VeriDeposu.IndirimTutari;

            lblGuvenceTutari.Text = VeriDeposu.GuvenceTutari.ToString("N2") + " TL";
            lblToplamTutar.Text = sonToplam.ToString("N2") + " TL";
        }




        private void btnGuvenceEkle_Click(object sender, EventArgs e)
        {
            // Gün sayısını hesapla (Zaten Load'da yapmıştık)
            int gun = (VeriDeposu.IadeTarihi - VeriDeposu.AlisTarihi).Days;
            if (gun <= 0) gun = 1;

            // Paket ücreti (Günlük 459 TL diyelim)
            double paketUcreti = gun * 450;

            // Eğer buton "Ekle" modundaysa ekle, "Çıkar" modundaysa çıkar
            if (btnGuvenceEkle.Text.Contains("Ekle"))
            {
                VeriDeposu.GuvenceTutari = paketUcreti;
                btnGuvenceEkle.Text = "Çıkar | Toplam ₺ " + paketUcreti;
                btnGuvenceEkle.BackColor = Color.Green; // Seçildiğini belli et
            }
            else
            {
                VeriDeposu.GuvenceTutari = 0;
                btnGuvenceEkle.Text = "Ekle | Toplam ₺ " + paketUcreti;
                btnGuvenceEkle.BackColor = Color.Gray;
            }
            // Toplam tutarı ekranda hemen güncelle
            FiyatHesapla();


        }

        private void lblHasar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KDV dahil 10.000 TL'ye kadar oluşan tek taraflı hasarlarda kiracı beyanı ile onarım sağlar.");
        }

        private void lblLCFA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Araçların lastik, cam, far ve ayna hasarları için sunulan güvencedir. 1 parça ile sınırlıdır.");
        }

        private void lblFerdiKaza_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sürücü ve araç içindeki kişileri sigorta limitleri dahilinde güvence altına alır.");

        }

        private void lblSorumluluk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zorunlu mali mesuliyet (trafik) sigortasına ek 3. şahıslara karşı belirlenmiş limitler dahilinde zararları kapsar.");

        }

        private void lblSuperHasar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KDV dahil 12.000 TL'ye kadar oluşan tek taraflı hasarlarda kiracı beyanı ile onarım sağlar.");

        }

        private void lblLCFA2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Araçların lastik, cam, far ve ayna hasarları için sunulan güvencedir. 1 parça ile sınırlıdır.");

        }

        private void lblFerdiKaza2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sürücü ve araç içindeki kişileri sigorta limitleri dahilinde güvence altına alır.");

        }

        private void lblSorumluluk2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zorunlu mali mesuliyet (trafik) sigortasına ek 3. şahıslara karşı belirlenmiş limitler dahilinde zararları kapsar.");

        }

        private void btnSuperGuvence_Click(object sender, EventArgs e)
        {
            // Gün sayısını hesapla (Zaten Load'da yapmıştık)
            int gun = (VeriDeposu.IadeTarihi - VeriDeposu.AlisTarihi).Days;
            if (gun <= 0) gun = 1;

            // Paket ücreti (Günlük 459 TL diyelim)
            double paketUcreti = gun * 600;

            // Eğer buton "Ekle" modundaysa ekle, "Çıkar" modundaysa çıkar
            if (btnSuperGuvence.Text.Contains("Ekle"))
            {
                VeriDeposu.GuvenceTutari = paketUcreti;
                btnSuperGuvence.Text = "Çıkar | Toplam ₺ " + paketUcreti;
                btnSuperGuvence.BackColor = Color.Green; // Seçildiğini belli et
            }
            else
            {
                VeriDeposu.GuvenceTutari = 0;
                btnSuperGuvence.Text = "Ekle | Toplam ₺ " + paketUcreti;
                btnSuperGuvence.BackColor = Color.Gray;
            }

            // Toplam tutarı ekranda hemen güncelle
            FiyatHesapla();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKupon_Click(object sender, EventArgs e)
        {
            if (txtKuponKodu.Text == "ENES10")
            {
                // Önce indirimsiz ana tutarı hesapla (Arac + Güvence)
                int gun = (VeriDeposu.IadeTarihi - VeriDeposu.AlisTarihi).Days;
                if (gun <= 0) gun = 1;
                double anaTutar = (gun * Convert.ToDouble(VeriDeposu.GunlukFiyat)) + VeriDeposu.GuvenceTutari;

                // %20 indirimi hesapla ve depoya at
                VeriDeposu.IndirimTutari = anaTutar * 0.10;

                MessageBox.Show("Tebrikler! %10 indirim kazandın.");
                txtKuponKodu.Enabled = false; // Kuponu bir kere kullansın yeter
            }
            else
            {
                MessageBox.Show("Geçersiz kupon kodu!");
                VeriDeposu.IndirimTutari = 0;
            }

            // Fiyatı anında güncelle
            FiyatHesapla();
        }

        private void lblToplamTutar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa fr=new FrmAnaSayfa();
            fr.Show();
            this.Hide();
        }
    }
}
