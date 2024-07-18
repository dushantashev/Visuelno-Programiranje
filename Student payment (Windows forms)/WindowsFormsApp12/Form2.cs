using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form2 : Form
    {
        public Student student { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            student = new Student(textBox1.Text,textBox2.Text);
            DialogResult=System.Windows.Forms.DialogResult.OK;  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(textBox1.Text.Length == 0) {
                errorProvider1.SetError(textBox1, "Vensi neshto");
                e.Cancel = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if(textBox2.Text.Length != 6)
            {
                errorProvider1.SetError(textBox2, "Vnesi 6 karakteri");

            }
        }
    }
}
