using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp35
{
    public class Ball
    {
        public Color Color { get; set; }
        public Point point { get; set; }
        public int Radius { get; set; }
        public int Hit {  get; set; }
        public Ball(Color color, Point point, int radius)
        {
            Color = color;
            this.point = point;
            Radius = radius;
            Hit = 0;
        }

        public void Draw(Graphics g)
        {
            Brush b=new SolidBrush(Color);
            g.FillEllipse(b, point.X - Radius, point.Y - Radius, 2 * Radius, 2 * Radius);
            b.Dispose();
            if(Hit > 0 )
            {
                Pen p=new Pen(Color.Red,5);
                g.DrawEllipse(p, point.X - Radius, point.Y - Radius, 2 * Radius, 2 * Radius);
            p.Dispose();
            }
        }
        public int IsHit(Point p)
        {
            double distance = Math.Sqrt(Math.Pow(point.X - p.X, 2) + Math.Pow(point.Y - p.Y, 2));
            if (distance < Radius)
            {
                return 1;
            }  
            return 0;
        }

    }
}
