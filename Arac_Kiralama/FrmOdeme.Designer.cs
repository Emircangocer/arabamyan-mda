namespace Arac_Kiralama
{
    partial class FrmOdeme
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
            lblAracAdi = new Label();
            lblYakit = new Label();
            lblVites = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblAlisTarihi = new Label();
            label8 = new Label();
            label9 = new Label();
            lblIadeTarihi = new Label();
            panel1 = new Panel();
            btnKirala = new Button();
            lblToplamTutar = new Label();
            label14 = new Label();
            lblKiralamaBedeli = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAracAdi
            // 
            lblAracAdi.AutoSize = true;
            lblAracAdi.Location = new Point(156, 74);
            lblAracAdi.Margin = new Padding(4, 0, 4, 0);
            lblAracAdi.Name = "lblAracAdi";
            lblAracAdi.Size = new Size(86, 28);
            lblAracAdi.TabIndex = 0;
            lblAracAdi.Text = "Araç Adı";
            // 
            // lblYakit
            // 
            lblYakit.AutoSize = true;
            lblYakit.Location = new Point(33, 171);
            lblYakit.Margin = new Padding(4, 0, 4, 0);
            lblYakit.Name = "lblYakit";
            lblYakit.Size = new Size(53, 28);
            lblYakit.TabIndex = 1;
            lblYakit.Text = "Yakıt";
            lblYakit.Click += label2_Click;
            // 
            // lblVites
            // 
            lblVites.AutoSize = true;
            lblVites.Location = new Point(265, 171);
            lblVites.Margin = new Padding(4, 0, 4, 0);
            lblVites.Name = "lblVites";
            lblVites.Size = new Size(54, 28);
            lblVites.TabIndex = 2;
            lblVites.Text = "Vites";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 239);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(194, 28);
            label4.TabIndex = 3;
            label4.Text = "Araç Kiralama Bedeli:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 22);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(98, 28);
            label5.TabIndex = 4;
            label5.Text = "Alış Tarihi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(299, 22);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 28);
            label6.TabIndex = 5;
            label6.Text = "İade Tarihi:";
            // 
            // lblAlisTarihi
            // 
            lblAlisTarihi.AutoSize = true;
            lblAlisTarihi.Location = new Point(119, 22);
            lblAlisTarihi.Margin = new Padding(4, 0, 4, 0);
            lblAlisTarihi.Name = "lblAlisTarihi";
            lblAlisTarihi.Size = new Size(53, 28);
            lblAlisTarihi.TabIndex = 6;
            lblAlisTarihi.Text = "Tarih";
            lblAlisTarihi.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1003, 709);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(65, 28);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(472, 747);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(65, 28);
            label9.TabIndex = 8;
            label9.Text = "label9";
            // 
            // lblIadeTarihi
            // 
            lblIadeTarihi.AutoSize = true;
            lblIadeTarihi.Location = new Point(441, 22);
            lblIadeTarihi.Margin = new Padding(4, 0, 4, 0);
            lblIadeTarihi.Name = "lblIadeTarihi";
            lblIadeTarihi.Size = new Size(53, 28);
            lblIadeTarihi.TabIndex = 9;
            lblIadeTarihi.Text = "Tarih";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnKirala);
            panel1.Controls.Add(lblToplamTutar);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(lblKiralamaBedeli);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblIadeTarihi);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblAlisTarihi);
            panel1.Controls.Add(lblVites);
            panel1.Controls.Add(lblAracAdi);
            panel1.Controls.Add(lblYakit);
            panel1.Location = new Point(425, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 516);
            panel1.TabIndex = 10;
            // 
            // btnKirala
            // 
            btnKirala.Location = new Point(119, 404);
            btnKirala.Name = "btnKirala";
            btnKirala.Size = new Size(200, 35);
            btnKirala.TabIndex = 15;
            btnKirala.Text = "Ödemeyi Tamamla";
            btnKirala.UseVisualStyleBackColor = true;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Location = new Point(170, 340);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(76, 28);
            lblToplamTutar.TabIndex = 14;
            lblToplamTutar.Text = "label15";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(33, 340);
            label14.Name = "label14";
            label14.Size = new Size(130, 28);
            label14.TabIndex = 13;
            label14.Text = "Toplam Tutar:";
            // 
            // lblKiralamaBedeli
            // 
            lblKiralamaBedeli.AutoSize = true;
            lblKiralamaBedeli.Location = new Point(233, 239);
            lblKiralamaBedeli.Name = "lblKiralamaBedeli";
            lblKiralamaBedeli.Size = new Size(76, 28);
            lblKiralamaBedeli.TabIndex = 10;
            lblKiralamaBedeli.Text = "label11";
            // 
            // FrmOdeme
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(label8);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmOdeme";
            Text = "FrmOdeme";
            Load += FrmOdeme_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAracAdi;
        private Label lblYakit;
        private Label lblVites;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblAlisTarihi;
        private Label label8;
        private Label label9;
        private Label lblIadeTarihi;
        private Panel panel1;
        private Label lblToplamTutar;
        private Label label14;
        private Label lblKiralamaBedeli;
        private Button btnKirala;
    }
}