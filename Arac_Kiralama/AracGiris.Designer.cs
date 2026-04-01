namespace Arac_Kiralama
{
    partial class arcflo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arcflo));
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(517, 625);
            label1.Name = "label1";
            label1.Size = new Size(571, 39);
            label1.TabIndex = 0;
            label1.Text = "Araç Flomüz Hizmetinize Hazır";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(575, 681);
            button1.Name = "button1";
            button1.Size = new Size(421, 39);
            button1.TabIndex = 1;
            button1.Text = "Araçları Görüntülemek İçin Tıklayınız.";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 48F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(0, 9);
            label2.Name = "label2";
            label2.Size = new Size(1536, 91);
            label2.TabIndex = 2;
            label2.Text = "Ruhunuzu Yansıtan Araçlara Hoşgeldiniz";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(575, 723);
            button2.Name = "button2";
            button2.Size = new Size(421, 39);
            button2.TabIndex = 3;
            button2.Text = "Ana Menüye Dönmek İçin Tıklayınız.";
            button2.UseVisualStyleBackColor = false;
            // 
            // arcflo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1548, 774);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "arcflo";
            Text = "arcflo";
            TransparencyKey = Color.White;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
    }
}