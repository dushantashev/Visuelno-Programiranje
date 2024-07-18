using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp31
{
    public partial class Form1 : Form
    {
        Scene scene;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene(this.Width,this.Height);
            DoubleBuffered = true;
            timer1.Start();

            Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.AddPoint(e.Location);
            scene.Undo.Clear();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg= new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                scene.Color= dlg.Color;
            }
        }

        private void thickToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            normalToolStripMenuItem.Checked= true;
            scene.Thikness = 2;
        }

        private void thinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thickToolStripMenuItem.Checked = true;
            scene.Thikness = 1;
        }

        private void thickToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            thickToolStripMenuItem.Checked = true;
            scene.Thikness = 3;
        }

        private void positionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene.Positioner=!scene.Positioner;
            positionerToolStripMenuItem.Checked=!positionerToolStripMenuItem.Checked;
        }

        private void positionerToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            scene.Cursor = e.Location;
            Invalidate();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        public void Update()
        {
            toolStripStatusLabel1.Text=String.Format("Active:  {0}",scene.Counter);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Update();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene.Undot();
            Invalidate();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene.Retrot();
            Invalidate();
        }
    }
}
