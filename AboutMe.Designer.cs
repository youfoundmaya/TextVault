namespace TextVault
{
    partial class AboutMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMe));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palace Script MT", 64.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(333, 101);
            label1.TabIndex = 0;
            label1.Text = "Text Vault";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 120);
            label2.Name = "label2";
            label2.Size = new Size(933, 114);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("OCR A Extended", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(575, 208);
            label3.Name = "label3";
            label3.Size = new Size(370, 69);
            label3.TabIndex = 2;
            label3.Text = "Developed by Mrunmayee Ovhal\r\nSYCS(Honours) 58\r\n.net technologies practical 06\r\n";
            label3.TextAlign = ContentAlignment.BottomRight;
            // 
            // AboutMe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 286);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AboutMe";
            Text = "AboutMe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
    }
}