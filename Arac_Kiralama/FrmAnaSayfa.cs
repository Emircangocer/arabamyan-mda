using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arac_Kiralama
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        public static Guna2ComboBox combo;



        private void button1_Click(object sender, EventArgs e)
        {
            FrmMusteriGiris fr = new FrmMusteriGiris();
            fr.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            guna2DateTimePicker1.MinDate = DateTime.Today;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmMusteriGiris fr = new FrmMusteriGiris();
            fr.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            pnliadeNoktasi.Visible = guna2ToggleSwitch1.Checked;
            lbliadeNoktasi.Visible = guna2ToggleSwitch1.Checked;
            gunacmbİadeNoktasi.Visible = (guna2ToggleSwitch1.Checked);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOfisler fr = new FrmOfisler();
            fr.Show();
            this.Hide();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmYoneticiAracEkle fr=new FrmYoneticiAracEkle();
            fr.Show();
            this.Hide();
        }
    }
}
