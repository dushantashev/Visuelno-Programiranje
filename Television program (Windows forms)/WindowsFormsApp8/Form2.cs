using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    
    public partial class Form2 : Form
    {
        public Televizija televizija {  get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            televizija = new Televizija(textBox1.Text, (int)numericUpDown1.Value);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
