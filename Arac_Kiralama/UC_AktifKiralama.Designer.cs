namespace Arac_Kiralama
{
    partial class UC_AktifKiralama
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
            pbAracResim = new PictureBox();
            lblPlakaModel = new Label();
            lblKalanSure = new Label();
            btnIadeTalebi = new Button();
            ((System.ComponentModel.ISupportInitialize)pbAracResim).BeginInit();
            SuspendLayout();
            // 
            // pbAracResim
            // 
            pbAracResim.Location = new Point(28, 28);
            pbAracResim.Margin = new Padding(4);
            pbAracResim.Name = "pbAracResim";
            pbAracResim.Size = new Size(219, 106);
            pbAracResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAracResim.TabIndex = 0;
            pbAracResim.TabStop = false;
            // 
            // lblPlakaModel
            // 
            lblPlakaModel.AutoSize = true;
            lblPlakaModel.Location = new Point(59, 148);
            lblPlakaModel.Name = "lblPlakaModel";
            lblPlakaModel.Size = new Size(59, 25);
            lblPlakaModel.TabIndex = 1;
            lblPlakaModel.Text = "label1";
            // 
            // lblKalanSure
            // 
            lblKalanSure.AutoSize = true;
            lblKalanSure.Location = new Point(59, 190);
            lblKalanSure.Name = "lblKalanSure";
            lblKalanSure.Size = new Size(59, 25);
            lblKalanSure.TabIndex = 2;
            lblKalanSure.Text = "label1";
            // 
            // btnIadeTalebi
            // 
            btnIadeTalebi.Location = new Point(52, 239);
            btnIadeTalebi.Name = "btnIadeTalebi";
            btnIadeTalebi.Size = new Size(163, 38);
            btnIadeTalebi.TabIndex = 3;
            btnIadeTalebi.Text = "İade Et";
            btnIadeTalebi.UseVisualStyleBackColor = true;
            btnIadeTalebi.Click += btnIadeTalebi_Click;
            // 
            // UC_AktifKiralama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnIadeTalebi);
            Controls.Add(lblKalanSure);
            Controls.Add(lblPlakaModel);
            Controls.Add(pbAracResim);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "UC_AktifKiralama";
            Size = new Size(282, 311);
            Load += UC_AktifKiralama_Load;
            ((System.ComponentModel.ISupportInitialize)pbAracResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbAracResim;
        private Label lblPlakaModel;
        private Label lblKalanSure;
        private Button btnIadeTalebi;
    }
}
