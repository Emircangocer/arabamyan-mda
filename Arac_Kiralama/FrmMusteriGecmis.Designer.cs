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
            dgvGecmis = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).BeginInit();
            SuspendLayout();
            // 
            // dgvGecmis
            // 
            dgvGecmis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGecmis.Location = new Point(0, 100);
            dgvGecmis.Name = "dgvGecmis";
            dgvGecmis.RowHeadersWidth = 51;
            dgvGecmis.Size = new Size(1595, 482);
            dgvGecmis.TabIndex = 0;
            // 
            // FrmMusteriGecmis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 692);
            Controls.Add(dgvGecmis);
            Name = "FrmMusteriGecmis";
            Text = "FrmMusteriGecmis";
            Load += FrmMusteriGecmis_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGecmis;
    }
}