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
    public partial class FrmMusteriGecmis : Form
    {
        public FrmMusteriGecmis()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmMusteriGecmis_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            GecmisListele();
        }
        public void GecmisListele()
        {
            // SQL sorgusu: Rezervasyon ve Araçlar tablolarını birleştiriyoruz
            string sorgu = @"SELECT 
                        A.AracMarka + ' ' + A.AracModel AS [Araç], 
                        A.AracPlaka AS [Plaka], 
                        R.AracTeslimTarihi AS [Alış Tarihi], 
                        R.PlanlananDonusTarihi AS [İade Tarihi], 
                        R.ToplamKiraBedeli AS [Tutar (TL)],
                        R.KiralamaStatu AS [Durum]
                     FROM TblRezervasyon R
                     INNER JOIN TblAraclar A ON R.Aracid = A.Aracid
                     WHERE R.Musteriid = @mid
                     ORDER BY R.AracTeslimTarihi DESC"; // En son yapılan kiralama en üstte görünsün

            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@mid", VeriDeposu.MusteriID);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvGecmis.DataSource = dt; // Verileri tabloya basıyoruz
            bgl.baglanti().Close();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            
        }
    }
}
