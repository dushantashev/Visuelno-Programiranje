using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp19
{
    public class Square : Shape
    {
        public Point TopLeft { get; set; }
      
        public Square(Color color, int size,Point topLeft) : base(color, size)
        {
            TopLeft = topLeft;
        }


        public override void Draw(Graphics g)
        {
            Brush b=new SolidBrush(this.Color);
            g.FillRectangle(b,TopLeft.X, TopLeft.Y,Size,Size);
            if (Selected)
            {
                Pen p=new Pen(Color.Black,5);
                g.DrawRectangle(p, TopLeft.X, TopLeft.Y, Size, Size);
                p.Dispose();
            }
            b.Dispose();
                }

        public override bool IsHit(Point p)
        {
            Rectangle r = new Rectangle(TopLeft.X,TopLeft.Y,Size,Size);
            return r.Contains(p);
        }

        public override void Pulse()
        {
            Size += (qoef * 3);
            if(Size>=30|| Size <= 6)
            {
                qoef *= -1;
            }
        }
    }
}
