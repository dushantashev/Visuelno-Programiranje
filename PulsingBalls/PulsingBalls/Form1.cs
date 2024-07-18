using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsingBalls
{
    public partial class Form1 : Form
    {
        public Scene scene;
        public Form1()
        {
           
            InitializeComponent();
            scene = new Scene();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point p=e.Location;
            scene.balls.Add(new Ball(p, 40, Color.Pink));
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
