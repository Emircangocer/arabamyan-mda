namespace Arac_Kiralama
{
    partial class FrmYoneticiPanel_Musteriler
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
            dgvMusteriler = new DataGridView();
            label1 = new Label();
            txtMusteriAra = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            SuspendLayout();
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMusteriler.BackgroundColor = SystemColors.ActiveCaption;
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Location = new Point(12, 138);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.Size = new Size(1825, 554);
            dgvMusteriler.TabIndex = 0;
            dgvMusteriler.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(514, 36);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 1;
            label1.Text = "Müşteri ara:";
            // 
            // txtMusteriAra
            // 
            txtMusteriAra.Location = new Point(634, 36);
            txtMusteriAra.Name = "txtMusteriAra";
            txtMusteriAra.Size = new Size(197, 34);
            txtMusteriAra.TabIndex = 2;
            txtMusteriAra.TextChanged += txtMusteriAra_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(84, 731);
            button1.Name = "button1";
            button1.Size = new Size(195, 49);
            button1.TabIndex = 3;
            button1.Text = "Geri Gön";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmYoneticiPanel_Musteriler
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1836, 840);
            Controls.Add(button1);
            Controls.Add(txtMusteriAra);
            Controls.Add(label1);
            Controls.Add(dgvMusteriler);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmYoneticiPanel_Musteriler";
            ShowInTaskbar = false;
            Text = "FrmYoneticiPanel_Musteriler";
            Load += FrmYoneticiPanel_Musteriler_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMusteriler;
        private Label label1;
        private TextBox txtMusteriAra;
        private Button button1;
    }
}