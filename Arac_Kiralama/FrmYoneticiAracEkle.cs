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
    public partial class FrmYoneticiAracEkle : Form
    {
        public FrmYoneticiAracEkle()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            

            SqlCommand komut = new SqlCommand("insert into TblAraclar (AracPlaka, AracMarka, AracModel, AracGunlukUcret, AracYakitTipi, AracSanziman, AracKm, AracStatu) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtGunlukUcret.Text)); // Decimal kuralını hatırladın mı?
            komut.Parameters.AddWithValue("@p5", cmbYakitTipi.Text);
            komut.Parameters.AddWithValue("@p6", cmbSanzıman.Text);
            komut.Parameters.AddWithValue("@p7", int.Parse(txtKm.Text));
            komut.Parameters.AddWithValue("@p8", "Müsait"); // Yeni eklenen araç direkt müsait başlar

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Araç başarıyla sisteme kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
