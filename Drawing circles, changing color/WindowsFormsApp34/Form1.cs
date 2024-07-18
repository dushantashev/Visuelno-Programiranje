using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp34
{
    public partial class Form1 : Form
    {
        Scene scene;
        public Point previousPoint { get; set; }
        public Point currentPoint { get; set; }
        public int x, y;
        public int width, height;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            timer1.Start();
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (previousPoint.IsEmpty)
            {
                previousPoint = e.Location;
            }
            else
            {
                scene.AddBall(new Point(x, y), width, height, Color.Red);
                previousPoint = Point.Empty;
                currentPoint = Point.Empty;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.ChangeColor();
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
            x = previousPoint.X; y = previousPoint.Y;
            if (x > currentPoint.X) x = currentPoint.X;
            if (y > currentPoint.Y) y = currentPoint.Y;
            width = Math.Abs(previousPoint.X - currentPoint.X);
            height = Math.Abs(previousPoint.Y - currentPoint.Y);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            scene.Draw(e.Graphics);
            if (!previousPoint.IsEmpty)
            {
                Pen pen = new Pen(Color.Black, 1);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                e.Graphics.DrawEllipse(pen, x, y, width, height);
                pen.Dispose();
            }
        }
    }
}
