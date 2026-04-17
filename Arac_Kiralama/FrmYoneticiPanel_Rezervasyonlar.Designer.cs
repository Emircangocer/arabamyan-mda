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
            dgvTumRezervasyonlar = new DataGridView();
            label1 = new Label();
            cmbFiltre = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvTumRezervasyonlar).BeginInit();
            SuspendLayout();
            // 
            // dgvTumRezervasyonlar
            // 
            dgvTumRezervasyonlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTumRezervasyonlar.Location = new Point(12, 214);
            dgvTumRezervasyonlar.Name = "dgvTumRezervasyonlar";
            dgvTumRezervasyonlar.RowHeadersWidth = 51;
            dgvTumRezervasyonlar.Size = new Size(1831, 693);
            dgvTumRezervasyonlar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(379, 87);
            label1.Name = "label1";
            label1.Size = new Size(193, 25);
            label1.TabIndex = 1;
            label1.Text = "Rezervasyonları Filtrele:";
            // 
            // cmbFiltre
            // 
            cmbFiltre.FormattingEnabled = true;
            cmbFiltre.Items.AddRange(new object[] { "Hepsi", "Aktif / Depozito Alındı", "Tamamlandı" });
            cmbFiltre.Location = new Point(578, 87);
            cmbFiltre.Name = "cmbFiltre";
            cmbFiltre.Size = new Size(151, 28);
            cmbFiltre.TabIndex = 2;
            cmbFiltre.SelectedIndexChanged += cmbFiltre_SelectedIndexChanged;
            // 
            // FrmYoneticiPanel_Rezervasyonlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1924, 1055);
            Controls.Add(cmbFiltre);
            Controls.Add(label1);
            Controls.Add(dgvTumRezervasyonlar);
            Name = "FrmYoneticiPanel_Rezervasyonlar";
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
    }
}