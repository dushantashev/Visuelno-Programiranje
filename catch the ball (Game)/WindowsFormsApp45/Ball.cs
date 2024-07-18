using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp45
{
    public class Ball
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }
        public bool Marked { get; set; } = false;
        public bool Delete { get; set; } = false;

        public Ball(Point center, int radius, Color color)
        {
            Center = center;
            Radius = radius;
            Color = color;
        }
        public void Draw(Graphics g)
        {
            Brush b=new SolidBrush(Color);
            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            b.Dispose();
            if(Marked)
            {
                Pen pen=new Pen(Color.Yellow,2);
                g.DrawEllipse(pen, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
                pen.Dispose();
            }
            if (Delete==true)
            {
                Pen pv = new Pen(Color.Black, 7);
                g.DrawEllipse(pv, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
                pv.Dispose();
            }
        }
        public bool Ishit(Point p)
        {
           double distance= Math.Sqrt(Math.Pow(Center.X-p.X, 2) + Math.Pow(Center.Y - p.Y, 2));
        if(distance <Radius)
            {
                return true;
            }
        return false;
        }
        public bool OverLap(Ball ball)
        {
            return Math.Sqrt(Math.Pow(Center.X - ball.Center.X, 2) + Math.Pow(Center.Y - ball.Center.Y, 2)) <= (Radius + ball.Radius);
        }
    }
}
