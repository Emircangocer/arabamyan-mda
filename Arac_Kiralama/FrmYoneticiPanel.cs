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
    public partial class FrmYoneticiPanel : Form
    {
        public FrmYoneticiPanel()
        {
            InitializeComponent();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            FrmYoneticiPanel_Musteriler fr = new FrmYoneticiPanel_Musteriler();
            fr.Show();
            this.Hide();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public void RezervasyonlariGetir()
        {
            // Inner Join kullanarak tabloları birleştiriyoruz
            string sorgu = @"SELECT 
                        R.Kiralamaid, 
                        M.MusteriAd + ' ' + M.MusteriSoyad AS [Müşteri], 
                        A.AracPlaka AS [Plaka], 
                        A.AracMarka + ' ' + A.AracModel AS [Araç], 
                        R.AracTeslimTarihi AS [Alış Tarihi], 
                        R.PlanlananDonusTarihi AS [İade Tarihi], 
                        R.AlisKm AS [Alış KM],
                        R.AlinanDepozito AS [Depozito], 
                        R.KiralamaStatu AS [Durum]
                     FROM TblRezervasyon R
                     INNER JOIN TblMusteri M ON R.Musteriid = M.Musteriid
                     INNER JOIN TblAraclar A ON R.Aracid = A.Aracid
                     WHERE R.KiralamaStatu = 'Aktif / Depozito Alındı'"; // Sadece aktifleri görelim

            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRezervasyonlar.DataSource = dt;
            bgl.baglanti().Close();
        }
        private void FrmYoneticiPanel_Load(object sender, EventArgs e)
        {
            RezervasyonlariGetir();
        }

        private void dgvRezervasyonlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRezervasyonlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 0. sütunda Kiralamaid olduğunu varsayıyoruz
                VeriDeposu.SecilenRezervasyonID = Convert.ToInt32(dgvRezervasyonlar.Rows[e.RowIndex].Cells[0].Value);

                // Bu ID'yi aldık, artık iade butonuna bastığımızda hangisini iade edeceğimizi biliyoruz!
                MessageBox.Show("Rezervasyon seçildi kanka, iade işlemine hazırız!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmYoneticiIadeOnay fr = new FrmYoneticiIadeOnay();
            fr.ShowDialog(); // .Show() yerine .ShowDialog() kullan ki form kapanana kadar beklesin

            // İade formu kapandığı an, bu satır çalışır ve listeyi tazeler:
            RezervasyonlariGetir();
        }
    }
}
    
    

