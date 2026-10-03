using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_With_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblgrosspay_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //creating variables
                double hoursworked, hourlyPayRate, gross;
                //creating constant variable for over time rate
                const double OVERTIME_RATE = 1.5;
                //validating the input
                if (double.TryParse(texthoursworked.Text, out hoursworked) && hoursworked >=0)
                {
                    if (double.TryParse(texthourpayrate.Text, out hourlyPayRate) && hourlyPayRate >=0)
                    {
                        //validating the gross pay using if and else statement 
                        if (hoursworked <= 50)
                        {
                            gross = hoursworked * hourlyPayRate;
                        }
                        else
                        {
                            double overtime = hoursworked - 50;
                            gross = (50 * hourlyPayRate) + (overtime * hourlyPayRate * OVERTIME_RATE);
                        }
                        //displaying the output

                        lblgrosspay.Text = gross.ToString("C");
                    }
                    else
                    {

                        MessageBox.Show("invalid hourly pay rate ");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid hours worked ");
                }
            }
            //dispalying default error message
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing text box 
            texthoursworked.Clear();
            texthourpayrate.Clear();
            //clearing label
            lblgrosspay.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closing the program
            this.Close();
        }
    }
}
