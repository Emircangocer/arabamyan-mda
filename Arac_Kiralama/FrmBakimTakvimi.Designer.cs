namespace Arac_Kiralama
{
    partial class FrmBakimTakvimi
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
            dgvTumAraclar = new DataGridView();
            txtBakimAciklama = new TextBox();
            txtBakimMaliyet = new TextBox();
            textBox3 = new TextBox();
            btnBakimiTamamla = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvTumAraclar).BeginInit();
            SuspendLayout();
            // 
            // dgvTumAraclar
            // 
            dgvTumAraclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTumAraclar.Location = new Point(12, 22);
            dgvTumAraclar.Name = "dgvTumAraclar";
            dgvTumAraclar.RowHeadersWidth = 51;
            dgvTumAraclar.Size = new Size(1064, 496);
            dgvTumAraclar.TabIndex = 0;
            dgvTumAraclar.CellClick += dgvTumAraclar_CellClick;
            // 
            // txtBakimAciklama
            // 
            txtBakimAciklama.Location = new Point(1210, 114);
            txtBakimAciklama.Name = "txtBakimAciklama";
            txtBakimAciklama.Size = new Size(193, 31);
            txtBakimAciklama.TabIndex = 1;
            // 
            // txtBakimMaliyet
            // 
            txtBakimMaliyet.Location = new Point(1210, 182);
            txtBakimMaliyet.Name = "txtBakimMaliyet";
            txtBakimMaliyet.Size = new Size(193, 31);
            txtBakimMaliyet.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1210, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 31);
            textBox3.TabIndex = 2;
            // 
            // btnBakimiTamamla
            // 
            btnBakimiTamamla.Location = new Point(1210, 344);
            btnBakimiTamamla.Name = "btnBakimiTamamla";
            btnBakimiTamamla.Size = new Size(193, 38);
            btnBakimiTamamla.TabIndex = 3;
            btnBakimiTamamla.Text = "Bakımı Tamamla";
            btnBakimiTamamla.UseVisualStyleBackColor = true;
            btnBakimiTamamla.Click += btnBakimiTamamla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1117, 120);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 4;
            label1.Text = "Açıklama:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1074, 182);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 5;
            label2.Text = "Bakım Maliyeti:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1082, 259);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 6;
            label3.Text = "Açıklama:";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(12, 789);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(213, 66);
            guna2Button1.TabIndex = 7;
            guna2Button1.Text = "Geri Dön";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // FrmBakimTakvimi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1832, 909);
            Controls.Add(guna2Button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBakimiTamamla);
            Controls.Add(textBox3);
            Controls.Add(txtBakimMaliyet);
            Controls.Add(txtBakimAciklama);
            Controls.Add(dgvTumAraclar);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmBakimTakvimi";
            Text = "FrmBakimTakvimi";
            Load += FrmBakimTakvimi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTumAraclar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTumAraclar;
        private TextBox txtBakimAciklama;
        private TextBox txtBakimMaliyet;
        private TextBox textBox3;
        private Button btnBakimiTamamla;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}