using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbldiscountshow_Click(object sender, EventArgs e)
        {

        }

        private void lbltaxshow_Click(object sender, EventArgs e)
        {


        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //creating variables for input
                String name, room;
                double price;
                int night;
                //initializing variables
                name = textcustomer.Text;
                room = textroom.Text;
                night = int.Parse(textnight.Text);
                price = double.Parse(textprice.Text);
                // creating constant variables
                const double SERVICE_TAX = 0.1;
                const double DISCOUNT_RATE = 0.05;
                //Calculating the amount
                double amount = price * night;
                double stax = amount * SERVICE_TAX;
                double discount = DISCOUNT_RATE * amount;
                double total = amount + stax - discount;
                //displaying the result
                lbltax.Text = stax.ToString("C");
                lbldiscount.Text = discount.ToString("C");
                lbltotalamount.Text = total.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input");
            }



        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing text box
            textcustomer.Clear();
            textroom.Clear();
            textnight.Clear();
            textprice.Clear();
            //clearing labels
            lbltax.Text = "";
            lbldiscount.Text = "";
            lbltotalamount.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //closing the program
            this.Close();
        }
    }
}
