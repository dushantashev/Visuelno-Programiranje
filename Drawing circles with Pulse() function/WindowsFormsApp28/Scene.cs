using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp28
{
    public class Scene
    {
        public List<Ball> balls {get; set;}
        public Scene() { 
        balls = new List<Ball>();
        }
        public void Draw(Graphics g)
        {
            foreach (Ball b in balls)
            {
                b.Draw(g);
            }
        }
        public void Ishit(Point location)
        {
            foreach (Ball b in balls)
            {

                b.isHit(location);


            }
          
            }

                
           
        }

        
}
