using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp40
{
    public partial class Form1 : Form
    {
        Scene scene;
        public int Tick { get; set; }
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            UpdateINf();
            DoubleBuffered = true;
            timer1.Interval = 100;
            Tick = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void UpdateINf()
        {

            toolStripStatusLabel1.Text = String.Format("Active: {0}", scene.Counter);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                scene.AddBall(e.Location);
                scene.Counter++;
                UpdateINf();
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateINf();
            Tick++;
            if (Tick % 10 == 1)
            {
                scene.Transform();
                Invalidate();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
