using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodCharge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                //creating variables for input
                String food1, food2;
                double price1, price2;
                //Initializing the variables
                food1 = textfood1.Text;
                food2 = textfood2.Text;
                price1 = double.Parse(textprice1.Text);
                price2 = double.Parse(textprice2.Text);
                //creating constant variable for tax
                const double TAX_RATE = 0.07;
                // calculating
                //creating variable and initialize for the amount
                double amount = price1 + price2;
                //creating variable and initialize for tax
                double tax = amount * TAX_RATE;
                //creating variable and initialize for the total
                double total = amount + tax;
                //displaying the output
                lblsalestax.Text = tax.ToString("C");
                lbltotal.Text = total.ToString("C");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input");
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing the textbox
            textfood1.Clear();
            textfood2.Clear();
            textprice1.Clear();
            textprice2.Clear();
            //clearing the label
            lbltotal.Text = "";
            lblsalestax.Text = "";
        }
    }
}
