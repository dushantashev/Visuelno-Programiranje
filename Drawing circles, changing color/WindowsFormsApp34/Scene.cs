using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp34
{
    public class Scene
    {
        List<Ball>balls {  get; set; }

        public Scene()
        {
           balls=new List<Ball>();
        }
        public void AddBall(Point point, int width, int height, Color color) { 
        Ball b=new Ball(point,width,height,color);
            balls.Add(b);
        }          
        public void Draw(Graphics g)
        {
            foreach(Ball b in balls)
            {
                b.Draw(g);
            }
        }
        public void ChangeColor()
        {
            foreach (Ball b in balls)
            {
                b.ChangeColor();
            }
        }
    }
}
