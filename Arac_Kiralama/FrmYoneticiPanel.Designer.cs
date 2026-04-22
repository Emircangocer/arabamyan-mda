namespace Arac_Kiralama
{
    partial class FrmYoneticiPanel
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel2 = new Panel();
            btnCikisYap = new Guna.UI2.WinForms.Guna2Button();
            lblYoneticiAd = new Label();
            pbYoneticiResim = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            btnMusteri = new Button();
            button2 = new Button();
            label1 = new Label();
            lblToplamKazanc = new Label();
            dgvRezervasyonlar = new DataGridView();
            lblYoldakiAraclar = new Label();
            lblMusaitAraclar = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvYaklasanBakimlar = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbYoneticiResim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRezervasyonlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvYaklasanBakimlar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnMusteri);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 1055);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(btnCikisYap);
            panel2.Controls.Add(lblYoneticiAd);
            panel2.Controls.Add(pbYoneticiResim);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 260);
            panel2.TabIndex = 12;
            // 
            // btnCikisYap
            // 
            btnCikisYap.BackColor = SystemColors.ControlLightLight;
            btnCikisYap.CustomizableEdges = customizableEdges1;
            btnCikisYap.DisabledState.BorderColor = Color.DarkGray;
            btnCikisYap.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCikisYap.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCikisYap.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCikisYap.FillColor = SystemColors.ActiveCaption;
            btnCikisYap.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnCikisYap.ForeColor = Color.Black;
            btnCikisYap.Location = new Point(12, 200);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCikisYap.Size = new Size(156, 47);
            btnCikisYap.TabIndex = 12;
            btnCikisYap.Text = "Çıkış yap";
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // lblYoneticiAd
            // 
            lblYoneticiAd.AutoSize = true;
            lblYoneticiAd.Location = new Point(12, 141);
            lblYoneticiAd.Name = "lblYoneticiAd";
            lblYoneticiAd.Size = new Size(65, 28);
            lblYoneticiAd.TabIndex = 12;
            lblYoneticiAd.Text = "label6";
            // 
            // pbYoneticiResim
            // 
            pbYoneticiResim.ImageRotate = 0F;
            pbYoneticiResim.Location = new Point(23, 3);
            pbYoneticiResim.Name = "pbYoneticiResim";
            pbYoneticiResim.ShadowDecoration.CustomizableEdges = customizableEdges3;
            pbYoneticiResim.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pbYoneticiResim.Size = new Size(145, 124);
            pbYoneticiResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbYoneticiResim.TabIndex = 12;
            pbYoneticiResim.TabStop = false;
            // 
            // button7
            // 
            button7.Location = new Point(3, 573);
            button7.Name = "button7";
            button7.Size = new Size(189, 37);
            button7.TabIndex = 7;
            button7.Text = "📊 Raporlar";
            button7.TextAlign = ContentAlignment.TopLeft;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(3, 519);
            button6.Name = "button6";
            button6.Size = new Size(189, 37);
            button6.TabIndex = 6;
            button6.Text = "🔧 Bakım Takvimi";
            button6.TextAlign = ContentAlignment.TopLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(3, 465);
            button5.Name = "button5";
            button5.Size = new Size(189, 37);
            button5.TabIndex = 5;
            button5.Text = "🔄 Teslimat - İade";
            button5.TextAlign = ContentAlignment.TopLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(3, 408);
            button4.Name = "button4";
            button4.Size = new Size(189, 37);
            button4.TabIndex = 4;
            button4.Text = "📅 Rezervasyonlar";
            button4.TextAlign = ContentAlignment.TopLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnMusteri
            // 
            btnMusteri.Location = new Point(3, 353);
            btnMusteri.Name = "btnMusteri";
            btnMusteri.Size = new Size(189, 37);
            btnMusteri.TabIndex = 3;
            btnMusteri.Text = "👥 Müşteriler";
            btnMusteri.TextAlign = ContentAlignment.TopLeft;
            btnMusteri.UseVisualStyleBackColor = true;
            btnMusteri.Click += btnMusteri_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 293);
            button2.Name = "button2";
            button2.Size = new Size(189, 37);
            button2.TabIndex = 2;
            button2.Text = "🚗 Araçlar";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1060, 600);
            label1.Name = "label1";
            label1.Size = new Size(142, 28);
            label1.TabIndex = 6;
            label1.Text = "Toplam Kazanç";
            // 
            // lblToplamKazanc
            // 
            lblToplamKazanc.AutoSize = true;
            lblToplamKazanc.Location = new Point(1085, 628);
            lblToplamKazanc.Name = "lblToplamKazanc";
            lblToplamKazanc.Size = new Size(65, 28);
            lblToplamKazanc.TabIndex = 3;
            lblToplamKazanc.Text = "label1";
            // 
            // dgvRezervasyonlar
            // 
            dgvRezervasyonlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRezervasyonlar.Location = new Point(228, 95);
            dgvRezervasyonlar.Name = "dgvRezervasyonlar";
            dgvRezervasyonlar.RowHeadersWidth = 51;
            dgvRezervasyonlar.Size = new Size(1295, 438);
            dgvRezervasyonlar.TabIndex = 1;
            dgvRezervasyonlar.CellClick += dgvRezervasyonlar_CellClick;
            dgvRezervasyonlar.CellContentClick += dgvRezervasyonlar_CellContentClick;
            // 
            // lblYoldakiAraclar
            // 
            lblYoldakiAraclar.AutoSize = true;
            lblYoldakiAraclar.Location = new Point(1060, 759);
            lblYoldakiAraclar.Name = "lblYoldakiAraclar";
            lblYoldakiAraclar.Size = new Size(65, 28);
            lblYoldakiAraclar.TabIndex = 4;
            lblYoldakiAraclar.Text = "label2";
            // 
            // lblMusaitAraclar
            // 
            lblMusaitAraclar.AutoSize = true;
            lblMusaitAraclar.Location = new Point(1072, 894);
            lblMusaitAraclar.Name = "lblMusaitAraclar";
            lblMusaitAraclar.Size = new Size(65, 28);
            lblMusaitAraclar.TabIndex = 5;
            lblMusaitAraclar.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1060, 728);
            label2.Name = "label2";
            label2.Size = new Size(181, 28);
            label2.TabIndex = 7;
            label2.Text = "Kiradaki Araç Sayısı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1072, 866);
            label3.Name = "label3";
            label3.Size = new Size(169, 28);
            label3.TabIndex = 8;
            label3.Text = "Müsait Araç Sayısı";
            // 
            // dgvYaklasanBakimlar
            // 
            dgvYaklasanBakimlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYaklasanBakimlar.Location = new Point(228, 600);
            dgvYaklasanBakimlar.Name = "dgvYaklasanBakimlar";
            dgvYaklasanBakimlar.RowHeadersWidth = 51;
            dgvYaklasanBakimlar.Size = new Size(598, 336);
            dgvYaklasanBakimlar.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(228, 559);
            label4.Name = "label4";
            label4.Size = new Size(348, 38);
            label4.TabIndex = 10;
            label4.Text = "Bakımı Yaklaşan Araçlar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(228, 45);
            label5.Name = "label5";
            label5.Size = new Size(245, 38);
            label5.TabIndex = 11;
            label5.Text = "Aktif Randevular";
            // 
            // FrmYoneticiPanel
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvYaklasanBakimlar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblMusaitAraclar);
            Controls.Add(lblToplamKazanc);
            Controls.Add(lblYoldakiAraclar);
            Controls.Add(dgvRezervasyonlar);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmYoneticiPanel";
            Text = "Yönetici Panel";
            Load += FrmYoneticiPanel_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbYoneticiResim).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRezervasyonlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvYaklasanBakimlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnMusteri;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button button7;
        private Button button6;
        private DataGridView dgvRezervasyonlar;
        private Label lblToplamKazanc;
        private Label lblYoldakiAraclar;
        private Label lblMusaitAraclar;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvYaklasanBakimlar;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnCikisYap;
        private Label lblYoneticiAd;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbYoneticiResim;
    }
}