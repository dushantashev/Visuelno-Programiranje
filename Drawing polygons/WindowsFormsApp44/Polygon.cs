using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp44
{
    public class Polygon
    {
        public List<Point> points { get; set; }
       
        public Point Curser { get; set; }
        public bool isComplited { get; set; } = false;
        public Polygon() { 
        points=new List<Point>();
                }    
    
    public void AddPoint(Point point)
        {
            if (NearStart())
            {
                points.Add(points[0]);
                isComplited = true;

            }
            else
            {
                points.Add(point);
            }
            
        }
        public  bool NearStart()
        {
            if(points.Count > 3) {
                return Math.Sqrt(Math.Pow(points[0].X - Curser.X, 2) + Math.Pow(points[0].Y - Curser.Y, 2)) < 10;
            }
            else
            {
                return false;
            }
        }
        public void Draw(Graphics g)
        {
            if (points.Count >= 2) { 
                Pen p = new Pen(Color.Black, 2);
            g.DrawLines(p, points.ToArray());
            p.Dispose();
            if(NearStart()&& !isComplited)
                {
                    Pen pen = new Pen(Color.Black, 2);
                    g.DrawEllipse(pen, points[0].X - 5, points[0].Y,10,10);
                    pen.Dispose();
                }
            }


            if(isComplited)
            {
                Brush b=new SolidBrush(Color.Blue);
                g.FillPolygon(b, points.ToArray());
                b.Dispose();

            }
        }
    }
}
