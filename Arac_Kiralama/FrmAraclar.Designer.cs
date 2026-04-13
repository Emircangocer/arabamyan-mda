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
            flpAraclar = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpAraclar
            // 
            flpAraclar.Dock = DockStyle.Fill;
            flpAraclar.Location = new Point(0, 0);
            flpAraclar.Name = "flpAraclar";
            flpAraclar.Size = new Size(1836, 828);
            flpAraclar.TabIndex = 0;
            // 
            // FrmAraclar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1836, 828);
            Controls.Add(flpAraclar);
            Name = "FrmAraclar";
            Text = "FrmAraclar";
            Load += FrmAraclar_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpAraclar;
    }
}