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
    public partial class Form3 : Form
    {
        public Linija Linija {  get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Linija = new Linija(textBox1.Text,(int) numericUpDown2.Value,(int) numericUpDown3.Value, (int)numericUpDown4.Value);
       DialogResult=System.Windows.Forms.DialogResult.OK;
        }
    }
}
