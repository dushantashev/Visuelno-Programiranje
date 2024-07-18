using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp27
{
    public class Scene
    {
        public List<Retagle> Retangles { get; set; }
        public static int Counter { get; set; } = 1;

        public Scene()
        {
            Retangles = new List<Retagle>();
        }
        public void addRetangle()
        {
            foreach (Retagle ret in Retangles)
            {
                Retangles.Add(ret);
                ++Counter;
            }
        }
        public void Draw(Graphics g)
        {
            foreach (Retagle ret in Retangles)
            {
                ret.Draw(g);
                
            }
        }
        public void isHit(Point point)
        {
            foreach (Retagle r in Retangles)
            {
                r.hit(point);
            }
        }
        public void move(int width,  int height)
        {
            foreach (Retagle r in Retangles)
            {
                if (r.isHit)
                {
                    r.move(width, height);
                   
                }
            }

        }
        public void moveRatated(int width, int height)
        {
            foreach (Retagle r in Retangles)
            {
                if(r.isHit)
                {
                    r.moveRotated(width, height);
                   
                }
            }
        }
        public void remove()
        {
            for(int i=Retangles.Count-1; i>=0; i--)
            {
                if (Retangles[i].isOut)
                {
                    Retangles.RemoveAt(i);
                }
            }
        }
        

    }
}
