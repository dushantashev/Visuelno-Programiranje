using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                return;
            }

            DialogResult dg = MessageBox.Show("Dali si siguren", "Siguren li si bre?", MessageBoxButtons.OKCancel);
            if (dg == DialogResult.OK)
            {
                int selectedIndex = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(selectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!= -1)
            {
                Form3 form3 = new Form3();
                if(form3.ShowDialog()== DialogResult.OK)
                {
                   Airport SelectedAirport = listBox1.Items[listBox1.SelectedIndex] as Airport;
                    SelectedAirport.Destinacions.Add(form3.CreatedDestination);
                    if (listBox1.SelectedItem != null)
                    {
                        LoadDestinacion();
                    }
                    
                }
            }
          

            

            

           /*int max = 0;
            int index = 0;
            int vkupnoKm = 0;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                Destinacion destnacija = listBox2.Items[i] as Destinacion;
                vkupnoKm += destnacija.Odalechenost;
                if (destnacija.cena > max)
                {
                   
                    max = destnacija.cena;
                    index = i;


                }

            }
            Destinacion najskapaDestinacija = listBox2.Items[index] as Destinacion;
            textBox1.Text = najskapaDestinacija.ImeNaDestinacija + "\t" + najskapaDestinacija.Odalechenost + " - " + najskapaDestinacija.cena;
            textBox2.Text = ((int)vkupnoKm / (int)listBox2.Items.Count).ToString();
        */
        
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

        if(form2.ShowDialog()== DialogResult.OK)
            {
                listBox1.Items.Add(form2.CreatedAirport);
                
            }
        }
        private void LoadDestinacion()
        {
            
            Airport SelectedAirport= listBox1.Items[listBox1.SelectedIndex] as Airport;
            foreach(Destinacion destinacion in SelectedAirport.Destinacions)
            {
                listBox2.Items.Add(destinacion);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {


                LoadDestinacion();
            }
        }
    }
}
