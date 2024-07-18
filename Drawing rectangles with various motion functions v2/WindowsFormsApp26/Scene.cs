using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp26
{
    public class Scene
    {
        public List<Retangle> Retangles { get; set; }

        public Scene()
        {
            Retangles=new List<Retangle>();
        }
        public void Draw(Graphics g)
        {
            foreach (Retangle retangle in Retangles)
            {
                retangle.Draw(g);
            }
        }
        public void isHit(Point point)
        {
            foreach (Retangle r in Retangles)
            {
                r.hit( point);
            }
        }

        public void move(int width, int height)
        {
            Retangles.ForEach(r =>
            {
                if (r.isHit)
                {
                    r.move(width,height);
                }
            });
            for(int i = Retangles.Count - 1; i >= 0; i--)
            {
                if (Retangles[i].isOut)
                {
                    Retangles.RemoveAt(i);
                }
            }


        }
        public void canRotate(Point point)
        {
            Retangles.ForEach((r) =>
            {
                r.HitRotate(point);
            });
        }

    }
}
