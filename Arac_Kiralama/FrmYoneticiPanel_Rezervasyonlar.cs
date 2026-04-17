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
    public partial class FrmYoneticiPanel_Rezervasyonlar : Form
    {
        public FrmYoneticiPanel_Rezervasyonlar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmYoneticiPanel_Rezervasyonlar_Load(object sender, EventArgs e)
        {
            cmbFiltre.Text = "Hepsi"; // Başlangıçta hepsini seç
            RezervasyonlariListele("Hepsi");
            dgvTumRezervasyonlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void RezervasyonlariListele(string durum = "Hepsi")
        {
            string sorgu = @"SELECT 
                        R.Kiralamaid AS [ID], 
                        M.MusteriAd + ' ' + M.MusteriSoyad AS [Müşteri], 
                        A.AracPlaka AS [Plaka], 
                        A.AracMarka + ' ' + A.AracModel AS [Araç], 
                        R.AracTeslimTarihi AS [Alış Tarihi], 
                        R.PlanlananDonusTarihi AS [İade Tarihi], 
                        R.ToplamKiraBedeli AS [Tutar],
                        R.KiralamaStatu AS [Durum]
                     FROM TblRezervasyon R
                     INNER JOIN TblMusteri M ON R.Musteriid = M.Musteriid
                     INNER JOIN TblAraclar A ON R.Aracid = A.Aracid";

            // Eğer "Hepsi" seçili değilse sorguya WHERE şartı ekliyoruz
            if (durum != "Hepsi")
            {
                sorgu += " WHERE R.KiralamaStatu = @p1";
            }

            sorgu += " ORDER BY R.Kiralamaid DESC";

            SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());

            if (durum != "Hepsi")
            {
                komut.Parameters.AddWithValue("@p1", durum);
            }

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTumRezervasyonlar.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void cmbFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            RezervasyonlariListele(cmbFiltre.Text);
        }
    }
}
