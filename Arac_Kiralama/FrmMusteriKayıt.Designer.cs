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
            btnDevamEt = new Button();
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
            // btnDevamEt
            // 
            btnDevamEt.BackColor = Color.Wheat;
            btnDevamEt.Location = new Point(26, 476);
            btnDevamEt.Name = "btnDevamEt";
            btnDevamEt.Size = new Size(408, 41);
            btnDevamEt.TabIndex = 9;
            btnDevamEt.Text = "Devam Et";
            btnDevamEt.UseVisualStyleBackColor = false;
            btnDevamEt.Click += btnDevamEt_Click;
            // 
            // FrmMusteriKayıt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(481, 529);
            Controls.Add(btnDevamEt);
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
        private Button btnDevamEt;
    }
}