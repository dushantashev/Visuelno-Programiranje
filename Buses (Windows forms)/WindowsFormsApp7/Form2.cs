using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    
    public partial class Form2 : Form
    {
        public Avtobusi Avtobusi { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Avtobusi=new Avtobusi(textBox1.Text,textBox2.Text,checkBox1.Checked);
            DialogResult = System.Windows.Forms.DialogResult.OK;    


        }

    }
}
