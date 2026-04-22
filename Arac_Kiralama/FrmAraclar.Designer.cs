namespace Arac_Kiralama
{
    partial class FrmAraclar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAraclar));
            flpAraclar = new FlowLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            cmbYakit = new ComboBox();
            btnFiltrele = new Button();
            cmbVites = new ComboBox();
            btnGeriDon = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flpAraclar
            // 
            flpAraclar.Location = new Point(0, 73);
            flpAraclar.Name = "flpAraclar";
            flpAraclar.Size = new Size(1837, 755);
            flpAraclar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbYakit);
            panel1.Controls.Add(btnFiltrele);
            panel1.Controls.Add(cmbVites);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1825, 75);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 2);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Yakıt Tipi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 2);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "Vites Tipi";
            // 
            // cmbYakit
            // 
            cmbYakit.FormattingEnabled = true;
            cmbYakit.Items.AddRange(new object[] { "Tümü", "Benzin", "Benzin/LPG", "Dizel", "Elektrik" });
            cmbYakit.Location = new Point(236, 24);
            cmbYakit.Name = "cmbYakit";
            cmbYakit.Size = new Size(116, 28);
            cmbYakit.TabIndex = 2;
            // 
            // btnFiltrele
            // 
            btnFiltrele.Location = new Point(390, 23);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(94, 29);
            btnFiltrele.TabIndex = 1;
            btnFiltrele.Text = "Filtrele";
            btnFiltrele.UseVisualStyleBackColor = true;
            btnFiltrele.Click += btnFiltrele_Click;
            // 
            // cmbVites
            // 
            cmbVites.FormattingEnabled = true;
            cmbVites.Items.AddRange(new object[] { "Tümü", "Otomatik", "Manuel" });
            cmbVites.Location = new Point(83, 25);
            cmbVites.Name = "cmbVites";
            cmbVites.Size = new Size(116, 28);
            cmbVites.TabIndex = 0;
            // 
            // btnGeriDon
            // 
            btnGeriDon.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGeriDon.Location = new Point(0, 898);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(225, 41);
            btnGeriDon.TabIndex = 2;
            btnGeriDon.Text = "Geri Dön";
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // FrmAraclar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1836, 1016);
            Controls.Add(btnGeriDon);
            Controls.Add(panel1);
            Controls.Add(flpAraclar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAraclar";
            Text = "Araçlar";
            Load += FrmAraclar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpAraclar;
        private Panel panel1;
        private ComboBox cmbVites;
        private Button btnFiltrele;
        private ComboBox cmbYakit;
        private Label label2;
        private Label label1;
        private Button btnGeriDon;
    }
}