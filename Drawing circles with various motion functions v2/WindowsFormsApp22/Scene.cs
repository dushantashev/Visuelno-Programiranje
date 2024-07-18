using System;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp22
{
    public class Scene
    {
        public List<Shape> Shapes { get; set; }
        public List<Hole> Holes { get; set; }
        private Random random;

        public Scene()
        {
            Shapes = new List<Shape>();
            Holes = new List<Hole>();
            random = new Random();
        }

        public void AddShape(Shape s)
        {
            Shapes.Add(s);
        }

        public void AddHole(Hole s)
        {
            Holes.Add(s);
        }

        public void DrawAll(Graphics g)
        {
            foreach (Shape s in Shapes)
            {
                s.Draw(g);
            }
            foreach (Hole s in Holes)
            {
                s.Draw(g);
            }
        }

        public void Move()
        {
            foreach (Shape s in Shapes)
            {
                s.Move(random.Next(10), random.Next(10));
            }
        }

        internal void Click(Point location, string ShapeType)
        {
            bool found = false;
            foreach (Shape s in Shapes)
            {
                if (s.IsHit(location))
                {
                    found = true;
                    s.Selected = !s.Selected;
                }
            }
            if (!found)
            {
                if (ShapeType == "Circle")
                {
                    Shapes.Add(new Circle(Color.Red, 30, location));
                }
            }
        }

        // Метод за поставување на дупките на рандом место
        public void SetRandomHolePositions(int count, int minX, int minY, int maxX, int maxY)
        {
            for (int i = 0; i < count; i++)
            {
                int x = random.Next(minX, maxX);
                int y = random.Next(minY, maxY);
                Holes.Add(new Hole(Color.Black, 20, new Point(x, y)));
            }
        }
    }
}
