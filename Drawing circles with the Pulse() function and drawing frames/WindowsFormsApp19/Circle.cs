using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp19
{
    public class Circle : Shape
    {
        public Point Center { get; set; }
        
        public Circle(Color color, int size,Point Center) : base(color, size)
        {
            this.Center = Center;
        }

        public override void Draw(Graphics g)
        {
            Brush b=new SolidBrush(this.Color);
            if (Selected)
            {
                Pen p = new Pen(Color.Black, 5);
                g.DrawEllipse(p, Center.X - Size, Center.Y - Size, 2 * Size, 2 * Size);
                p.Dispose();
            }
            g.FillEllipse(b, Center.X - Size, Center.Y - Size, 2 * Size, 2 * Size);
        }

        public override bool IsHit(Point p)
        {
            return Math.Sqrt(Math.Pow(Center.X - p.X, 2) + Math.Pow(Center.Y - p.Y, 2))<=Size;
        
        }

        public override void Pulse()
        {
            Size += (qoef * 3);
            if(Size>=30 || Size <= 6) {
                qoef *= -1;

            }
        

        }
    }
}
