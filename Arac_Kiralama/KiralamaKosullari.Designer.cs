namespace Arac_Kiralama
{
    partial class KiralamaKosullari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiralamaKosullari));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Location = new Point(38, 188);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(650, 70);
            button1.TabIndex = 0;
            button1.Text = "Kullanıcı Bilgisi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Location = new Point(38, 266);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(650, 70);
            button2.TabIndex = 1;
            button2.Text = "Yaş ve Ehliyet Yılı Koşulları";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Location = new Point(38, 344);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(650, 70);
            button3.TabIndex = 2;
            button3.Text = "Yakıt";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Location = new Point(38, 422);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(650, 70);
            button4.TabIndex = 3;
            button4.Text = "Araç Teslimi";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.Location = new Point(38, 500);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(650, 70);
            button5.TabIndex = 4;
            button5.Text = "Trafik Cezaları";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Crimson;
            button6.Location = new Point(38, 578);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(650, 70);
            button6.TabIndex = 5;
            button6.Text = "Araç Grupları Kilometre Sınırları";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(705, 50);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1207, 763);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // KiralamaKosullari
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1924, 1055);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "KiralamaKosullari";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
    }
}