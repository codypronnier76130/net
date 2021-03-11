using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventaireWinForms
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }
        

        private void Inventory_Load(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            int quantity;
            Int32.TryParse(textBox1.Text, out quantity);
            if (quantity > 0)
            {
                MessageBox.Show("En stock : " + quantity);
            }
            else
            {
                MessageBox.Show("En Rupture");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int quantity;
            Int32.TryParse(textBox2.Text, out quantity);
            if (quantity > 0)
            {
                MessageBox.Show("En stock : " + quantity);
            }
            else
            {
                MessageBox.Show("En Rupture");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int quantity;
            Int32.TryParse(textBox3.Text, out quantity);
            if (quantity > 0)
            {
                MessageBox.Show("En stock : " + quantity);
            }
            else
            {
                MessageBox.Show("En Rupture");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int quantity;
            Int32.TryParse(textBox4.Text, out quantity);
            if (quantity > 0)
            {
                MessageBox.Show("En stock : " + quantity);
            }
            else
            {
                MessageBox.Show("En Rupture");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int quantity;
            Int32.TryParse(textBox5.Text, out quantity);
            if (quantity > 0)
            {
                MessageBox.Show("En stock : " + quantity);
            }
            else
            {
                MessageBox.Show("En Rupture");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int stock;
            Int32.TryParse(textBox1.Text, out stock);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
