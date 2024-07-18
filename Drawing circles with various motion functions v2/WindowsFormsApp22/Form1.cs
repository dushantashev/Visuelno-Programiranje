using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        public Scene Scene {  get; set; }
        public int TimerTicks { get; set; }

        public string ShapeType { get; set; } = "Circle";
        public Form1()
        {
            InitializeComponent();
            Scene=new Scene();
            timer1.Interval = 100;
            TimerTicks = 0;
            timer1.Start();
            DoubleBuffered=true;
           Random random = new Random();
            for(int i = 0; i < 3; i++)
            {

            }
            Scene.SetRandomHolePositions(random.Next(10), random.Next(10), random.Next(10), random.Next(10), random.Next(10));
            Invalidate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.Click(e.Location,ShapeType);
            
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.DrawAll(e.Graphics);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

          
            
            


        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            ++TimerTicks;
            if (TimerTicks % 10 == 0)
            {
                Scene.Move();
                Invalidate();
            }
        }
    }
}
