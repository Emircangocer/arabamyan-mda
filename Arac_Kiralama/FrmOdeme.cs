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
            DateTime baslangic = VeriDeposu.AlisTarihi;
            DateTime bitis = VeriDeposu.IadeTarihi;

            // Gün farkını hesapla
            TimeSpan fark = bitis - baslangic;
            int gun = fark.Days;
            if (gun <= 0) gun = 1; // Aynı günse 1 gün sayalım

            // Fiyatı depodan veya değişkenden alıp çarp
            double gunlukFiyat = Convert.ToDouble(this.fiyat); // UserControl'den gelen fiyat
            VeriDeposu.ToplamTutar = gun * gunlukFiyat;

            lblToplamTutar.Text = VeriDeposu.ToplamTutar.ToString() + " TL";
            lblAlisTarihi.Text= VeriDeposu.AlisTarihi.ToString("dd.MM.yyyy HH:mm");

        }
    }
}
