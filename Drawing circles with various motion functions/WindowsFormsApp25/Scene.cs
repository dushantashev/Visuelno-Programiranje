using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp25
{
    public class Scene
    {
        List<Ball> balls { get; set; }
        public int Limit { get; set; } = 0;
        public int Counter { get; set; } = 0;
        public int Width { get; set; }
        public int Height { get; set; }
        public Scene(int Width, int Height)
        {
            balls = new List<Ball>();
            Width = this.Width;
            Height = this.Height;
        }

        public void addBall(Ball b)
        {
            balls.Add(b);
        }
        public void Move(int i,int c, int height,int width)
        {
            foreach (Ball b in balls)
            {
                if (b.Selected && b.color == Color.Red && Limit == 0)
                {

                    Random random = new Random();
                    b.Move(50, 30, height, width);
                    Limit = 1;

                }
                else
                {
                    Limit =0;
                    b.Move(0, 0, height, width);
                }
            }
           
            for (int g=0; g < balls.Count; g++) {

                if (balls[g].State == -1)
                {
                    balls.RemoveAt(g);
                    Counter--;
                }
            }




        }

        public void Draw(Graphics g)
        {
            foreach (Ball b in balls)
            {
                b.Draw(g);
               
            }
        }
        public void Click(Point Location, Color color)
        {
            bool found = false;
            foreach (Ball b in balls)
            {
                if (b.IsHit(Location))
                {
                    found = true;
                    b.Selected = !b.Selected;
                }
            }
            if (!found)
            {
                balls.Add(new Ball(Location, 40, color));
                Counter++;
            }
        }
        internal void Hit(Point location)
        {
            foreach (Ball b in balls)
            {
                b.IsHit(location);
            }
        }
    }
    
}
