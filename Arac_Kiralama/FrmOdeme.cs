using Microsoft.Data.SqlClient;
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
            double anaToplam = aracTutar + VeriDeposu.GuvenceTutari - VeriDeposu.IndirimTutari;

            // Toplam Ödenecek = Kira Bedeli + Depozito
            double sonTutar = anaToplam + VeriDeposu.SecilenAracDepozito;

            lblGuvenceTutari.Text = VeriDeposu.GuvenceTutari.ToString("N2") + " TL";
            lblDepozito.Text = VeriDeposu.SecilenAracDepozito.ToString("N2") + " TL"; // Yeni label
            lblToplamTutar.Text = sonTutar.ToString("N2") + " TL";
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
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.Show();
            this.Hide();
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            // 1. Bakiye Kontrolü (Kira + Depozito yetiyor mu?)
            double odenecekTutar = (double.Parse(lblToplamTutar.Text.Replace(" TL", "")));
            SqlBaglantisi bgl=new SqlBaglantisi();
            if (VeriDeposu.MusteriBakiye < odenecekTutar)
            {
                MessageBox.Show("Bakiye yetersiz! Depozito dahil tutar: " + odenecekTutar + " TL");
                return;
            }

            try
            {
                // 2. Bakiyeden Düş (SQL)
                string bakiyeSorgu = "UPDATE TblMusteri SET MusteriBakiye = MusteriBakiye - @fiyat WHERE Musteriid = @id";
                SqlCommand bakiyeKomut = new SqlCommand(bakiyeSorgu, bgl.baglanti());
                bakiyeKomut.Parameters.AddWithValue("@fiyat", odenecekTutar);
                bakiyeKomut.Parameters.AddWithValue("@id", VeriDeposu.MusteriID);
                bakiyeKomut.ExecuteNonQuery();
                bgl.baglanti().Close();

                // 3. Rezervasyonu Kaydet
                string rezSorgu = "INSERT INTO TblRezervasyon (Musteriid, Aracid, AracTeslimTarihi, PlanlananDonusTarihi,AlisKm,AlisYakitMiktar, AlinanDepozito, ToplamKiraBedeli, KiralamaStatu) " +
                                  "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7,@p8,@p9)";
                SqlCommand rezKomut = new SqlCommand(rezSorgu, bgl.baglanti());
                rezKomut.Parameters.AddWithValue("@p1", VeriDeposu.MusteriID);
                rezKomut.Parameters.AddWithValue("@p2", VeriDeposu.SecilenAracID);
                rezKomut.Parameters.AddWithValue("@p3", VeriDeposu.AlisTarihi);
                rezKomut.Parameters.AddWithValue("@p4", VeriDeposu.IadeTarihi);
                rezKomut.Parameters.AddWithValue("@p5", VeriDeposu.SecilenAracKm);
                rezKomut.Parameters.AddWithValue("@p6", VeriDeposu.SecilenAracYakit);
                rezKomut.Parameters.AddWithValue("@p7", VeriDeposu.SecilenAracDepozito);
                rezKomut.Parameters.AddWithValue("@p8", odenecekTutar);

                rezKomut.Parameters.AddWithValue("@p9", "Aktif / Depozito Alındı");
                rezKomut.ExecuteNonQuery();
                bgl.baglanti().Close();

                // 4. Aracın Durumunu Güncelle (Artık bu araç dolu)
                string aracGuncelle = "UPDATE TblAraclar SET AracStatu = 'Dolu' WHERE Aracid = @id";
                SqlCommand aracKomut = new SqlCommand(aracGuncelle, bgl.baglanti());
                aracKomut.Parameters.AddWithValue("@id", VeriDeposu.SecilenAracID);
                aracKomut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Ödeme başarılı! İyi yolculuklar!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
