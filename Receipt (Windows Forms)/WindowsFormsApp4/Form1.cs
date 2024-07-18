using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(form2.Product);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = listBox1.SelectedItem as Product;
            
            int quantity = (int)numericUpDown1.Value;

            Kasa kasa = new Kasa();

            kasa.AddItem(product, quantity);
            listBox2.Items.Add(product.Name+" "+ product.Price+" "+ "X"+quantity+" = "+ quantity*product.Price+".00");
            float suma;
            float.TryParse(textBox1.Text, out suma);
            suma += (float)(product.Price * quantity);
            textBox1.Text=suma.ToString();
            zaPlakjanje();


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            zaPlakjanje();
        }
        private void zaPlakjanje()
        {
            float suma;
            float.TryParse(textBox1.Text, out suma);
            float danok = 100-(float)numericUpDown2.Value;
            textBox2.Text = (suma/100 * danok).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {

                int index = listBox2.SelectedIndex;
              
                Kasa kasa = new Kasa();
                Product product= listBox2.SelectedItem as Product;
               int quantity= kasa.GetQuantityForProduct(product)
                  listBox2.Items.RemoveAt(index);
                float suma;
                float.TryParse(textBox1.Text, out suma);
               

                suma -= (float)(product.Price*quantity);
                textBox2.Text=quantity.ToString();
            }
        }
    }
}
