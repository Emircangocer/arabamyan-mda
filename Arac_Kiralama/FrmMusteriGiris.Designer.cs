namespace Arac_Kiralama
{
    partial class FrmMusteriGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriGiris));
            label1 = new Label();
            label2 = new Label();
            txtSifre = new TextBox();
            mskTC = new MaskedTextBox();
            btnGirisYap = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 226);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 31);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 275);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 31);
            label2.TabIndex = 0;
            label2.Text = "Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(151, 275);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(252, 38);
            txtSifre.TabIndex = 2;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // mskTC
            // 
            mskTC.Location = new Point(151, 226);
            mskTC.Margin = new Padding(4);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(252, 38);
            mskTC.TabIndex = 1;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(151, 321);
            btnGirisYap.Margin = new Padding(4);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(168, 40);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(326, 326);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(82, 31);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Üye Ol";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.unnamed__2_;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(426, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FrmMusteriGiris
            // 
            AcceptButton = btnGirisYap;
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(449, 449);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(btnGirisYap);
            Controls.Add(mskTC);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "FrmMusteriGiris";
            Text = "Müşteri Girişi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSifre;
        private MaskedTextBox mskTC;
        private Button btnGirisYap;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}