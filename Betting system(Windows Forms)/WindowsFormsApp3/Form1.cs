using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
Form2 teamForm = new Form2();
            DialogResult result = teamForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                listBox1.Items.Add(teamForm.CreatedTeam);
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count == 2)
            {
                Team team1 = listBox1.SelectedItems[0] as Team;
                Team team2 = listBox1.SelectedItems[1] as Team;
                if(team1.Country!= team2.Country)
                {
                    MessageBox.Show("Razlicna drzava");
                }
                else
                {
                    Game game= new Game(textBox2.Text, team1,team2, numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value);
                    listBox2.Items.Add(game);
                    listBox1.Items.Remove(team1);
                    listBox1.Items.Remove(team2);
                }
            }
            else
            {
                MessageBox.Show("ne se dve tima");
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox2.SelectedItems.Clear();
            String Valuee=textBox1.Text as String;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                Game game = listBox2.Items[i] as Game;

                if (game.Code == Valuee)
                {
                    listBox2.SelectedIndex= i;
                    break;
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  Team s= new Team();
            s.Name = "Barcelona";
            s.Country = "Spain";
            Team s1=new Team();
            s1.Name = "Real Madrid";
            s1.Country = "Spain";
            listBox1.Items.Add(s);
            listBox1.Items.Add(s1);*/
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       /* private decimal calculatorr()
        {
            decimal product = 1;
            for(int i=0;i<listBox3.Items.Count;i++)
            {
               
                Game game = listBox3.Items[i] as Game;
                product*=()
            }

        }*/
        private void button4_Click(object sender, EventArgs e)
        {
            for(int i=0;i<listBox2.SelectedItems.Count;i++)
            {
                Game game= listBox2.SelectedItems[i] as Game;
                String valuee=comboBox1.Text as String;

                GameForTicket ticket = new GameForTicket(game, valuee);
                listBox3.Items.Add(ticket);
                float vrednost;
                float.TryParse(textBox3.Text, out vrednost);
                if (valuee == "X")
                    vrednost *= (float)game.CoefX;
                else if (valuee.Equals("1"))
                {
                    vrednost *= (float)game.Coef1;
                }
                else
                {
                    vrednost *= (float)game.Coef2;
                }
               textBox3.Text=vrednost.ToString();

                
                    break;

            }
          
          
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            float uplata = (float)numericUpDown4.Value;
            float kvota;
            float.TryParse(textBox3.Text, out kvota);

            textBox4.Text = (kvota * uplata).ToString();
        }
    }
}
