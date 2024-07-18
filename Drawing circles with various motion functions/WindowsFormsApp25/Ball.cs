using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp25
{
    public class Ball
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public Color color { get; set; }
        public int velocityX { get; set; }
        public int velocityY { get; set; }
        public int State { get; set; }
        public bool Selected { get; set; }
        public Ball(Point center, int radius, Color color)
        {
            Random random = new Random();

            Center = center;
            Radius = radius;
            this.color = color;
            this.velocityX = random.Next(-10, 10);
            this.velocityY = random.Next(-10, 10);
            State = random.Next(3);
            Selected = false;

        }

        public void Draw( Graphics g)
        {
            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush,Center.X-Radius,Center.Y-Radius,2*Radius,2*Radius);
            brush.Dispose();
        }
        public bool IsHit(Point point)
        {
        return  Math.Sqrt(Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2)) <= Radius;
        }
        public void Move(int dx,int dy, int height, int width)
        {
            
            Center = new Point(Center.X + dx, Center.Y + dy);
            if (Center.X - Radius < 0 || Center.X > width)
            {
                State = -1;
            }
            if (Center.Y - Radius < 0 || Center.Y > height)
            {
                State = -1;
            }







        }




    }
}
