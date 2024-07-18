using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp31
{
    public class Scene
    {
        List<Line>lines {  get; set; }
        public Point LastPoint { get; set; } 
        public Color Color { get; set; }= Color.Red;
        public int Thikness { get; set; } = 1;
        public bool Positioner { get; set; }
        public Point Cursor { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Counter { get; set; } = 0;
        public Stack<Line> Undo {  get; set; }

        public Scene(int Width, int Height)
        {
            lines=new List<Line>();
            Color= Color.Red;
            Thikness = 1;
            LastPoint = Point.Empty;
            this.Width = Width;
            this.Height = Height;
            Undo = new Stack<Line>();
            
        }
        public void Retrot()
        {
            if (lines.Count > 0)
            {
                if (Undo.Count > 0)
                {
                    Line l = Undo.Pop();
                    lines.Add(l);
                    Counter++;
                    LastPoint = l.Right;
                }
            }
        }
        public void Undot()
        {
            if (lines.Count > 0)
            {
                Line l = lines[lines.Count - 1];
                Undo.Push(l);
                lines.Remove(l);
                Counter--;
                LastPoint = lines[lines.Count - 1].Right;
            }
        }
        public void AddPoint(Point point)
        {
            if(LastPoint.IsEmpty)
            {
                LastPoint = point;
            }
            else
            {
                lines.Add(new Line(LastPoint, point,Color,Thikness));
                LastPoint= point;
                Counter++;
            }
        }
        public void Draw(Graphics g)
        {
            foreach(Line line in lines)
            {
                line.Draw(g);
            }
            if (Positioner)
            {
                Pen p= new Pen(Color.Black);
                p.DashStyle=System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLine(p, new Point(0, Cursor.Y), new Point(Width, Cursor.Y));
                g.DrawLine(p, new Point(Cursor.X, 0), new Point(Cursor.X, Height));
                p.Dispose();
            }
        }

        
    }
}
