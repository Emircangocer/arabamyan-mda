namespace Arac_Kiralama
{
    partial class FrmMusteriKayit2
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
            btnÜyeOl = new Button();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtEhliyetYer = new TextBox();
            txtEhliyetNo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbEhliyetSınıfı = new ComboBox();
            SuspendLayout();
            // 
            // btnÜyeOl
            // 
            btnÜyeOl.BackColor = Color.Wheat;
            btnÜyeOl.Location = new Point(65, 425);
            btnÜyeOl.Name = "btnÜyeOl";
            btnÜyeOl.Size = new Size(341, 41);
            btnÜyeOl.TabIndex = 23;
            btnÜyeOl.Text = "Üyeliği Tamamla";
            btnÜyeOl.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(65, 23);
            label7.Name = "label7";
            label7.Size = new Size(335, 38);
            label7.TabIndex = 22;
            label7.Text = "Sürücü Bilgilerinizi Girin";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(65, 361);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(341, 31);
            dateTimePicker1.TabIndex = 19;
            // 
            // txtEhliyetYer
            // 
            txtEhliyetYer.Location = new Point(65, 216);
            txtEhliyetYer.Name = "txtEhliyetYer";
            txtEhliyetYer.Size = new Size(341, 31);
            txtEhliyetYer.TabIndex = 15;
            // 
            // txtEhliyetNo
            // 
            txtEhliyetNo.Location = new Point(65, 142);
            txtEhliyetNo.Name = "txtEhliyetNo";
            txtEhliyetNo.Size = new Size(341, 31);
            txtEhliyetNo.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 333);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(167, 25);
            label5.TabIndex = 11;
            label5.Text = "Ehliyet Alma Tarihi *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 259);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 12;
            label4.Text = "Ehliyet Sınıfı *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 186);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 13;
            label3.Text = "Ehliyet Yer *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 114);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 14;
            label2.Text = "Ehliyet No *";
            // 
            // cmbEhliyetSınıfı
            // 
            cmbEhliyetSınıfı.FormattingEnabled = true;
            cmbEhliyetSınıfı.Location = new Point(65, 287);
            cmbEhliyetSınıfı.Name = "cmbEhliyetSınıfı";
            cmbEhliyetSınıfı.Size = new Size(341, 33);
            cmbEhliyetSınıfı.TabIndex = 24;
            // 
            // FrmMusteriKayit2
            // 
            AcceptButton = btnÜyeOl;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(485, 543);
            Controls.Add(cmbEhliyetSınıfı);
            Controls.Add(btnÜyeOl);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtEhliyetYer);
            Controls.Add(txtEhliyetNo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmMusteriKayit2";
            Text = "FrmMusteriKayit2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnÜyeOl;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private TextBox txtEhliyetYer;
        private TextBox txtEhliyetNo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbEhliyetSınıfı;
    }
}