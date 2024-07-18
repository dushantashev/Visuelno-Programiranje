using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp45
{
    public partial class Form1 : Form
    {
        Scene scene;
        public bool Flag { get; set; }=false;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            DoubleBuffered = true;
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (!Flag)
            {
                scene.Click(e.Location);
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene.Start = !scene.Start;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         scene.PickRandomBall();
            Invalidate();
        }
    }
}
