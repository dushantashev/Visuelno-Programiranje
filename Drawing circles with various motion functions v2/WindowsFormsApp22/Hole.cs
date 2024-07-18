using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp22
{
    public class Hole
    {
        
        public Point Center2 { get; set; }
        public Color Color2 { get; set; }
        public int Size {  get; set; }

        public Hole(Color color, int size, Point center2) 
        {
            Center2 = center2;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color2);
            g.FillEllipse(b, Center2.X - Size, Center2.Y - Size, 2 * Size, 2 * Size);
            b.Dispose();
        }

       

        public  bool Hit(Point p)
        {
            return Math.Sqrt(Math.Pow(Center2.X - p.X, 2) + Math.Pow(Center2.Y - p.Y, 2)) <= Size;
        }
    }
}
