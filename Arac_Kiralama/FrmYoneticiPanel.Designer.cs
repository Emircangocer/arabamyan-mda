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
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            btnMusteri = new Button();
            button2 = new Button();
            button1 = new Button();
            dgvRezervasyonlar = new DataGridView();
            btnIadeAl = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRezervasyonlar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnMusteri);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 1055);
            panel1.TabIndex = 0;
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
            // 
            // button1
            // 
            button1.Location = new Point(3, 235);
            button1.Name = "button1";
            button1.Size = new Size(189, 37);
            button1.TabIndex = 1;
            button1.Text = "🏠 Ana Sayfa";
            button1.TextAlign = ContentAlignment.TopLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvRezervasyonlar
            // 
            dgvRezervasyonlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRezervasyonlar.Location = new Point(275, 141);
            dgvRezervasyonlar.Name = "dgvRezervasyonlar";
            dgvRezervasyonlar.RowHeadersWidth = 51;
            dgvRezervasyonlar.Size = new Size(861, 469);
            dgvRezervasyonlar.TabIndex = 1;
            dgvRezervasyonlar.CellClick += dgvRezervasyonlar_CellClick;
            dgvRezervasyonlar.CellContentClick += dgvRezervasyonlar_CellContentClick;
            // 
            // btnIadeAl
            // 
            btnIadeAl.Location = new Point(635, 616);
            btnIadeAl.Name = "btnIadeAl";
            btnIadeAl.Size = new Size(156, 38);
            btnIadeAl.TabIndex = 2;
            btnIadeAl.Text = "Aracı İade Al";
            btnIadeAl.UseVisualStyleBackColor = true;
            // 
            // FrmYoneticiPanel
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1895, 1055);
            Controls.Add(btnIadeAl);
            Controls.Add(dgvRezervasyonlar);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmYoneticiPanel";
            Text = "FrmYoneticiPanel";
            Load += FrmYoneticiPanel_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRezervasyonlar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button btnMusteri;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button button7;
        private Button button6;
        private DataGridView dgvRezervasyonlar;
        private Button btnIadeAl;
    }
}