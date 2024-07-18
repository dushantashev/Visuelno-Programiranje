using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp31
{
    public class Line
    {
        public Point Left { get; set; }
        public Point Right { get; set; }
        public Color color { get; set; }
        public int Thickness { get; set; }

        public Line(Point left, Point right, Color color, int thickness)
        {
            Left = left;
            Right = right;
            this.color = color;
            Thickness = thickness;
        }

        public void Draw(Graphics g)
        {
            Pen p = new Pen(color, Thickness);
            g.DrawLine(p,Left,Right);
            p.Dispose();
        }

    }
}
