using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp39
{
    public class Retangle
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Point Point { get; set; }
        public Color Color { get; set; }

        public Retangle(int height, int width, Point point, Color color)
        {
            Height = height;
            Width = width;
            Point = point;
            Color = color;
        }
        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillRectangle(brush,Point.X,Point.Y,Width,Height);
            brush.Dispose();
        }

    }
}
