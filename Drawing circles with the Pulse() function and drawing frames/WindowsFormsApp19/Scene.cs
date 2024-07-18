using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp19
{
    public class Scene
    {
        public List<Shape>  Shapes {  get; set; }

        public Scene()
        {
           Shapes=new List<Shape>();
        }
        public void addShape(Shape s)
        {
            Shapes.Add(s);
        }

        public void DrawAll(Graphics g)
        {
            foreach (Shape s in Shapes)
            {
                s.Draw(g);
            }
        }
        public void Click(Point Location, string ShapeType)
        {
            bool found = false;
            foreach (Shape s in Shapes)
            {
                if (s.IsHit(Location))
                {
                    found = true;
                    s.Selected = !s.Selected;

                }
            }
            if (!found)
            {
                if (ShapeType == "Circle")
                {
                    Shapes.Add(new Circle(Color.Red, 30, Location));
                }
                else
                Shapes.Add(new Square(Color.Red, 30,Location));
            }
        }

        public void Pulse()
        {
            foreach(Shape s in Shapes)
            {
                s.Pulse();
            }
        }
    }
}
