namespace Arac_Kiralama
{
    partial class FrmMusteriGecmis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriGecmis));
            dgvGecmis = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).BeginInit();
            SuspendLayout();
            // 
            // dgvGecmis
            // 
            dgvGecmis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGecmis.Location = new Point(250, 80);
            dgvGecmis.Name = "dgvGecmis";
            dgvGecmis.RowHeadersWidth = 51;
            dgvGecmis.Size = new Size(945, 482);
            dgvGecmis.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(491, 14);
            label1.Name = "label1";
            label1.Size = new Size(413, 54);
            label1.TabIndex = 1;
            label1.Text = "Kiralama Geçmişiniz";
            // 
            // FrmMusteriGecmis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1492, 755);
            Controls.Add(label1);
            Controls.Add(dgvGecmis);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMusteriGecmis";
            Text = "Müşteri Geçmişi";
            Load += FrmMusteriGecmis_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGecmis;
        private Label label1;
    }
}