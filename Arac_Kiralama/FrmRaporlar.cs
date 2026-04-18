using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kiralama
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            RaporlariYukle();
            AraclarıGetir();
        }

        public void AraclarıGetir()
        {
            string sorgu = "SELECT Aracid, AracPlaka FROM TblAraclar";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0) // Veri gelmiş mi kontrol edelim
            {
                cmbAracSec.DataSource = dt;
                // Ekranda ne görünecek?
                cmbAracSec.DisplayMember = "AracPlaka";
                // Arkada hangi ID tutulacak?
                cmbAracSec.ValueMember = "Aracid";
            }
            else
            {
                MessageBox.Show("Sistemde kayıtlı araç bulunamadı kanka!");
            }
            bgl.baglanti().Close();
        }

        public void RaporlariYukle()
        {
            // 1. Tabloyu Doldur (Araç Performans Listesi)
            string tabloSorgu = @"SELECT 
                            A.AracPlaka AS [PLAKA], 
                            A.AracMarka + ' ' + A.AracModel AS [ARAÇ], 
                            COUNT(R.Kiralamaid) AS [KİRALAMA SAYISI],
                            SUM(R.ToplamKiraBedeli) AS [TOPLAM GELİR]
                         FROM TblAraclar A
                         INNER JOIN TblRezervasyon R ON A.Aracid = R.Aracid
                         GROUP BY A.AracPlaka, A.AracMarka, A.AracModel
                         ORDER BY [TOPLAM GELİR] DESC";

            SqlDataAdapter da = new SqlDataAdapter(tabloSorgu, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGelirRaporu.DataSource = dt;

            // 2. TileButton'ları Doldur (İstatistikler)

            // Toplam Ciro Hesabı
            object toplamCiro = dt.Compute("SUM([TOPLAM GELİR])", "");
            btnToplamCiro.Text = "TOPLAM CİRO\n" + (toplamCiro != DBNull.Value ? Convert.ToDouble(toplamCiro).ToString("N2") : "0") + " TL";

            // Toplam Kiralama Sayısı
            object toplamAdet = dt.Compute("SUM([KİRALAMA SAYISI])", "");
            btnToplamKiralama.Text = "TOPLAM KİRALAMA\n" + (toplamAdet != DBNull.Value ? toplamAdet.ToString() : "0") + " ADET";

            // En Popüler Araç (Listenin en üstündeki araç)
            if (dt.Rows.Count > 0)
            {
                btnEnPopulerArac.Text = "LİDER ARAÇ\n" + dt.Rows[0]["PLAKA"].ToString();
            }

            bgl.baglanti().Close();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                // Başlık
                ev.Graphics.DrawString("ARABAMYANIMDA - YÖNETİCİ PERFORMANS RAPORU", new Font("Arial", 18, FontStyle.Bold), Brushes.DarkBlue, 120, 50);
                ev.Graphics.DrawString("Rapor Tarihi: " + DateTime.Now.ToString(), new Font("Arial", 10), Brushes.Black, 120, 90);
                ev.Graphics.DrawLine(Pens.Black, 100, 110, 750, 110);

                // Tablo Başlıkları
                int y = 140;
                ev.Graphics.DrawString("ARAÇ BİLGİSİ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 120, y);
                ev.Graphics.DrawString("ADET", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 400, y);
                ev.Graphics.DrawString("TOPLAM GELİR", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 550, y);

                ev.Graphics.DrawLine(Pens.Gray, 100, y + 25, 750, y + 25);
                y += 40;

                // Verileri Yazdır
                foreach (DataGridViewRow row in dgvGelirRaporu.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        ev.Graphics.DrawString(row.Cells[1].Value.ToString(), new Font("Arial", 11), Brushes.Black, 120, y);
                        ev.Graphics.DrawString(row.Cells[2].Value.ToString(), new Font("Arial", 11), Brushes.Black, 400, y);
                        ev.Graphics.DrawString(row.Cells[3].Value.ToString() + " TL", new Font("Arial", 11), Brushes.Black, 550, y);
                        y += 30;
                    }
                }

                ev.Graphics.DrawString("--- Raporun Sonudur ---", new Font("Arial", 10, FontStyle.Italic), Brushes.Gray, 350, y + 50);
            };

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog(); // Bu pencerede "Yazdır" deyip PDF seçebilirsin kanka.
        }

        private void cmbAracSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 🔥 Burası koruma kalkanımız. DataRowView hatasını bu engelliyor:
            if (cmbAracSec.SelectedValue != null && cmbAracSec.ValueMember != "" && cmbAracSec.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    // Seçilen aracın ID'sini güvenle alıyoruz
                    int secilenID = Convert.ToInt32(cmbAracSec.SelectedValue);

                    // SQL Sorgusuyla hasar geçmişini getiren kısım (Senin eski kodun buradaydı):
                    string sorgu = @"SELECT 
                                H.HasarliParca AS [PARÇA], 
                                H.HasarAciklama AS [AÇIKLAMA], 
                                H.HasarMaliyeti AS [MALİYET], 
                                R.AracTeslimTarihi AS [TARİH]
                             FROM TblHasarlar H
                             JOIN TblRezervasyon R ON H.Kiralamaid = R.Kiralamaid
                             WHERE H.Aracid = @p1";

                    SqlCommand cmd = new SqlCommand(sorgu, bgl.baglanti());
                    cmd.Parameters.AddWithValue("@p1", secilenID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvHasarGecmisi.DataSource = dt;

                    // Özet Butonuna Toplam Hasarı Yazdır
                    object toplam = dt.Compute("SUM([MALİYET])", "");
                    btnAracHasarOzet.Text = "BU ARACIN TOPLAM HASARI\n" +
                                           (toplam != DBNull.Value ? Convert.ToDouble(toplam).ToString("N2") : "0") + " TL";

                    bgl.baglanti().Close();
                }
                catch (Exception ex)
                {
                    // Hata olursa uygulamayı kapatmasın, buraya düşsün
                    // MessageBox.Show("Hata: " + ex.Message); 
                }
            }
        }

        private void btnAracRaporYazdir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                // 1. Başlık ve Logo Alanı
                ev.Graphics.DrawString("ARAÇ HASAR GEÇMİŞİ RAPORU", new Font("Arial", 18, FontStyle.Bold), Brushes.Red, 200, 50);
                ev.Graphics.DrawString("Plaka: " + cmbAracSec.Text, new Font("Arial", 14), Brushes.Black, 100, 100);
                ev.Graphics.DrawLine(Pens.Black, 100, 130, 750, 130);

                int y = 160;

                // 2. Tablo Başlıkları (Çıktıda ne olduğu belli olsun kanka)
                ev.Graphics.DrawString("Tarih          | Parça          | Maliyet", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, 100, y);
                y += 30;

                foreach (DataGridViewRow row in dgvHasarGecmisi.Rows)
                {
                    // Satırın boş olup olmadığını kontrol ediyoruz
                    if (row.Cells[0].Value != null)
                    {
                        // 🔥 KRİTİK DÜZELTME: Tarih hücresi boşsa veya hatalıysa Substring patlar. 
                        // O yüzden güvenli bir dönüşüm yapıyoruz:
                        string tarihStr = row.Cells[3].Value != null ? Convert.ToDateTime(row.Cells[3].Value).ToShortDateString() : "---";

                        string parca = row.Cells[0].Value.ToString();
                        string maliyet = row.Cells[2].Value.ToString() + " TL";
                        string not = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "Not yok.";

                        string satir = $"{tarihStr} | {parca} | {maliyet}";

                        ev.Graphics.DrawString(satir, new Font("Arial", 11), Brushes.Black, 100, y);
                        // Notu bir alt satıra hafif gri ve eğik yazdırıyoruz (Şık durur)
                        ev.Graphics.DrawString("Açıklama: " + not, new Font("Arial", 9, FontStyle.Italic), Brushes.Gray, 120, y + 20);

                        y += 50; // Bir sonraki hasar kaydı için aşağı in

                        // Sayfa sonuna gelip gelmediğini kontrol etmek istersen (opsiyonel)
                        if (y > 1000) break;
                    }
                }
            };

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = pd };
            // Pencereyi biraz büyük açalım ki rahat görelim
            ppd.WindowState = FormWindowState.Maximized;
            ppd.ShowDialog();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            FrmYoneticiPanel fr= new FrmYoneticiPanel();
            fr.Show();
            this.Hide();
        }
    }
}
