namespace WinFormsApp1
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
            Lb1 = new Label();
            Lb2 = new Label();
            bttAdivinhe = new Button();
            SuspendLayout();
            // 
            // Lb1
            // 
            Lb1.AutoSize = true;
            Lb1.Location = new Point(113, 140);
            Lb1.Name = "Lb1";
            Lb1.Size = new Size(157, 32);
            Lb1.TabIndex = 0;
            Lb1.Text = "O Meu Clube";
            Lb1.Click += label1_Click;
            // 
            // Lb2
            // 
            Lb2.AutoSize = true;
            Lb2.Location = new Point(379, 140);
            Lb2.Name = "Lb2";
            Lb2.Size = new Size(25, 32);
            Lb2.TabIndex = 1;
            Lb2.Text = "?";
            // 
            // bttAdivinhe
            // 
            bttAdivinhe.FlatStyle = FlatStyle.Popup;
            bttAdivinhe.Location = new Point(254, 274);
            bttAdivinhe.Name = "bttAdivinhe";
            bttAdivinhe.Size = new Size(150, 46);
            bttAdivinhe.TabIndex = 2;
            bttAdivinhe.Text = "Advinhe";
            bttAdivinhe.UseVisualStyleBackColor = true;
            bttAdivinhe.Click += bttAdivinhe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttAdivinhe);
            Controls.Add(Lb2);
            Controls.Add(Lb1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lb1;
        private Label Lb2;
        private Button bttAdivinhe;
    }
}
