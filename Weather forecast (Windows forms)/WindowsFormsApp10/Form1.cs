using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2cs form2 = new Form2cs();
            if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                listBox1.Items.Add(form2.data);
                update();
                changeTemp();

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            update();
            changeTemp();
        }

        public void update()
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                Datum datum = listBox1.SelectedItem as Datum;

                // Креирајте копија од листата на температури за избраната дата
                List<Temperatura> tempToRemove = new List<Temperatura>(datum.Temperatura);

                // Избришете ги сите елементи од првобитната листа
                foreach (Temperatura temp in tempToRemove)
                {
                    datum.Temperatura.Remove(temp);
                }

                // Додајте нова температура во листата за избраната дата
                datum.addTemp(new Temperatura((int)numericUpDown1.Value, (int)numericUpDown2.Value));

                // Променете го текстот на textBox3 на индексот на избраната ставка во listBox1
                Datum datum1 = listBox1.SelectedItem as Datum;
                textBox3.Text = datum1.ToString();
            }
        }


        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            update();
            changeTemp();
        }
        public void changeTemp()
        {
            int maxTemp = 0;
            int indexOfMaxTemp = 0;
            int minTemp = 100000;
            int indexOfMinTemp = 0;
            for (int i= 0;i < listBox1.Items.Count;i++)
            {
                Datum datum = listBox1.Items[i] as Datum;


              foreach(Temperatura temperatura in datum.Temperatura)
                {
                    if (temperatura.maksimalnaTemperatura > maxTemp)
                    {
                        maxTemp = temperatura.maksimalnaTemperatura;
                        indexOfMaxTemp = i;
                 
                    }
                    if (temperatura.minimalnaTemperatura < minTemp)
                    {
                        minTemp = temperatura.minimalnaTemperatura;
                        indexOfMinTemp = i;
                    }
                }
            }
            Datum MaxTemp = listBox1.Items[indexOfMaxTemp] as Datum;
            Datum MinTemp = listBox1.Items[indexOfMinTemp] as Datum;

            textBox1.Text= maxTemp.ToString();
            textBox2.Text= minTemp.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            update();
            changeTemp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count > 0)
            {
               
                listBox1.Items.Remove(listBox1.SelectedItem);
                
                if (listBox1.Items.Count > 2)
                {
                    //update();
                    //();
                }
            }
        }
    }
}
