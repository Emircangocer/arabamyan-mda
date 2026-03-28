namespace Arac_Kiralama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(guna2DateTimePicker1);
            panel2.Location = new Point(12, 773);
            panel2.Name = "panel2";
            panel2.Size = new Size(1573, 175);
            panel2.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(61, 67);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(176, 39);
            comboBox2.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "8.00", "8.30", "9.00", "9.30", "10.00" });
            comboBox1.Location = new Point(501, 67);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(105, 39);
            comboBox1.TabIndex = 5;
            // 
            // guna2DateTimePicker1
            // 
            guna2DateTimePicker1.BackColor = Color.Transparent;
            guna2DateTimePicker1.Checked = true;
            guna2DateTimePicker1.CustomizableEdges = customizableEdges1;
            guna2DateTimePicker1.FillColor = Color.White;
            guna2DateTimePicker1.Font = new Font("Segoe UI", 9F);
            guna2DateTimePicker1.Format = DateTimePickerFormat.Long;
            guna2DateTimePicker1.Location = new Point(259, 67);
            guna2DateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            guna2DateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2DateTimePicker1.Size = new Size(214, 36);
            guna2DateTimePicker1.TabIndex = 3;
            guna2DateTimePicker1.Value = new DateTime(2026, 3, 26, 14, 12, 8, 57);
            guna2DateTimePicker1.ValueChanged += guna2DateTimePicker1_ValueChanged;
            // 
            // button5
            // 
            button5.BackColor = Color.Cyan;
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(1057, 75);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(157, 53);
            button5.TabIndex = 13;
            button5.Text = "Ofisler";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Cyan;
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(892, 75);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(157, 53);
            button4.TabIndex = 12;
            button4.Text = "Araçlar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Cyan;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(643, 75);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(241, 53);
            button3.TabIndex = 11;
            button3.Text = "Kiralama Koşulları";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(1222, 75);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(157, 53);
            button1.TabIndex = 9;
            button1.Text = "Müşteri Giriş";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.Location = new Point(1387, 75);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(157, 53);
            button2.TabIndex = 10;
            button2.Text = "Yönetici Giriş";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1634, 960);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox comboBox2;
    }
}
