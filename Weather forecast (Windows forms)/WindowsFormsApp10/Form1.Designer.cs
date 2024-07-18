namespace WindowsFormsApp10
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(35, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 260);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Прогноза";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Додади ден";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Избриши ден";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(384, 112);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(275, 22);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(384, 164);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(275, 22);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 51);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(384, 319);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 51);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Датум";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(484, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(105, 42);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Максимална температура";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Минимална температура";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ден со најголема максимална температура";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ден со најмала минимална температура";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.RichTextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

