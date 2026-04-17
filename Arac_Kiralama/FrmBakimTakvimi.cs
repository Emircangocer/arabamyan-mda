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
using Microsoft.Data.SqlClient;
namespace Arac_Kiralama
{
    public partial class FrmBakimTakvimi : Form
    {
        public FrmBakimTakvimi()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btnBakimiTamamla_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kontroller: Araç seçili mi ve maliyet girilmiş mi?
                if (dgvTumAraclar.CurrentRow == null)
                {
                    MessageBox.Show("Kanka önce listeden bir araç seçmelisin!");
                    return;
                }

                if (string.IsNullOrEmpty(txtBakimMaliyet.Text) || Convert.ToDecimal(txtBakimMaliyet.Text) <= 0)
                {
                    MessageBox.Show("Kanka bedavaya bakım olmaz, lütfen geçerli bir maliyet gir!");
                    return;
                }

                // 2. Değişkenleri Hazırla
                int seciliAracId = Convert.ToInt32(dgvTumAraclar.CurrentRow.Cells["Aracid"].Value);
                decimal maliyet = Convert.ToDecimal(txtBakimMaliyet.Text);
                string aciklama = txtBakimAciklama.Text;

                // 3. TblBakim Tablosuna Kayıt (Arşiv ve Gider Takibi)
                // Senin tablonun kolon isimlerine göre hazırladım: BakimMaaliyeti, BakimAciklama vb.
                string sorguBakim = @"INSERT INTO TblBakim (Aracid, BakimBaslangicTarihi, BakimBitisTarihi, BakimAciklama, BakimMaaliyeti) 
                             VALUES (@id, GETDATE(), GETDATE(), @aciklama, @maliyet)";

                SqlCommand cmd1 = new SqlCommand(sorguBakim, bgl.baglanti());
                cmd1.Parameters.AddWithValue("@id", seciliAracId);
                cmd1.Parameters.AddWithValue("@aciklama", aciklama);
                cmd1.Parameters.AddWithValue("@maliyet", maliyet);
                cmd1.ExecuteNonQuery();

                // 4. TblAraclar Tablosunu Güncelle (Alarm Kurma ve Kilidi Açma)
                // Hem tarihi 1 ay ileri atar hem de durumu 'Müsait' yapar
                string sorguAracGuncelle = @"UPDATE TblAraclar 
                                    SET GelecekBakimTarihi = DATEADD(month, 1, GETDATE()), 
                                        AracStatu = 'Müsait' 
                                    WHERE Aracid = @id";

                SqlCommand cmd2 = new SqlCommand(sorguAracGuncelle, bgl.baglanti());
                cmd2.Parameters.AddWithValue("@id", seciliAracId);
                cmd2.ExecuteNonQuery();

                // Bağlantıyı kapat ve kullanıcıya haber ver
                bgl.baglanti().Close();

                MessageBox.Show("Bakım başarıyla tamamlandı kanka!\n- Masraf kasadan düşüldü.\n- Araç tekrar kiralamaya açıldı.\n- Bir sonraki bakım 1 ay sonraya kuruldu.");

                // 5. Listeyi Yenile (Metodun isminin bu olduğundan eminiz)
                TumBakimListesiniGetir();

                // Formdaki kutuları temizle
                txtBakimMaliyet.Clear();
                txtBakimAciklama.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu kanka: " + ex.Message);
            }
            FrmYoneticiPanel frmYonetici = (FrmYoneticiPanel)Application.OpenForms["FrmYoneticiPanel"];
            if (frmYonetici != null)
            {
                frmYonetici.IstatistikleriYukle(); // Kasayı anında günceller kanka!
            }
        }
        public void TumBakimListesiniGetir()
        {
            // Araçlar tablosundan plaka, marka, model ve o meşhur gelecek bakım tarihini çekiyoruz
            string sorgu = @"SELECT Aracid, AracPlaka, AracMarka, AracModel, GelecekBakimTarihi 
                     FROM TblAraclar";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Tasarımdaki DataGridView ismin neyse onu yaz kanka (dgvTumAraclar diye varsaydım)
            dgvTumAraclar.DataSource = dt;

            bgl.baglanti().Close();
        }

        private void FrmBakimTakvimi_Load(object sender, EventArgs e)
        {
            TumBakimListesiniGetir();
        }

        private void dgvTumAraclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tıkladığın satırdaki plaka ve marka/modeli textbox'lara yazalım ki yönetici kimi seçtiğini görsün
            txtBakimAciklama.Text = dgvTumAraclar.CurrentRow.Cells["AracPlaka"].Value.ToString() + " Bakımı";
            txtBakimMaliyet.Text = "0"; // Başlangıç değeri
        }
    }
}
