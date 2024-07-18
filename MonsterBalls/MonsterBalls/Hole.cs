using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBalls
{
    public class Hole
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
     
        public Random Random { get; set; }
        public int Count { get; set; } = 0;


        public Hole(Point center, int radius)
        {
            Center = center;
            Radius = radius;
          
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Black);
            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            b.Dispose();

        }
        public bool Contains(Point point)
        {
            double distance = Math.Sqrt(Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2));
            return distance <= Radius;
        }
       
    }
}
