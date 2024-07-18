using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp40
{
    public class Scene
    {
        public List<Ball> balls { get; set; }
        public int Counter { get; set; } = 0;
        public Scene() { 
        balls = new List<Ball>();
        }
        public void Draw(Graphics g)
        {
            foreach(Ball b in balls)
            {
                b.Draw(g);
            }
        }
        public void AddBall(Point location)
        {
            balls.Add(new Ball(Color.YellowGreen, location, 25));
        }


        public void Transform()
        {
            for(int i=balls.Count-1; i>=0; i--)
            {
                balls[i].State++;
                if (balls[i].State == 4)
                {
                    balls.RemoveAt(i);
                    Counter--;
                }
            }
            
               
            
        }

    }
}
