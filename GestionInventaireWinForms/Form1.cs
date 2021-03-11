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
    public partial class Form1 : Form
    {
        String operation;
        Double firstnum;
        Double secondnum;
        Double answer;
        Double iTax = 17.5;

        Double blanc;
        Double rouge;
        Double rose;
        Double bulle;
        Double digestif;

        Double US_Dollar = 1.19;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbconvert.Text = "Choississez une monnaie";
            cmbconvert.Items.Add("Dollar");

            DateTime iDate = DateTime.Now;
            dateorder.Text = iDate.ToString("dd/MM/yy");
            Timeorder.Text = iDate.ToString("HH:mm:ss");

            qty_1.Text = "0";
            qty_2.Text = "0";
            qty_3.Text = "0";
            qty_4.Text = "0";
            qty_5.Text = "0";

            price_1.Text = "0";
            price_2.Text = "0";
            price_3.Text = "0";
            price_4.Text = "0";
            price_5.Text = "0";

            pricebox_1.Text = "0";
            pricebox_2.Text = "0";
            pricebox_3.Text = "0";
            pricebox_4.Text = "0";
            pricebox_5.Text = "0";

            pricetotal_1.Text = "";
            pricetotal_2.Text = "";
            pricetotal_3.Text = "";
            pricetotal_4.Text = "";
            pricetotal_5.Text = "";




        }

        private void Click_Button(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (Display.Text == "0")
                Display.Text = num.Text;
            else
                Display.Text = Display.Text + num.Text;

        }
        private void Calc_operator(object sender, EventArgs e)
        {
            Button ops = (Button)sender;
            firstnum = Double.Parse(Display.Text);
            Display.Text = "";
            operation = ops.Text;
            showops.Text = System.Convert.ToString(firstnum) + " " + operation;
        }
 
        private void btndot_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!Display.Text.Contains("."))
                    Display.Text = Display.Text + num.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            showops.Text = "";
            Display.Text = "0";
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            showops.Text = "";
            secondnum = Double.Parse(Display.Text);
            switch (operation)
            {
                case "+":
                    answer = (firstnum + secondnum);
                    Display.Text = System.Convert.ToString(answer);
                    break;
                case "-":
                    answer = (firstnum - secondnum);
                    Display.Text = System.Convert.ToString(answer);
                    break;
                case "*":
                    answer = (firstnum * secondnum);
                    Display.Text = System.Convert.ToString(answer);
                    break;
                case "/":
                    answer = (firstnum / secondnum);
                    Display.Text = System.Convert.ToString(answer);
                    break;
                default:
                    break;
            }
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            if (Display.Text.Length > 0)
                Display.Text = Display.Text.Remove(Display.Text.Length - 1, 1);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            qty_1.Text = "0";
            qty_2.Text = "0";
            qty_3.Text = "0";
            qty_4.Text = "0";
            qty_5.Text = "0";

            price_1.Text = "0";
            price_2.Text = "0";
            price_3.Text = "0";
            price_4.Text = "0";
            price_5.Text = "0";

            pricebox_1.Text = "0";
            pricebox_2.Text = "0";
            pricebox_3.Text = "0";
            pricebox_4.Text = "0";
            pricebox_5.Text = "0";

            pricetotal_1.Text = "";
            pricetotal_2.Text = "";
            pricetotal_3.Text = "";
            pricetotal_4.Text = "";
            pricetotal_5.Text = "";

            subtotalorder.Text = "";
            tax.Text = "";
            totalorder.Text = "";

            fournisseur_name.Text = "";
            fournisseur_tel.Text = "";
            fournisseur_mail.Text = "";
        }

        private void addtoshop_click(object sender, EventArgs e)
        {
            tabcontrol_1.SelectedTab = tabPage2;

            textBox1.AppendText(" " + Environment.NewLine);
            textBox1.AppendText("\t\t\t" + "     COMMANDE EN LIGNE");
            textBox1.AppendText("\t\t\t" + "=========================================================================== " + Environment.NewLine);
            textBox1.AppendText(" " + Environment.NewLine);

            textBox1.AppendText("Nom:" + "\t" + fournisseur_name.Text + "\t" + "tel fournisseur:" + fournisseur_tel.Text + "\t" + "Mail fournisseur:" + fournisseur_mail.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Date commande:" + "\t" + dateorder.Text + "\t" + "Heure commande: " + "\t" + Timeorder.Text + Environment.NewLine);

            textBox1.AppendText(Environment.NewLine + "Article: " + "\t" + "Quantité " + "\t" + "Prix unitaire" + "\t" + "Prix Carton" + "\t" + "Sous-total" + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Vin rouge: " + "\t" + qty_1.Text + "\t" + price_1.Text + "\t" + pricebox_1.Text + "\t" + pricetotal_1.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Vin blanc: " + "\t" + qty_2.Text + "\t" + price_2.Text + "\t" + pricebox_2.Text + "\t" + pricetotal_2.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Vin rosé: " + "\t" + qty_3.Text + "\t" + price_3.Text + "\t" + pricebox_3.Text + "\t" + pricetotal_3.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Pétillant: " + "\t" + qty_4.Text + "\t" + price_4.Text + "\t" + pricebox_4.Text + "\t" + pricetotal_4.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Digestif: " + "\t" + qty_5.Text + "\t" + price_5.Text + "\t" + pricebox_5.Text + "\t" + pricetotal_5.Text + Environment.NewLine);

            textBox1.AppendText(Environment.NewLine + "Sous-total commande: " + "\t" + subtotalorder.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Taxe: " + "\t" + tax.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Total: " + "\t" + totalorder.Text + Environment.NewLine);

            textBox1.AppendText("\t\t\t" + "============================================================ " + Environment.NewLine);
            textBox1.AppendText("\t\t\t" + "     RECU DE LA COMMANDE" + Environment.NewLine);

        }

        private void order_click(object sender, EventArgs e)
        {
            tabcontrol_1.SelectedTab = tabPage3;
        }

        private void receipt_click(object sender, EventArgs e)
        {
            tabcontrol_1.SelectedTab = tabPage2;
        }

        private void calc_Click(object sender, EventArgs e)
        {
            tabcontrol_1.SelectedTab = tabPage1;
        }

        private void convertisseurDeDevisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnconvert.Visible = false;
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            btnconvert.Visible = false;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnconvert.Visible = true;
        }

        private void btnopsclose_Click(object sender, EventArgs e)
        {
            btnconvert.Visible = true;
        }

        private void save_click(object sender, EventArgs e)
        {
            DateTime iDate = DateTime.Now;
            dateorder.Text = iDate.ToString("dd/MM/yy");
            Timeorder.Text = iDate.ToString("HH:mm:ss");

            tabcontrol_1.SelectedTab = tabPage3;
            this.Validate();
            //this.order_SystemsBindingSource.EndEdit();  lien table bdd
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Display_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }


        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateorder_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

