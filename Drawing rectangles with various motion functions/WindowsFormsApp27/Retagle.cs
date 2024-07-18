using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp27
{
    public class Retagle
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Point Center { get; set; }
        public Color Color { get; set; }
        public bool isHit { get; set; } = false;
        public bool isOut { get; set; } = false;
        public static int couter { get; set; } = 0;
        
        


        public Retagle(int height, int width, Point center, Color color)
        {
            Height = height;
            Width = width;
            Center = center;
            Color = color;
        }

        public void Draw(Graphics e)
        {
            SolidBrush brush = new SolidBrush(Color);
            e.FillRectangle(brush,Center.X-Width/2, Center.Y-Height/2, Width, Height);
            brush.Dispose();
            couter++;
        }
        public void hit(Point point)
        {
            if ((point.X - Center.X) * (point.X - Center.X) * (point.Y - Center.Y) <= (Width * Height)){
                isHit = true;
            }
        
        }
        public void move(int width, int height)
        { 

            Center = new Point(Center.X, Center.Y + Height);
            if (Center.Y > height)
            {
               isOut = true;
            }
        }
        public void moveRotated(int width, int height)
        {
            Center=new Point (Center.X+ Width, Center.Y);

        if(Center.X> width)
            {
                isOut = true;
            }
        
        }

    }
}
