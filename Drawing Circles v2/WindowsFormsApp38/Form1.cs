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

namespace WindowsFormsApp38
{
   
    public partial class Form1 : Form
    {

        Scene scene;
        public Point previousPoint { get; set; }
        public Point currentPoint { get; set; }
        public  int width { get; set; }
        public  int height { get; set; }
        int x, y;

        public Form1()
        {
            InitializeComponent();
            scene=new Scene();
            DoubleBuffered = true;

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (previousPoint.IsEmpty)
            {
                previousPoint = e.Location;
                
            }
            else
            {
                scene.AddBall(new Point(x, y), height, width, Color.Bisque);
                previousPoint = Point.Empty;


            currentPoint= Point.Empty;
               
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
            x = previousPoint.X;
            y = previousPoint.Y;
            if(x>currentPoint.X)x=currentPoint.X;
            if(y>currentPoint.Y)y=currentPoint.Y;
            width=Math.Abs(currentPoint.X- previousPoint.X);
            height=Math.Abs(currentPoint.Y- previousPoint.Y);
            Invalidate();
        }
        public void Draw(Graphics g)
        {
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            scene.Draw(e.Graphics);
            if (!previousPoint.IsEmpty)
            {
                Pen pen=new Pen(Color.Black, 2);
                pen.DashStyle=System.Drawing.Drawing2D.DashStyle.Solid;
                e.Graphics.DrawEllipse(pen,x,y,width,height);
                pen.Dispose();
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
