using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp20
{
    public class Scene
    {
        public List<Ball> Balls { get; set; }
   public int Height { get; set; }

        public int Width { get; set; }
        public int Hits { get; set; } = 0;
        public int Misses { get; set; } = 0;


        public static Random Random =new Random();

        public Scene(int Height, int Width)
        {
            this.Width = Width; 
            this.Height = Height;
            Balls = new List<Ball>();
        }
        public void addBall()
        {
            Balls.Add(new Ball(new Point(-Ball.Radius, Random.Next(2 * Ball.Radius, Height - 2 * Ball.Radius))));
        }
        public void Move()
        {
            foreach (Ball b in Balls)
            {
                b.Move(5, 0);
            }
            foreach (Ball b in Balls)
            {
                if (b.Center.X - Ball.Radius > Width)
                {
                    
                    b.State = -1;
                }
            }
            for (int i = 0; i < Balls.Count(); i++)
            {
                if (Balls[i].State == -1)
                {
                    ++Misses;
                    Balls.RemoveAt(i);

                }

            }
        }
public void Draw(Graphics g)
        {
            foreach(Ball b in Balls)
            {
                b.Draw(g);
            }
        }

        public void Hit(Point location)
        {
            
                foreach (Ball b in Balls)
                {
              b.Hit(location);

                }


            for (int i = 0; i < Balls.Count(); i++)
            {
                if (Balls[i].State == 3)
                {
                    ++Hits;
                    Balls.RemoveAt(i);

                }
                
            }
            
        }
    }
}
