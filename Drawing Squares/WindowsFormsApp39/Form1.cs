using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp39
{
    public partial class Form1 : Form
    {
        Scene scene;
        public Point currentPoint { get; set; }
        public Point previousPoint { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        int x, y;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
            if (!previousPoint.IsEmpty)
            {
                Pen pen = new Pen(Color.Black, 2);
                pen.DashStyle=System.Drawing.Drawing2D.DashStyle.Dot;
                e.Graphics.DrawRectangle(pen, x, y, width, height);
                pen.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
            x = previousPoint.X;
            y= previousPoint.Y;
            if (x > currentPoint.X)
            {
                x= currentPoint.X;
            }
            if (y > currentPoint.Y)
            {
                y = currentPoint.Y;
            }
            width = Math.Abs(currentPoint.X - previousPoint.X);
            height = Math.Abs(currentPoint.Y - previousPoint.Y);
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (previousPoint.IsEmpty)
            {
                previousPoint = e.Location;
            }
            else
            {
                scene.AddRetangle(height, width,new Point(x, y), Color.GreenYellow);
            previousPoint=Point.Empty;
                currentPoint=Point.Empty;
            }

        }


    }
}
