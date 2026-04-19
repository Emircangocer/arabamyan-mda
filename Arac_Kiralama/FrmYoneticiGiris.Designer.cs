namespace Arac_Kiralama
{
    partial class FrmYoneticiGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYoneticiGiris));
            pictureBox1 = new PictureBox();
            btnGirisYap = new Button();
            mskTC = new MaskedTextBox();
            txtSifre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 13);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(439, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(272, 326);
            btnGirisYap.Margin = new Padding(5);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(129, 41);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // mskTC
            // 
            mskTC.Location = new Point(190, 220);
            mskTC.Margin = new Padding(5);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(211, 38);
            mskTC.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(190, 278);
            txtSifre.Margin = new Padding(5);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(211, 38);
            txtSifre.TabIndex = 2;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 282);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 31);
            label2.TabIndex = 6;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 224);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 31);
            label1.TabIndex = 7;
            label1.Text = "TC Kimlik No:";
            // 
            // FrmYoneticiGiris
            // 
            AcceptButton = btnGirisYap;
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(497, 460);
            Controls.Add(pictureBox1);
            Controls.Add(btnGirisYap);
            Controls.Add(mskTC);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            Name = "FrmYoneticiGiris";
            Text = "FrmYoneticiGiris";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnGirisYap;
        private MaskedTextBox mskTC;
        private TextBox txtSifre;
        private Label label2;
        private Label label1;
    }
}