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
using System.Data;

namespace Arac_Kiralama
{
    public partial class FrmYoneticiPanel_Musteriler : Form
    {
        public Form anaForm;
        public FrmYoneticiPanel_Musteriler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void MusteriListele()
        {
            // Kanka burada sadece yöneticiye lazım olan 4-5 kolonu çekersen daha şık durur
            string sorgu = "SELECT Musteriid, MusteriAd, MusteriSoyad, MusteriTc, MusteriTelefon FROM TblMusteri";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMusteriler.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void FrmMusteriKayit_Load(object sender, EventArgs e)
        {

        }
        private void FrmYoneticiPanel_Musteriler_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;

            MusteriListele();
            dgvMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void txtMusteriAra_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM TblMusteri WHERE MusteriAd LIKE @p1 + '%'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", txtMusteriAra.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMusteriler.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.anaForm != null)
            {
                this.anaForm.Show(); // Gizli olan o tek yönetici panelini geri getir
            }
            this.Close(); 
        }
    }
}
