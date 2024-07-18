using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBalls
{
    public class Ball
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }
        public int velocityX { get; set; }
        public int velocityY { get; set; }

        public Ball(Point center, int Radius, Color color)
        {
            Random random = new Random();
            Center = center;
            Color = color;
            this.Radius = Radius;
            this.velocityX = random.Next(-10, 10);
            this.velocityY = random.Next(-10, 10);
        }

        public void Draw(Graphics g)
        {
            Brush s = new SolidBrush(Color);
            g.FillEllipse(s, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            s.Dispose();
        }
        public bool IsHit(Point p)
        {
            double distance = Math.Pow(Center.X - p.X, 2) + Math.Pow(Center.Y - p.Y, 2);
            return distance < Radius;
        }

        public void Move(int width, int height)
        {
            Center = new Point(Center.X + velocityX, Center.Y + velocityY);

            if (Center.X - Radius < 0 || Center.X  > width)
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
