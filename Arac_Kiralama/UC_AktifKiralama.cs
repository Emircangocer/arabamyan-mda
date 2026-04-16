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
    public partial class UC_AktifKiralama : UserControl
    {
        public UC_AktifKiralama()
        {
            InitializeComponent();
        }

        private void UC_AktifKiralama_Load(object sender, EventArgs e)
        {

        }
        public void KiralamaBilgileriniYukle(string plakaModel, string resimYolu, DateTime iadeTarihi)
        {
            lblPlakaModel.Text = plakaModel;
            pbAracResim.ImageLocation = resimYolu;

            // Kalan Süre Hesaplama
            TimeSpan fark = iadeTarihi - DateTime.Now;

            if (fark.TotalHours > 0)
            {
                lblKalanSure.Text = $"İadeye: {Math.Floor(fark.TotalDays)} Gün {fark.Hours} Saat Kaldı";
                lblKalanSure.ForeColor = Color.Green;
            }
            else
            {
                lblKalanSure.Text = "Süre Doldu!";
                lblKalanSure.ForeColor = Color.Red;
            }
        }

        private void btnIadeTalebi_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Aracı iade etmek istediğinize emin misiniz?", "İade Talebi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (secenek == DialogResult.Yes)
            {
                SqlBaglantisi bgl = new SqlBaglantisi();
                string sorgu = "UPDATE TblRezervasyon SET KiralamaStatu = 'İade Bekliyor' WHERE Musteriid = @mid AND KiralamaStatu = 'Aktif/Depozito Alındı'";

                SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
                komut.Parameters.AddWithValue("@mid", VeriDeposu.MusteriID);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("İade talebin alındı! Yönetici onaylayınca depoziton iade edilecek.");

                // Butonu pasif yapalım ki on defa basmasın
                btnIadeTalebi.Enabled = false;
                btnIadeTalebi.Text = "Onay Bekleniyor...";
            }
        }
    }
}
