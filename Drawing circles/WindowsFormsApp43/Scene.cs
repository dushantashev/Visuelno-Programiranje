using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp43
{
    public class Scene
    {
      public List<Ball> balls {  get; set; }
        public Scene() {
        balls = new List<Ball>();
        }
         public void Draw(Graphics e)
        {
            foreach(Ball b in balls)
            {
                b.Draw(e);
            }
        }
        public void AddBall(Point location,int Width, int Height) {
            balls.Add(new Ball(location, Height, Width, Color.Red));
        }
        public void Action()
        {
            foreach(Ball b in balls)
            {
                b.Action();
            }
        }
    }
}
