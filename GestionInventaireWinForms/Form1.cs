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

        Double packblanc;
        Double packrouge;
        Double packrose;
        Double packbulle;
        Double packdigestif;

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

            pricetotal_1.Text = "0";
            pricetotal_2.Text = "0";
            pricetotal_3.Text = "0";
            pricetotal_4.Text = "0";
            pricetotal_5.Text = "0";

            subtotalorder.Text = "0";
            tax.Text = "0";
            totalorder.Text = "0";


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
            textBox1.Text = "";

            pricebox_1.Text = "0";
            pricebox_2.Text = "0";
            pricebox_3.Text = "0";
            pricebox_4.Text = "0";
            pricebox_5.Text = "0";

            pricetotal_1.Text = "0";
            pricetotal_2.Text = "0";
            pricetotal_3.Text = "0";
            pricetotal_4.Text = "0";
            pricetotal_5.Text = "0";

            subtotalorder.Text = "0";
            tax.Text = "0";
            totalorder.Text = "0";

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
            textBox1.AppendText(Environment.NewLine + "Date commande:" + "\t" + dateorder.Text + "\t\t" + "Heure commande: " + "\t" + Timeorder.Text + Environment.NewLine);

            textBox1.AppendText(Environment.NewLine + "Article " + "\t\t" + "Quantité " + "\t\t" + "Prix unitaire" + "\t" + "Prix Carton" + "\t" + "Sous-total" + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Vin rouge: " + "\t" + qty_1.Text + "\t\t" + price_1.Text + "\t\t" + pricebox_1.Text + "\t\t" + pricetotal_1.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Vin blanc: " + "\t" + qty_2.Text + "\t\t" + price_2.Text + "\t\t" + pricebox_2.Text + "\t\t" + pricetotal_2.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Vin rosé: " + "\t\t" + qty_3.Text + "\t\t" + price_3.Text + "\t\t" + pricebox_3.Text + "\t\t" + pricetotal_3.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Pétillant: " + "\t\t" + qty_4.Text + "\t\t" + price_4.Text + "\t\t" + pricebox_4.Text + "\t\t" + pricetotal_4.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Digestif: " + "\t\t" + qty_5.Text + "\t\t" + price_5.Text + "\t\t" + pricebox_5.Text + "\t\t" + pricetotal_5.Text + Environment.NewLine);

            textBox1.AppendText(Environment.NewLine + "Sous-total commande: " + "\t" + subtotalorder.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Taxe: " + "\t" + tax.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Total: " + "\t" + totalorder.Text + Environment.NewLine);

            textBox1.AppendText("\t\t\t" + "=========================================================================== " + Environment.NewLine);
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

        private void total_Click(object sender, EventArgs e)
        {
            Double vinRouge;
            Double vinBlanc;
            Double vinRose;
            Double petillant;
            Double dig;

            Double unitprice1;
            Double unitprice2;
            Double unitprice3;
            Double unitprice4;
            Double unitprice5;

            Double packprice1;
            Double packprice2;
            Double packprice3;
            Double packprice4;
            Double packprice5;

            Double NetTax;
            Double SubTotal;
            Double NetTotal;

            vinRouge = Double.Parse(qty_1.Text);
            vinBlanc = Double.Parse(qty_2.Text);
            vinRose = Double.Parse(qty_3.Text);
            petillant = Double.Parse(qty_4.Text);
            dig = Double.Parse(qty_5.Text);

            unitprice1 = Double.Parse(price_1.Text);
            unitprice2 = Double.Parse(price_2.Text);
            unitprice3 = Double.Parse(price_3.Text);
            unitprice4 = Double.Parse(price_4.Text);
            unitprice5 = Double.Parse(price_5.Text);

            rouge = vinRouge * unitprice1;
            blanc = vinBlanc * unitprice2;
            rose = vinRose * unitprice3;
            bulle = petillant * unitprice4;
            digestif = dig * unitprice5;

            packprice1 = Double.Parse(pricebox_1.Text);
            packprice2 = Double.Parse(pricebox_2.Text);
            packprice3 = Double.Parse(pricebox_3.Text);
            packprice4 = Double.Parse(pricebox_4.Text);
            packprice5 = Double.Parse(pricebox_5.Text);

            packrouge = vinRouge * packprice1;
            packblanc = vinRouge * packprice2;
            packrose = vinRouge * packprice3;
            packbulle = vinRouge * packprice4;
            packdigestif = vinRouge * packprice5;

            pricetotal_1.Text = System.Convert.ToString(rouge);
            pricetotal_2.Text = System.Convert.ToString(blanc);
            pricetotal_3.Text = System.Convert.ToString(rose);
            pricetotal_4.Text = System.Convert.ToString(bulle);
            pricetotal_5.Text = System.Convert.ToString(digestif);

            /*pricetotal_1.Text = System.Convert.ToString(packrouge);
            pricetotal_2.Text = System.Convert.ToString(packblanc);
            pricetotal_3.Text = System.Convert.ToString(packrose);
            pricetotal_4.Text = System.Convert.ToString(packbulle);
            pricetotal_5.Text = System.Convert.ToString(packdigestif);*/

            subtotalorder.Text = System.Convert.ToString(rouge + blanc + rose + bulle + digestif);
            NetTax = ((rouge + blanc + rose + bulle + digestif) * iTax) / 100;
            tax.Text = System.Convert.ToString(NetTax);
            totalorder.Text = System.Convert.ToString(NetTax + (rouge + blanc + rose + bulle + digestif));



            price_1.Text = String.Format("{0:C}", Double.Parse(price_1.Text));
            price_2.Text = String.Format("{0:C}", Double.Parse(price_2.Text));
            price_3.Text = String.Format("{0:C}", Double.Parse(price_3.Text));
            price_4.Text = String.Format("{0:C}", Double.Parse(price_4.Text));
            price_5.Text = String.Format("{0:C}", Double.Parse(price_5.Text));

            pricebox_1.Text = String.Format("{0:C}", Double.Parse(pricebox_1.Text));
            pricebox_2.Text = String.Format("{0:C}", Double.Parse(pricebox_2.Text));
            pricebox_3.Text = String.Format("{0:C}", Double.Parse(pricebox_3.Text));
            pricebox_4.Text = String.Format("{0:C}", Double.Parse(pricebox_4.Text));
            pricebox_5.Text = String.Format("{0:C}", Double.Parse(pricebox_5.Text));

            pricetotal_1.Text = String.Format("{0:C}", Double.Parse(pricetotal_1.Text));
            pricetotal_2.Text = String.Format("{0:C}", Double.Parse(pricetotal_2.Text));
            pricetotal_3.Text = String.Format("{0:C}", Double.Parse(pricetotal_3.Text));
            pricetotal_4.Text = String.Format("{0:C}", Double.Parse(pricetotal_4.Text));
            pricetotal_5.Text = String.Format("{0:C}", Double.Parse(pricetotal_5.Text));

            subtotalorder.Text = String.Format("{0:C}", Double.Parse(subtotalorder.Text));
            tax.Text = String.Format("{0:C}", Double.Parse(tax.Text));
            totalorder.Text = String.Format("{0:C}", Double.Parse(totalorder.Text));

            int num2;
            Random rand = new Random();
            num2 = rand.Next(1, 32665);
            reference.Text = Convert.ToString(num2);
        }

        private void btnopsconvert_Click(object sender, EventArgs e)
        {

            Double euro = Double.Parse(textBox2.Text);

            if (cmbconvert.Text == "Dollar")
            {
                label18.Text = System.Convert.ToString((euro * US_Dollar));
            }
        }

        private void btninvent_Click(object sender, EventArgs e)
        {
            Inventory Inventory = new Inventory();
            Inventory.Show();
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

        private void dateorder_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

