using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp38
{
    public class Ball
    {
        public Point Point{ get; set; }
        public int Height { get; set; }
        public  int Width { get; set; }
        public Color Color { get; set; }

        public Ball(Point point, int height, int width, Color color)
        {
            Point = point;
            Height = height;
            Width = width;
            Color = color;
        }
        public void Draw(Graphics g) { 
        Brush brush=new SolidBrush(Color);
            g.FillEllipse(brush, Point.X, Point.Y, Width, Height);
            brush.Dispose();
        }

    }
}
