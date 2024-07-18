using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterBalls
{
    public partial class Form1 : Form
    {
        public Scene Scene {  get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int Timer = 0;
        public Random Random = new Random();
        Point point {  get; set; }
        //public Color Color { get; set; }
        public Form1()
        {
           
            InitializeComponent();
            //width = this.Width - 50;
            //height = this.Height - 140;
            Scene=new Scene();
            timer1.Start();
            DoubleBuffered = true;
            for (int i = 0; i < 3;i++)
            {
                Scene.generateHoles(this.width,this.height);
            }
            // Color = Color.Blue;
            //Width = this.Width - 20;
            //Width = this.Width - 20;
            updateInf();
            Invalidate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 1);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            e.Graphics.DrawRectangle(p,20,30,width,height);
            p.Dispose();
            Scene.Draw(e.Graphics);
           
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Scene.Click(e.Location);
                Invalidate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.Move(width,height);
            updateInf();
            Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            width = this.Width - 50;
            height = this.Height - 150;
            Invalidate();
        }

        public void updateInf()
        {
            toolstr.Text = String.Format("Balls: {0}",Scene.CounterBalls);
        }

    }
}
