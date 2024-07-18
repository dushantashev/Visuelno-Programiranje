using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp32
{
    public class Scene
    {
        List<Line> lines {  get; set; }
        public Point LastPoint { get; set; }
        public Color Color { get; set; }
        public int Thickness {get; set; }
        public bool Positioner { get; set; }
        public Point Cursor { get; set; }
        public int Width { get; set; }
    public int Height { get; set; }
        public Scene(int width, int height)
        {
            lines= new List<Line>();
            LastPoint= new Point();
            Color = Color.Black;
            Thickness = 1;
            LastPoint=new Point();
            Positioner = false;
            Width = width;
            Height = height;
           
        }
        public void Draw(Graphics g)
        {
            foreach (Line line in lines)
            {
                line.Draw(g);
            }
            if(Positioner)
            {
                Pen p=new Pen(Color.Black);
               
                g.DrawLine(p, new Point(0, Cursor.Y), new Point(Width, Cursor.Y));
                g.DrawLine(p, new Point(Cursor.X,0), new Point(Cursor.X,Height));
                p.Dispose();
            }
        }
        public void AddPoint (Point point)
        {
            if (LastPoint.IsEmpty)
            {
                LastPoint = point;
            }
            else
            {
                lines.Add(new Line(LastPoint, point, Color, Thickness));
                LastPoint = point;
            }
        }
    }
}