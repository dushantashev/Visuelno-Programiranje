using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulsingBalls
{
    public class Ball
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }

        public Ball(Point center, int raadius, Color color)
        {
            Center = center;
            Radius = raadius;
            Color = color;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush,Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
        brush.Dispose();
        }

    

    }
}
