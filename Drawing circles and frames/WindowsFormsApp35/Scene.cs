using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp35
{
    public class Scene
    {
        public Color Color { get; set; }= Color.GreenYellow;
        public int Radius { get; set; } = 40;
        public List<Ball> balls { get; set; }

        public Scene()
        {
            balls = new List<Ball>();
        }
        public void Draw(Graphics e)
        {
            foreach (Ball b in balls)
            {
                b.Draw(e);
            }
        }
        public void AddBall(Point p)
        {
           
        }
        public void Hit(Point p)
        {
            bool found=false;
            foreach(Ball b in balls)
            {
                if (b.IsHit(p) == 1)
                {
                    found = true;
                    b.Hit = 1;
                }
            }
            if (!found)
            {
                balls.Add(new Ball(Color, p, Radius));
            }
            
        }


    }
}
