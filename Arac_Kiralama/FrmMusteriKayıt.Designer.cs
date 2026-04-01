namespace Arac_Kiralama
{
    partial class FrmMusteriKayıt
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtad = new TextBox();
            txtSoyad = new TextBox();
            mskTC = new MaskedTextBox();
            mskTelefon = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            txtSifre = new TextBox();
            label7 = new Label();
            cmbEhliyetSınıfı = new ComboBox();
            btnÜyeOl = new Button();
            dateTimePicker2 = new DateTimePicker();
            txtEhliyetYer = new TextBox();
            txtEhliyetNo = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 106);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 0;
            label2.Text = "Ad *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 104);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 0;
            label3.Text = "Soyad *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 179);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 0;
            label4.Text = "TC Kimlik *";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 249);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 0;
            label5.Text = "Telefon No *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 325);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(131, 25);
            label6.TabIndex = 0;
            label6.Text = "Doğum Tarihi *";
            // 
            // txtad
            // 
            txtad.Location = new Point(26, 134);
            txtad.Name = "txtad";
            txtad.Size = new Size(190, 31);
            txtad.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(244, 134);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(190, 31);
            txtSoyad.TabIndex = 1;
            // 
            // mskTC
            // 
            mskTC.Location = new Point(26, 207);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(408, 31);
            mskTC.TabIndex = 2;
            // 
            // mskTelefon
            // 
            mskTelefon.Location = new Point(26, 277);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(408, 31);
            mskTelefon.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(26, 353);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(408, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 401);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 5;
            label1.Text = "Şifre *";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(26, 429);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(408, 31);
            txtSifre.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 19);
            label7.Name = "label7";
            label7.Size = new Size(290, 50);
            label7.TabIndex = 7;
            label7.Text = "arabamyanımda ile Rahat ve Hızlı\r\n Araç Kiralamak İçin Hemen Üye Ol!\r\n";
            // 
            // cmbEhliyetSınıfı
            // 
            cmbEhliyetSınıfı.FormattingEnabled = true;
            cmbEhliyetSınıfı.Location = new Point(559, 278);
            cmbEhliyetSınıfı.Name = "cmbEhliyetSınıfı";
            cmbEhliyetSınıfı.Size = new Size(341, 33);
            cmbEhliyetSınıfı.TabIndex = 34;
            // 
            // btnÜyeOl
            // 
            btnÜyeOl.BackColor = Color.Wheat;
            btnÜyeOl.Location = new Point(319, 499);
            btnÜyeOl.Name = "btnÜyeOl";
            btnÜyeOl.Size = new Size(341, 41);
            btnÜyeOl.TabIndex = 33;
            btnÜyeOl.Text = "Üyeliği Tamamla";
            btnÜyeOl.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(559, 352);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(341, 31);
            dateTimePicker2.TabIndex = 31;
            // 
            // txtEhliyetYer
            // 
            txtEhliyetYer.Location = new Point(559, 207);
            txtEhliyetYer.Name = "txtEhliyetYer";
            txtEhliyetYer.Size = new Size(341, 31);
            txtEhliyetYer.TabIndex = 29;
            // 
            // txtEhliyetNo
            // 
            txtEhliyetNo.Location = new Point(559, 133);
            txtEhliyetNo.Name = "txtEhliyetNo";
            txtEhliyetNo.Size = new Size(341, 31);
            txtEhliyetNo.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(559, 324);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(167, 25);
            label9.TabIndex = 25;
            label9.Text = "Ehliyet Alma Tarihi *";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(559, 250);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(119, 25);
            label10.TabIndex = 26;
            label10.Text = "Ehliyet Sınıfı *";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(559, 177);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(104, 25);
            label11.TabIndex = 27;
            label11.Text = "Ehliyet Yer *";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(559, 105);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(105, 25);
            label12.TabIndex = 28;
            label12.Text = "Ehliyet No *";
            // 
            // FrmMusteriKayıt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1025, 702);
            Controls.Add(cmbEhliyetSınıfı);
            Controls.Add(btnÜyeOl);
            Controls.Add(dateTimePicker2);
            Controls.Add(txtEhliyetYer);
            Controls.Add(txtEhliyetNo);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(txtSifre);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(mskTelefon);
            Controls.Add(mskTC);
            Controls.Add(txtSoyad);
            Controls.Add(txtad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmMusteriKayıt";
            Text = "Müşteri Kayıt";
            Load += FrmMusteriKayıt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtad;
        private TextBox txtSoyad;
        private MaskedTextBox mskTC;
        private MaskedTextBox mskTelefon;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox txtSifre;
        private Label label7;
        private ComboBox cmbEhliyetSınıfı;
        private Button btnÜyeOl;
        private DateTimePicker dateTimePicker2;
        private TextBox txtEhliyetYer;
        private TextBox txtEhliyetNo;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}