namespace Arac_Kiralama
{
    partial class FrmYoneticiAracEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYoneticiAracEkle));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtPlaka = new TextBox();
            txtMarka = new TextBox();
            label2 = new Label();
            txtModel = new TextBox();
            label3 = new Label();
            txtGunlukUcret = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtKm = new TextBox();
            label7 = new Label();
            cmbYakitTipi = new ComboBox();
            cmbSanzıman = new ComboBox();
            btnAracEkle = new Button();
            pictureBox1 = new PictureBox();
            btnListele = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(394, 185);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1195, 706);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 226);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 1;
            label1.Text = "Plaka:";
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(147, 220);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(182, 34);
            txtPlaka.TabIndex = 2;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(147, 272);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(182, 34);
            txtMarka.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 275);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 3;
            label2.Text = "Marka:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(147, 324);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(182, 34);
            txtModel.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 327);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 5;
            label3.Text = "Model:";
            // 
            // txtGunlukUcret
            // 
            txtGunlukUcret.Location = new Point(147, 377);
            txtGunlukUcret.Name = "txtGunlukUcret";
            txtGunlukUcret.Size = new Size(182, 34);
            txtGunlukUcret.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 377);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 7;
            label4.Text = "Günlük Ücret:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 432);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 9;
            label5.Text = "Yakıt Tipi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 484);
            label6.Name = "label6";
            label6.Size = new Size(100, 28);
            label6.TabIndex = 11;
            label6.Text = "Şanzıman:";
            // 
            // txtKm
            // 
            txtKm.Location = new Point(147, 539);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(182, 34);
            txtKm.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(92, 539);
            label7.Name = "label7";
            label7.Size = new Size(45, 28);
            label7.TabIndex = 13;
            label7.Text = "Km:";
            // 
            // cmbYakitTipi
            // 
            cmbYakitTipi.FormattingEnabled = true;
            cmbYakitTipi.Items.AddRange(new object[] { "Benzin", "Dizel", "Hibrit" });
            cmbYakitTipi.Location = new Point(147, 432);
            cmbYakitTipi.Name = "cmbYakitTipi";
            cmbYakitTipi.Size = new Size(182, 36);
            cmbYakitTipi.TabIndex = 15;
            // 
            // cmbSanzıman
            // 
            cmbSanzıman.FormattingEnabled = true;
            cmbSanzıman.Items.AddRange(new object[] { "Otomatik", "Manuel" });
            cmbSanzıman.Location = new Point(147, 484);
            cmbSanzıman.Name = "cmbSanzıman";
            cmbSanzıman.Size = new Size(182, 36);
            cmbSanzıman.TabIndex = 15;
            // 
            // btnAracEkle
            // 
            btnAracEkle.Location = new Point(147, 593);
            btnAracEkle.Name = "btnAracEkle";
            btnAracEkle.Size = new Size(182, 36);
            btnAracEkle.TabIndex = 16;
            btnAracEkle.Text = "Araç Ekle";
            btnAracEkle.UseVisualStyleBackColor = true;
            btnAracEkle.Click += btnAracEkle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(147, 646);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(182, 34);
            btnListele.TabIndex = 18;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(75, 941);
            button1.Name = "button1";
            button1.Size = new Size(206, 48);
            button1.TabIndex = 19;
            button1.Text = "Ana Sayfaya Dön";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FrmYoneticiAracEkle
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1924, 1055);
            Controls.Add(button1);
            Controls.Add(btnListele);
            Controls.Add(pictureBox1);
            Controls.Add(btnAracEkle);
            Controls.Add(cmbSanzıman);
            Controls.Add(cmbYakitTipi);
            Controls.Add(txtKm);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtGunlukUcret);
            Controls.Add(label4);
            Controls.Add(txtModel);
            Controls.Add(label3);
            Controls.Add(txtMarka);
            Controls.Add(label2);
            Controls.Add(txtPlaka);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmYoneticiAracEkle";
            Text = "YöneticiAracEkle";
            Load += FrmYoneticiAracEkle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtPlaka;
        private TextBox txtMarka;
        private Label label2;
        private TextBox txtModel;
        private Label label3;
        private TextBox txtGunlukUcret;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtKm;
        private Label label7;
        private ComboBox cmbYakitTipi;
        private ComboBox cmbSanzıman;
        private Button btnAracEkle;
        private PictureBox pictureBox1;
        private Button btnListele;
        private Button button1;
    }
}