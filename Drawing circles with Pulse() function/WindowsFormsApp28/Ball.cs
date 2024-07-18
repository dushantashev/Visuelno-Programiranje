using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp28
{
    public class Ball
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }
        public int hit { get; set; } = 0;
        public int qoef { get; set; } = -1;

        public Ball(Point center, int radius, Color color)
        {
            Center = center;
            Radius = radius;
            Color = color;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            brush.Dispose();
            if (hit > 0)
            {
                Pen pen = new Pen(Color.Black);
                g.DrawEllipse(pen, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
                pen.Dispose();
            }
        }

        public void isHit(Point point)
        {
            double distance = Math.Sqrt(Math.Pow(point.X - Center.X, 2) + Math.Pow(point.Y - Center.Y, 2));


            if (distance <= Radius)
            {
                hit = 1;
            }
        }
        public void Pulse()
        {
            Radius += (qoef * 3);
            if (Radius >= 30 || Radius <= 6)
            {
                qoef *= -1;

            }


        }
    }
}
