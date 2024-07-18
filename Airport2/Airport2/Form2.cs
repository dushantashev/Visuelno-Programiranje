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
    public partial class Form2 : Form
        
    {
        public Airport CreatedAirport { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatedAirport = new Airport(textBox1.Text,textBox2.Text,textBox3.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
