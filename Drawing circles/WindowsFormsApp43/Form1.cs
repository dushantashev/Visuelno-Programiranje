using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp43
{
    public partial class Form1 : Form
    {
        Scene scene;
        public Point previosPoint { get; set; }
        public Point currentPoint { get; set; }
        public int x, y;
        public int width, height;
        int TimerInterval = 0;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            DoubleBuffered = true;
            
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
            x=previosPoint.X ; y=previosPoint.Y;
            if(x>currentPoint.X) x = currentPoint.X;
            if(y>currentPoint.Y) y = currentPoint.Y;
           width=Math.Abs(previosPoint.X-currentPoint.X);
            height=Math.Abs(previosPoint.Y-currentPoint.Y);
           
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            scene.Draw(e.Graphics);
            if (!previosPoint.IsEmpty)
            {
                Pen pen = new Pen(Color.Black, 2);
                pen.DashStyle=System.Drawing.Drawing2D.DashStyle.Dot;
                e.Graphics.DrawEllipse(pen, x, y, width, height);
                pen.Dispose();
            }

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                timer1.Start();
            }   
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerInterval++;
            if (TimerInterval % 10 == 1)
            {
                scene.Action();
                Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(previosPoint.IsEmpty)
            {
                previosPoint = e.Location;
            }
            else
            {
                scene.AddBall(new Point(x,y),width,height);
                previosPoint = Point.Empty;
                currentPoint = Point.Empty;
                
            }
            Invalidate();
        }
    }
}
