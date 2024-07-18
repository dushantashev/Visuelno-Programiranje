using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp45
{

    public class Scene
    {
        List<Ball> balls { get; set; }
        public bool Start { get; set; } = true;
        Random random = new Random();
        public Scene() {
            balls = new List<Ball>();
        }
        public void Draw(Graphics e)
        {
            foreach (Ball b in balls)
            {
                b.Draw(e);
            }
        }
        public void AddBall(Point location)
        {



        }
        /*    public void IsHit(Point location)
            {
                foreach (Ball b in balls)
                {
                    if (b.Ishit(location))
                    {
                        b.Marked = 1;
                    }
                }
            }*/
        public void Click(Point location)
        {
            bool ballHit = false;
            foreach (Ball b in balls)
            {
                if (b.Ishit(location))
                {
                    b.Marked = !b.Marked;
                    ballHit = true;
                    break; // Exit loop after finding the first hit ball
                }
            }

            if (!ballHit)
            {
                if (Start)
                    balls.Add(new Ball(location, 25, Color.Red));
            }
        }
        public void PickRandomBall()
        {
            if (balls.Count >0) { 
                Ball selected = balls[random.Next(0, balls.Count)];
            while (selected.Marked && !selected.Delete)
            {
                selected = balls[random.Next(0, balls.Count)];
            }
            selected.Delete = true;
        } }

    }
}
