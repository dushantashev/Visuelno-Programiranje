using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp26
{
    public  class Retangle
    {
        public Point  Center { get; set; }
        public Color Color{ get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool isHit { get; set; } = false;
        public bool isOut { get; set; } = false;
        public bool canRotate { get; set; }=false;

        public Retangle(Point center, Color color, int width, int height)
        {
            Center = center;
            Color = color;
            Width = width;
            Height = height;
        }
        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            if (canRotate)
            {
                Center = new Point(Center.Y, Center.X);
                int tmp = Height;
                Height = Width;
                
                Width = tmp;
                g.FillRectangle(brush, Center.X - Width, Center.Y - Height,Width,Height);
            }
            else
            {
                g.FillRectangle(brush, Center.X - Width / 2, Center.Y - Height / 2, Width, Height);
                brush.Dispose();
            }
            brush.Dispose();

        }
        public void hit(Point point)
        {
            if( (point.X - Center.X) * (point.X - Center.X) * (point.Y - Center.Y) <= (Width * Height)) 
            {
                isHit = true;

            }
        }
        public void HitRotate(Point point) {
            if ((point.X - Center.X) * (point.X - Center.X) * (point.Y - Center.Y) <= (Width * Height))
            {
                canRotate = true;

            }
        }
        public void move(int width, int height)
        {
            Center = new Point(Center.X,Center.Y + Height);
            if(Center.Y > height )
            {
                isOut = true;
            }

        }

        public void rotate()
        {

        }
    }

}
