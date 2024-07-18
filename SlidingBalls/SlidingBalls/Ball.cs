using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    public class Ball
    {
        public int Radius { get; set; }
        public Color Color { get; set; }

        public Point Center { get; set; }
        public int velocityX { get; set; }
        public int velocityY { get; set; }

        public Ball(int radius, Color color, Point center)
        {
            Random random = new Random();
            Radius = radius;
            Color = color;
            Center = center;
            this.velocityX = random.Next(-10, 10);
            this.velocityY = random.Next(-10, 10);
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            b.Dispose();
        }
        public bool IsHit(Point point)
        {
            double distance = Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2);
            return distance < Radius;

        }
      

        public void Move(int width, int height)
        {
            Center = new Point(Center.X + velocityX, Center.Y + velocityY);

            if (Center.X - Radius < 0 || Center.X > width)
            {
                velocityX = -velocityX;
            }
            if (Center.Y - Radius < 0 || Center.Y > height)
            {
                velocityY = -velocityY;
            }
        }


    }
}
