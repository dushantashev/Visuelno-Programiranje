using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    public class Scene
    {
        public List<Ball> balls { get; set; }
        public Scene() { 
        balls=new List<Ball>();

        }
        public void addBalls(Ball b)
        {
            balls.Add(b);
        }
        public void Draw(Graphics g)
        {
            foreach(Ball b in balls)
            {
                b.Draw(g);
            }
        }
        public void Click(Point Location, string ShapeType)
        {
            bool found = false;
            foreach (Ball s in balls)
            {
                if (s.IsHit(Location))
                {
                    found = true;
                   

                }
            }

            new Ball(20, Color.Black, Location);
               
            
        }



    }
}
