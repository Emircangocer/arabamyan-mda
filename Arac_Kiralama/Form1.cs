namespace Arac_Kiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
    }
}
