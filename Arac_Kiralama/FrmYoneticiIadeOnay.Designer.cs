namespace Arac_Kiralama
{
    partial class FrmYoneticiIadeOnay
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
            label1 = new Label();
            txtDonusKm = new TextBox();
            label2 = new Label();
            txtKalanYakit = new TextBox();
            label3 = new Label();
            cmbHasarDurumu = new ComboBox();
            btnIadeOnayla = new Button();
            dgvRezervasyonlar = new DataGridView();
            txtHasarAciklama = new TextBox();
            label4 = new Label();
            txtHasarMaliyeti = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRezervasyonlar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 124);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
            label1.TabIndex = 0;
            label1.Text = "Km:";
            // 
            // txtDonusKm
            // 
            txtDonusKm.Location = new Point(189, 124);
            txtDonusKm.Name = "txtDonusKm";
            txtDonusKm.Size = new Size(151, 31);
            txtDonusKm.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 186);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 2;
            label2.Text = "Kalan Yakıt Miktarı:";
            // 
            // txtKalanYakit
            // 
            txtKalanYakit.Location = new Point(189, 186);
            txtKalanYakit.Name = "txtKalanYakit";
            txtKalanYakit.Size = new Size(151, 31);
            txtKalanYakit.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 257);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 4;
            label3.Text = "Hasar Durumu:";
            // 
            // cmbHasarDurumu
            // 
            cmbHasarDurumu.FormattingEnabled = true;
            cmbHasarDurumu.Items.AddRange(new object[] { "Hasarsız", "Hafif Çizik/Göçük", "Orta Hasar", "Ağır Hasar" });
            cmbHasarDurumu.Location = new Point(189, 254);
            cmbHasarDurumu.Name = "cmbHasarDurumu";
            cmbHasarDurumu.Size = new Size(151, 33);
            cmbHasarDurumu.TabIndex = 5;
            // 
            // btnIadeOnayla
            // 
            btnIadeOnayla.Location = new Point(189, 409);
            btnIadeOnayla.Name = "btnIadeOnayla";
            btnIadeOnayla.Size = new Size(151, 29);
            btnIadeOnayla.TabIndex = 6;
            btnIadeOnayla.Text = "İade Onayla";
            btnIadeOnayla.UseVisualStyleBackColor = true;
            btnIadeOnayla.Click += btnIadeOnayla_Click;
            // 
            // dgvRezervasyonlar
            // 
            dgvRezervasyonlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRezervasyonlar.Location = new Point(469, 52);
            dgvRezervasyonlar.Name = "dgvRezervasyonlar";
            dgvRezervasyonlar.RowHeadersWidth = 51;
            dgvRezervasyonlar.Size = new Size(1227, 615);
            dgvRezervasyonlar.TabIndex = 7;
            dgvRezervasyonlar.CellClick += dgvRezervasyonlar_CellClick;
            dgvRezervasyonlar.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtHasarAciklama
            // 
            txtHasarAciklama.Location = new Point(189, 311);
            txtHasarAciklama.Name = "txtHasarAciklama";
            txtHasarAciklama.Size = new Size(151, 31);
            txtHasarAciklama.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 311);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 8;
            label4.Text = "Hasar Açıklama:";
            // 
            // txtHasarMaliyeti
            // 
            txtHasarMaliyeti.Location = new Point(189, 355);
            txtHasarMaliyeti.Name = "txtHasarMaliyeti";
            txtHasarMaliyeti.Size = new Size(151, 31);
            txtHasarMaliyeti.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 355);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 10;
            label5.Text = "Hasar Maliyeti:";
            // 
            // FrmYoneticiIadeOnay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 770);
            Controls.Add(txtHasarMaliyeti);
            Controls.Add(label5);
            Controls.Add(txtHasarAciklama);
            Controls.Add(label4);
            Controls.Add(dgvRezervasyonlar);
            Controls.Add(btnIadeOnayla);
            Controls.Add(cmbHasarDurumu);
            Controls.Add(label3);
            Controls.Add(txtKalanYakit);
            Controls.Add(label2);
            Controls.Add(txtDonusKm);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmYoneticiIadeOnay";
            Text = "FrmYoneticiIadeOnay";
            Load += FrmYoneticiIadeOnay_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRezervasyonlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDonusKm;
        private Label label2;
        private TextBox txtKalanYakit;
        private Label label3;
        private ComboBox cmbHasarDurumu;
        private Button btnIadeOnayla;
        private DataGridView dgvRezervasyonlar;
        private TextBox txtHasarAciklama;
        private Label label4;
        private TextBox txtHasarMaliyeti;
        private Label label5;
    }
}