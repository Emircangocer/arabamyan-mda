namespace Arac_Kiralama
{
    partial class FrmYoneticiPanel_Rezervasyonlar
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
            dgvTumRezervasyonlar = new DataGridView();
            label1 = new Label();
            cmbFiltre = new ComboBox();
            btnGeriDon = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvTumRezervasyonlar).BeginInit();
            SuspendLayout();
            // 
            // dgvTumRezervasyonlar
            // 
            dgvTumRezervasyonlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTumRezervasyonlar.Location = new Point(12, 154);
            dgvTumRezervasyonlar.Name = "dgvTumRezervasyonlar";
            dgvTumRezervasyonlar.RowHeadersWidth = 51;
            dgvTumRezervasyonlar.Size = new Size(1831, 693);
            dgvTumRezervasyonlar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(562, 71);
            label1.Name = "label1";
            label1.Size = new Size(193, 25);
            label1.TabIndex = 1;
            label1.Text = "Rezervasyonları Filtrele:";
            // 
            // cmbFiltre
            // 
            cmbFiltre.FormattingEnabled = true;
            cmbFiltre.Items.AddRange(new object[] { "Hepsi", "Aktif / Depozito Alındı", "Tamamlandı" });
            cmbFiltre.Location = new Point(761, 71);
            cmbFiltre.Name = "cmbFiltre";
            cmbFiltre.Size = new Size(151, 28);
            cmbFiltre.TabIndex = 2;
            cmbFiltre.SelectedIndexChanged += cmbFiltre_SelectedIndexChanged;
            // 
            // btnGeriDon
            // 
            btnGeriDon.CustomizableEdges = customizableEdges1;
            btnGeriDon.DisabledState.BorderColor = Color.DarkGray;
            btnGeriDon.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGeriDon.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGeriDon.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGeriDon.FillColor = Color.GhostWhite;
            btnGeriDon.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGeriDon.ForeColor = Color.Black;
            btnGeriDon.Location = new Point(12, 938);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnGeriDon.Size = new Size(225, 56);
            btnGeriDon.TabIndex = 3;
            btnGeriDon.Text = "Geri Dön";
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // FrmYoneticiPanel_Rezervasyonlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnGeriDon);
            Controls.Add(cmbFiltre);
            Controls.Add(label1);
            Controls.Add(dgvTumRezervasyonlar);
            Name = "FrmYoneticiPanel_Rezervasyonlar";
            ShowInTaskbar = false;
            Text = "FrmYoneticiPanel_Rezervasyonlar";
            Load += FrmYoneticiPanel_Rezervasyonlar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTumRezervasyonlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTumRezervasyonlar;
        private Label label1;
        private ComboBox cmbFiltre;
        private Guna.UI2.WinForms.Guna2Button btnGeriDon;
    }
}