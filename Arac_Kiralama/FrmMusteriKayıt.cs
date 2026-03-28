using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arac_Kiralama
{
    public partial class FrmMusteriKayıt : Form
    {
        public FrmMusteriKayıt()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            FrmMusteriKayit2 fr =new FrmMusteriKayit2();
            fr.Show();
            this.Hide();

        }
    }
}
