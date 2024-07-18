using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp38
{
    public class Scene
    {
        public List<Ball>balls {  get; set; }
        public Scene() { 
        balls=new List<Ball>();
                }
        public void Draw(Graphics g)
        {
            foreach(Ball b in balls)
            {
               b.Draw(g);
            }
        }
        public  void AddBall(Point point, int height, int width, Color color)
        {
            balls.Add(new Ball(point, height, width, color));
        }
    }
}
