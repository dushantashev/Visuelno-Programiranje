using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form2cs : Form
    {
        public Datum data { get; set; } 
        public Form2cs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            data = new Datum(dateTimePicker1.Text);
            DialogResult=System.Windows.Forms.DialogResult.OK;  
        }
    }
}
