namespace Arac_Kiralama
{
    partial class UC_AracKart
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AracKart));
            picArac = new PictureBox();
            lblMarkaModel = new Label();
            lblVites = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblYakit = new Label();
            lblFiyat = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)picArac).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // picArac
            // 
            picArac.BackColor = Color.Transparent;
            picArac.Location = new Point(3, 33);
            picArac.Name = "picArac";
            picArac.Size = new Size(323, 141);
            picArac.SizeMode = PictureBoxSizeMode.Zoom;
            picArac.TabIndex = 0;
            picArac.TabStop = false;
            picArac.Click += pictureBox1_Click;
            // 
            // lblMarkaModel
            // 
            lblMarkaModel.AutoSize = true;
            lblMarkaModel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMarkaModel.Location = new Point(3, 2);
            lblMarkaModel.Name = "lblMarkaModel";
            lblMarkaModel.Size = new Size(148, 28);
            lblMarkaModel.TabIndex = 1;
            lblMarkaModel.Text = "Mercedes c200";
            // 
            // lblVites
            // 
            lblVites.AutoSize = true;
            lblVites.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblVites.Location = new Point(62, 207);
            lblVites.Name = "lblVites";
            lblVites.Size = new Size(87, 25);
            lblVites.TabIndex = 2;
            lblVites.Text = "Otomatik";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 185);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(161, 185);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // lblYakit
            // 
            lblYakit.AutoSize = true;
            lblYakit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblYakit.Location = new Point(235, 207);
            lblYakit.Name = "lblYakit";
            lblYakit.Size = new Size(50, 25);
            lblYakit.TabIndex = 5;
            lblYakit.Text = "Dizel";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFiyat.Location = new Point(-1, 267);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(238, 23);
            lblFiyat.TabIndex = 6;
            lblFiyat.Text = "1857 Tl'den başlayan fiyatlarla";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(233, 248);
            button1.Name = "button1";
            button1.Size = new Size(89, 59);
            button1.TabIndex = 7;
            button1.Text = "Hemen Kirala";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UC_AracKart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(picArac);
            Controls.Add(button1);
            Controls.Add(lblFiyat);
            Controls.Add(lblYakit);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lblVites);
            Controls.Add(lblMarkaModel);
            Name = "UC_AracKart";
            Size = new Size(360, 385);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)picArac).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picArac;
        private Label lblMarkaModel;
        private Label lblVites;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblYakit;
        private Label lblFiyat;
        private Button button1;
    }
}
