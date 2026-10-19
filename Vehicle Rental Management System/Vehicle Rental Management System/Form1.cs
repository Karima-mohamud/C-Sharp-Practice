using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                listResults.Items.Clear();
                //creating and initilizing variable name 
                String cName = textname.Text;
                String vehivleType = "";
                //creating variables for input
                int age;
                int rentalDays = 0;
                double years;
                //declaring and  initializing variables for calculating
                double rentcost = 0;
                double discount = 0;
                double surcharge = 0;
                double insurancetotal = 0;

                // Creating rate and discounts
                const int ECONOMY = 35;
                const int SUV = 60;
                const int LUXURY = 100;
                const double DISCOUNT_RENT_DAYS = 0.05;
                const double DISCOUNT_DAYS = 0.1;
                const double INSURANCE_RATE = 15; 
                const double SURCHARGE_RATE = 0.1;

                // Validating numeric inputs 
                if (int.TryParse(textage.Text, out age) &&
                    int.TryParse(textrentaldays.Text, out rentalDays) &&
                    double.TryParse(textexperience.Text, out years))
                {
                    if(cName == "")
                    {
                        MessageBox.Show("Please Enter The Custmer Name ");
                        
                    }

                    // 1. Validate Age Range 
                    if (age >= 18 && age <= 80)
                    {
                        // Customers below 21 years are not eligible
                        if (age < 21)
                        {
                            MessageBox.Show("Customers below 21 years are not eligible to rent.");
                            
                        }
                        // Age 21-24 young-driver surcharge validation
                        else if (age >= 21 && age <= 24)
                        {
                            surcharge = SURCHARGE_RATE;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Customer age must be between 18 and 80 years.");
                        
                    }

                    // 2. Validation Of Rental Days
                    if (rentalDays >= 1 && rentalDays <= 30)
                    {
                        //validating the discount
                        if (rentalDays >= 7 && rentalDays <= 13)
                        {
                            discount = DISCOUNT_RENT_DAYS;
                        }
                        else if (rentalDays >= 14)
                        {
                            discount = DISCOUNT_DAYS;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rental days must be between 1 and 30 days.");
                        
                        
                    }

                    // 3. Validate Driving Experience 
                    if (years < 0)
                    {
                        MessageBox.Show("Driving years of experience cannot be negative.");
                        
                    }
                    else if (years < 1)
                    {
                        MessageBox.Show("Customers must have at least 1 year of driving experience.");
                    }

                    // Vehicle type validation
                    if (rdoeconomy.Checked)
                    {
                        vehivleType = "Economy";
                        rentcost = ECONOMY;
                    }
                    else if (rdosuv.Checked)
                    {
                        vehivleType = "SUV";
                        rentcost = SUV;
                    }
                    else if (rdoluxury.Checked)
                    {
                        // Luxury vehicle validation
                        if (age >= 25 && years >= 3)
                        {
                            vehivleType = "luxury";
                            rentcost = LUXURY;
                        }
                        else
                        {
                            MessageBox.Show("Luxury vehicles require at least 25 years of age and 3 years of driving experience.");
                            
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose a vehicle type");
                    }

                    // insurance validaton
                    if (chkinsurance.Checked)
                    {
                        insurancetotal = INSURANCE_RATE * rentalDays;
                    }

                    // Caalculating cost
                    double basicRentalCost = rentcost * rentalDays;
                    double discountAmount = basicRentalCost * discount;
                    double costAfterDiscount = basicRentalCost - discountAmount;
                    double surchargeAmount = basicRentalCost* surcharge;

                    double finalTotal = costAfterDiscount + surchargeAmount + insurancetotal;

                    //Displaying result in list box
                    listResults.Items.Add("Rental Detials");
                    listResults.Items.Add("---------------------------------------------------");
                    listResults.Items.Add("Customer Name : " + cName);
                    listResults.Items.Add("Customer Age : "+age);
                    listResults.Items.Add("Customer Driving Experience : " +years+" Years");
                    listResults.Items.Add("Vehicle Type : " +vehivleType );
                    listResults.Items.Add("Daily Rate : " +rentcost.ToString("c"));
                    listResults.Items.Add("Rental Days: " + rentalDays);
                    listResults.Items.Add("Basic Rental Cost : " +basicRentalCost.ToString("c"));
                    listResults.Items.Add("Discount : " + discountAmount.ToString("c"));
                    listResults.Items.Add("Insurance Cost  : " + insurancetotal.ToString("c"));
                    listResults.Items.Add("young Driver Surcharge : " + surchargeAmount.ToString("c"));
                    listResults.Items.Add("Final Rental Cost : " + finalTotal.ToString("c"));
                    listResults.Items.Add("---------------------------------------------------");
                    listResults.Items.Add("Rental Status : Approved ");
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter valid numeric data for age, days, experience");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clearing text boxes
            textname.Clear();
            textage.Clear();
            textrentaldays.Clear();
            textexperience.Clear();

            // Clearing list
            listResults.Items.Clear();
            //clearing radio buttons
            rdoeconomy.Checked = false;
            rdosuv.Checked = false;
            rdoluxury.Checked = false;
            //clearing checkbox
            chkinsurance.Checked = false;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closing the program
            this.Close();
        }

        private void lblnamevhicleshow_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {













        }

        private void rdosuv_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}