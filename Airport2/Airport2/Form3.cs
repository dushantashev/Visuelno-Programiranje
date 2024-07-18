using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport2
{
    public partial class Form3 : Form
    {
        public Destinacion CreatedDestination { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatedDestination = new Destinacion(textBox1.Text,(int)numericUpDown1.Value,(int)numericUpDown2.Value);
        DialogResult = DialogResult.OK;
        }
    }
}
