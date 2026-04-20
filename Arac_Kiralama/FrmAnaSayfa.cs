using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arac_Kiralama
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        public static Guna2ComboBox combo;



        private void button1_Click(object sender, EventArgs e)
        {
            FrmMusteriGiris fr = new FrmMusteriGiris();
            fr.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtpAlis.MinDate = DateTime.Today;
            // Alış tarihi değiştiği an, iade tarihinin alt limitini alış tarihine eşitliyoruz
            dtpIade.MinDate = dtpAlis.Value;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmMusteriGiris fr = new FrmMusteriGiris();
            if (fr.ShowDialog() == DialogResult.OK) // Giriş başarılı olduysa
            {
                // Eski butonları gizle
                btnMusteriGiris.Visible = false;
                btnYoneticiGiris.Visible = false;

                // Yeni butonları ve bilgileri göster
                btnHesabim.Visible = true;
                lblMusteriAd.BringToFront();
                lblMusteriAd.Text = VeriDeposu.GirisYapanMusteriAdSoyad;
                lblBakiye.Text = VeriDeposu.MusteriBakiye.ToString("N2") + " TL";
                AktifKiralamayiGetir();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            pnliadeNoktasi.Visible = swFarkliLokasyon.Checked;
            lbliadeNoktasi.Visible = swFarkliLokasyon.Checked;
            cmbIadeNoktasi.Visible = (swFarkliLokasyon.Checked);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOfisler fr = new FrmOfisler();
            fr.Show();
            this.Hide();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAraclar fr=new FrmAraclar();
            fr.Show();
            this.Hide();
        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            FrmYoneticiGiris fr = new FrmYoneticiGiris();
            fr.Show();
        }
        public void BilgileriGuncelle()
        {
            // 1. Bakiyeyi SQL'den tekrar çekip label'a yaz
            // Not: VeriDeposu'ndaki bakiye düştüğü için direkt oradan da yazdırabilirsin
            lblBakiye.Text = VeriDeposu.MusteriBakiye.ToString("N2") + " TL";

            // 2. Aktif kiralama panelini (o beyaz kartı) getiren metodunu buraya ekle
            // Muhtemelen adı şöyledir (adını kontrol et kanka):
            AktifKiralamayiGetir();
        }
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            if (VeriDeposu.GirisYapildiMi)
            {

                // Giriş yapıldıysa Giriş butonlarını gizle
                btnMusteriGiris.Visible = false;
                btnYoneticiGiris.Visible = false;

                // Kullanıcı ismini göster
                lblMusteriAd.Text = "Hoş geldin, " + VeriDeposu.GirisYapanMusteriAdSoyad;
                lblMusteriAd.Visible = true;
                btnCikis.Visible = true; // İstersen çıkış butonu da koyabilirsin
            }
            else
            {
                // Giriş yapılmadıysa butonlar görünür kalsın
                btnMusteriGiris.Visible = true;
                btnYoneticiGiris.Visible = true;
            }

                BilgileriGuncelle();

            dtpIade.MinDate = DateTime.Now.AddDays(1);
        }

        private void btnAraclariKesfet_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Alış Tarihini al (Sadece Tarih Kısmı)
                DateTime alisTarihi = dtpAlis.Value.Date;

                // 2. ComboBox'tan seçilen saati (Örn: "15:00") parçalara ayır
                // ComboBox'ta tam olarak "15:00" yazdığından emin ol!
                string[] alisSaatParcalari = cmbAlisSaati.Text.Split(':');
                int alisSaat = Convert.ToInt32(alisSaatParcalari[0]);
                int alisDakika = Convert.ToInt32(alisSaatParcalari[1]);

                // 3. Tarih ve Saati güvenli bir şekilde birleştir
                VeriDeposu.AlisTarihi = new DateTime(alisTarihi.Year, alisTarihi.Month, alisTarihi.Day, alisSaat, alisDakika, 0);

                // --- AYNI İŞLEMİ İADE İÇİN DE YAPIYORUZ ---
                DateTime iadeTarihi = dtpIade.Value.Date;
                string[] iadeSaatParcalari = cmbiadeSaati.Text.Split(':');
                int iadeSaat = Convert.ToInt32(iadeSaatParcalari[0]);
                int iadeDakika = Convert.ToInt32(iadeSaatParcalari[1]);

                VeriDeposu.AlisOfisi = cmbAlisNoktasi.Text;
                VeriDeposu.FarkliLokasyonVarMi = swFarkliLokasyon.Checked;

                // Eğer farklı yer seçildiyse ComboBox'taki şehri al, seçilmediyse alış yerini al
                VeriDeposu.IadeOfisi = swFarkliLokasyon.Checked ? cmbIadeNoktasi.Text : cmbAlisNoktasi.Text;

                VeriDeposu.IadeTarihi = new DateTime(iadeTarihi.Year, iadeTarihi.Month, iadeTarihi.Day, iadeSaat, iadeDakika, 0);

                // 4. Formu Aç
                FrmAraclar fr = new FrmAraclar();
                fr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saat seçimi hatalı! Lütfen ComboBox'tan geçerli bir saat (Örn: 15:00) seçin.");
            }
        }

        private void btnHesabim_Click(object sender, EventArgs e)
        {
            pnlHesabim.Visible = !pnlHesabim.Visible;
            lblMusteriAd.Text = VeriDeposu.GirisYapanMusteriAdSoyad;
            lblMusteriAd.BringToFront();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            // 1. Giriş durumunu sıfırla
            VeriDeposu.GirisYapildiMi = false;
            VeriDeposu.MusteriID = 0; // ID'yi de sıfırla ki çakışma olmasın kanka

            // 2. Panelleri gizle
            pnlHesabim.Visible = false;
            btnHesabim.Visible = false;

            // 🔥 İŞTE BURASI: Aktif araç panelini temizle ve gizle
            pnlAktifArac.Controls.Clear(); // İçindeki kartı siliyoruz
            pnlAktifArac.Visible = false;   // Paneli komple saklıyoruz

            // 3. Giriş butonlarını geri getir
            btnMusteriGiris.Visible = true;
            btnYoneticiGiris.Visible = true;

            // İstersen kullanıcı adını da temizle
            lblMusteriAd.Text = "";

            MessageBox.Show("Başarıyla çıkış yapıldı, yine bekleriz!");
        }



        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btnBakiyeEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtYuklenecekTutar.Text))
            {
                MessageBox.Show("Lütfen miktar giriniz!");
                return;
            }

            try
            {
                string girilenMetin = txtYuklenecekTutar.Text.Trim();

                // Eğer virgül yerine nokta girildiyse veya tam tersiyse diye ufak bir ayar
                girilenMetin = girilenMetin.Replace(".", ",");

                double eklenenTutar = Convert.ToDouble(girilenMetin);

                // 2. SQL'e ekle
                string sorgu = "UPDATE TblMusteri SET MusteriBakiye = MusteriBakiye + @p1 WHERE Musteriid = @p2";
                SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", eklenenTutar);
                komut.Parameters.AddWithValue("@p2", VeriDeposu.MusteriID);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                // 3. Hafızayı (VeriDeposu) güncelle
                VeriDeposu.MusteriBakiye += eklenenTutar;

                // 4. Ekrandaki Label'ı hemen güncelle
                lblBakiye.Text = VeriDeposu.MusteriBakiye.ToString("N2") + " TL";

                // 5. Temizlik ve geri bildirim
                txtYuklenecekTutar.Clear();
                MessageBox.Show("Bakiye yüklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata detayı: " + ex.Message);
            }
        }


        public void AktifKiralamayiGetir()
        {
           
            // Önce paneli bir temizleyelim, üst üste binmesinler
            pnlAktifArac.Controls.Clear();
            pnlAktifArac.Visible = false;

            // Kiralama detaylarını ve araç bilgilerini çekiyoruz
            string sorgu = @"SELECT A.AracResim, A.AracPlaka, A.AracMarka, A.AracModel, R.PlanlananDonusTarihi 
                 FROM TblRezervasyon R
                 INNER JOIN TblAraclar A ON R.Aracid = A.Aracid
                 WHERE R.Musteriid = @mid AND R.KiralamaStatu LIKE '%Aktif%'";

            SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
            komut.Parameters.AddWithValue("@mid", VeriDeposu.MusteriID);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                

                pnlAktifArac.Visible = true; // Araç varmış, paneli aç kanka!

                // Yeni bir UC_AktifKiralama nesnesi oluşturuyoruz
                UC_AktifKiralama aktifKart = new UC_AktifKiralama();

                // Verileri karta basıyoruz
                string plakaModel = dr["AracPlaka"].ToString() + " - " + dr["AracMarka"].ToString() + " " + dr["AracModel"].ToString();
                string resimYolu = dr["AracResim"].ToString();
                DateTime iadeTarihi = Convert.ToDateTime(dr["PlanlananDonusTarihi"]);

                // UC içindeki metodu çağırıyoruz (BilgiBas gibi düşün)
                aktifKart.KiralamaBilgileriniYukle(plakaModel, resimYolu, iadeTarihi);

                // KARTIN PANELE OTURMASI İÇİN:
                aktifKart.Dock = DockStyle.Fill; // Paneli tam kaplasın
                pnlAktifArac.Controls.Add(aktifKart); // Ve bombayı panele bırakıyoruz!
            }
            
            bgl.baglanti().Close();
        }

        private void btnGecmisKiralamalar_Click(object sender, EventArgs e)
        {
            FrmMusteriGecmis fr = new FrmMusteriGecmis();
            fr.Show(); // Geçmiş sayfasını aç !
        }

        private void BtnKilamaKosullari_Click(object sender, EventArgs e)
        {
            KiralamaKosullari fr=new KiralamaKosullari();
            fr.Show();
            this.Hide();
        }
    }
}
    

