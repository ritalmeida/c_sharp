namespace WinFormsApp4
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
            listView1 = new ListView();
            Marca = new ColumnHeader();
            Modelo = new ColumnHeader();
            Preço = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Marca, Modelo, Preço });
            listView1.Location = new Point(163, 374);
            listView1.Name = "listView1";
            listView1.Size = new Size(606, 392);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Marca
            // 
            Marca.Text = "Marca";
            Marca.Width = 200;
            // 
            // Modelo
            // 
            Modelo.Text = "Modelo";
            Modelo.TextAlign = HorizontalAlignment.Center;
            Modelo.Width = 200;
            // 
            // Preço
            // 
            Preço.Text = "Preço";
            Preço.TextAlign = HorizontalAlignment.Center;
            Preço.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 132);
            label1.Name = "label1";
            label1.Size = new Size(123, 45);
            label1.TabIndex = 1;
            label1.Text = "Marca: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(163, 202);
            label2.Name = "label2";
            label2.Size = new Size(147, 45);
            label2.TabIndex = 2;
            label2.Text = "Modelo: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(163, 264);
            label3.Name = "label3";
            label3.Size = new Size(116, 45);
            label3.TabIndex = 3;
            label3.Text = "Preço: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(339, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(339, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(339, 271);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(691, 229);
            button1.Name = "button1";
            button1.Size = new Size(188, 80);
            button1.TabIndex = 7;
            button1.Text = "Inserir";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 824);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader Marca;
        private ColumnHeader Modelo;
        private ColumnHeader Preço;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}
