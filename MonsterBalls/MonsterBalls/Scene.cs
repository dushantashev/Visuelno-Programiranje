using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBalls
{
    public class Scene
    {
        public List<Ball> balls { get; set; }
        public List<Hole> holes { get; set; }
        public Random Random = new Random();
        public int CounterBalls { get; set; } 
        public Scene()
        {
            balls = new List<Ball>();

            holes = new List<Hole>();
        }
        public void addBalls(Ball s)
        {
            balls.Add(s);
        }
        public void addHoles(Hole s)
        {
            holes.Add(s);
        }
        public void generateHoles(int width,int height)
        {
           
             int x= Random.Next(0,width-60);
            int y = Random.Next(0,height-60);

            Hole hole = new Hole(new Point(x, y),30);
            holes.Add(hole);
        }
       
        public void Click(Point Location)
        {



            balls.Add(new Ball(Location, 25, Color.Blue));



        }
        public void Draw(Graphics g)
        {
            foreach(Hole h in holes)
            {
                h.Draw(g);
            }
            foreach (Ball b in balls)
            {
                b.Draw(g);
            }

           
        }

        public void Move(int width, int height)
        {
            foreach (Ball ball in balls)
            {
                ball.Move(width, height);
            }

            List<int> indicesToRemove = new List<int>();
            for (int i = 0; i < balls.Count; i++)
            {
                foreach (Hole hole in holes)
                {
                    if (hole.Contains(balls[i].Center))
                    {
                        indicesToRemove.Add(i);
                        ++CounterBalls;
                        break;
                    }
                }
            }

            // Remove balls starting from the highest index to avoid shifting issues
            
            foreach (int index in indicesToRemove)
            {
                balls.RemoveAt(index);
            }
        }



    }
}
