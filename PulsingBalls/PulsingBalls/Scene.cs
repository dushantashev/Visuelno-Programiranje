using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulsingBalls
{
    public class Scene
    {
        public List<Ball>balls { get; set; }


        public Scene() { 
        balls = new List<Ball>();   
        }

        public void Draw(Graphics graphics) { 
foreach(Ball b in balls)
            {
                b.Draw(graphics);
            }
}
}
}
