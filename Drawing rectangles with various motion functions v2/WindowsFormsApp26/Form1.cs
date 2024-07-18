using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    public partial class Form1 : Form
    {
        public Scene Scene;
        Point point;
         int width;
        int height;
        
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Scene=new Scene();
            timer1.Start();
            width = this.Width;
            height = this.Height;
            update();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Scene.isHit(e.Location);
                
            } else if(e.Button == MouseButtons.Right)
            {
                Scene.canRotate(e.Location);
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point point = e.Location;
            Retangle retangle = new Retangle(point, Color.Blue, 100, 50);
            Scene.Retangles.Add(retangle);
            Invalidate();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.move(width,height);
            Invalidate();
            toolStripStatusLabel1.Text = "Count: " + Scene.Retangles.Count();
        }
        public void update()
        {
            toolStripStatusLabel1.Text = "Count: " + Scene.Retangles.Count();
        }
    }
}
