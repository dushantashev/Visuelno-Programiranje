using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    
    public partial class Form1 : Form
    {
        public Scene Scene { get; set; }
        public int TimerTicks { get; set; }
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene(this.Height,this.Width);
            timer1.Interval = 100;
            timer1.Start();
            TimerTicks = 0;
            DoubleBuffered = true;
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++TimerTicks;
            if(TimerTicks %10 == 0)//na izminata 1 sekunda
            {
                Scene.addBall();
            }
            
            Scene.Move();
            updateStatusLabels();
            Invalidate(true);
        }

        private void updateStatusLabels()
        {

            Hits.Text = String.Format("Hits: {0}", Scene.Hits);
            toolStripStatusLabel2.Text = String.Format("Misses: {0}", Scene.Misses);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Scene.Height=this.Height;
            Scene.Width=this.Width;

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.Hit(e.Location);
            Invalidate();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
