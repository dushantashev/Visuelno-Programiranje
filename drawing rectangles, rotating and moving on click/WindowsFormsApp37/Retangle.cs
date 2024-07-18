using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp37
{
    public class Retangle
    {
        public int HeightRet { get; set; }
        public int WidthRet { get; set; }
        public Point point { get; set; }
        
        public Color color { get; set; }
        public int flag { get; set; } = 0;

        public Retangle(int heightRet, int widthRet, Point point, Color color)
        {
            HeightRet = heightRet;
            WidthRet = widthRet;
            this.point = point;
            this.color = color;
            flag = 0;
        }
        public void Draw(Graphics g)
        {
            Brush b=new SolidBrush(color);
            g.FillRectangle(b,point.X- WidthRet,point.Y- HeightRet,2*WidthRet,2*HeightRet);
            b.Dispose();
        }
        public void Move(int dx, int dy)
        {
            point= new Point(point.X+dx,point.Y+dy);
        }
        public bool Hit(Point p)
        {
            double distance = Math.Sqrt(Math.Pow(point.X - p.X, 2) + Math.Pow(point.Y - p.Y, 2));
            if (distance < HeightRet) {
                return true;
            }
            return false;
        }

    }
}
