using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grppersonal_Enter(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                Booking_Details.Items.Clear();
                //creating variables
                String name = textname.Text;
                String roomType = "";
                int age = 0;
                int nights = 0;
                 int guests = 0; 
                //creating constants variables
                const double STANDARD = 50;
                const double NORMAL = 80;
                const double HIGHT = 130;
                const double DISCOUNT_5_9 = 0.05;
                const double DISCOUNT_10 = 0.12;
                const double BREAKFAST_RATE = 10;
                const double SURCHARGE_RATE = 0.05;
                const double SENIOR_DISCOUNT = 0.05;



                //creating variables fro calcualtin
                double discount = 0;
                double surcharge = 0;
                double roomRate = 0;
                int maxguest = 0;
                double breakfast=0;

                //boolean variable
                bool approved = true;


                //validating name input
                if (name == "")
                {
                    MessageBox.Show("Please enter the guest name");
                    approved = false;
                    
                    
                }
                if (approved)
                {
                    //validating numeric inputs
                    if (int.TryParse(textage.Text, out age) && int.TryParse(textnights.Text, out nights) && int.TryParse(textguests.Text, out guests))
                    {
                        //validating the age 
                        if (age >= 18 && age <= 90)
                        {
                            if (age >= 60)
                            {
                                discount += SENIOR_DISCOUNT;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Age must be between 18 and 90");
                            approved = false;
                            ;

                        }
                        if (approved)
                        {
                            //validating number of nights
                            if (nights >= 1 && nights <= 30)
                            {
                                if (nights >= 5 && nights <= 9)
                                {
                                    discount += DISCOUNT_5_9;
                                }
                                else if (nights >= 10)
                                {
                                    discount += DISCOUNT_10;
                                }
                                else
                                {
                                    discount += 0;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Number of nights must be between 1 and 30 ");
                                approved = false;
                            }
                        }
                        if (approved)
                        {
                            //validating number of guests
                            if (guests >= 1 && guests <= 6)
                            {
                                if (guests > 4)
                                {
                                    surcharge = SURCHARGE_RATE;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Number of guests must be between 1 and  6");
                                approved = false;
                            }
                        }
                        if (approved)
                        {
                            //validating room type
                            if (rdonormal.Checked)
                            {
                                roomType = "Normal";
                            }
                            else if (rdostandard.Checked)
                            {
                                roomType = "Standard";
                            }
                            else if (rdohight.Checked)
                            {
                                roomType = "Hight";
                            }
                            else
                            {
                                MessageBox.Show("please select room");
                                approved = false;
                            }
                        }
                        if (approved)
                        {
                            switch (roomType)
                            {
                                case "Standard":
                                    roomRate = STANDARD;
                                    maxguest = 2;
                                    break;
                                case "Normal":
                                    roomRate = NORMAL;
                                    maxguest = 4;
                                    break;
                                case "Hight":
                                    roomRate = HIGHT;
                                    maxguest = 6;
                                    break;
                                default:
                                    MessageBox.Show("please select room");
                                    approved = false;
                                    break;

                            }
                        }

                        if (approved)
                        {
                            if (guests > maxguest)
                            {
                                MessageBox.Show("Maximum guests allowed for this room is : " + maxguest + " only");
                                approved = false;
                            }
                        }

                        //validating check box
                        if (chkoption.Checked)
                        {
                            breakfast = BREAKFAST_RATE * guests * nights;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter numeric integer for the age ,number of nights ,number of guests");
                        approved = false;
                    }
                }
                if (approved)
                {
                    //calculating
                    double basicCost = roomRate * nights;
                    double discountAmount = basicCost * discount;
                    double surchargeamount = basicCost * surcharge;
                    double total = basicCost + surchargeamount - discountAmount + breakfast;

                    //displaying
                    Booking_Details.Items.Add("guest Name : " + name);
                    Booking_Details.Items.Add("guest Age: " + age);
                    Booking_Details.Items.Add("Number Of Nights : " + nights);
                    Booking_Details.Items.Add("Number Of Guests : " + guests);
                    Booking_Details.Items.Add("Room Type : " + roomType);
                    Booking_Details.Items.Add("Basic Cost : " + basicCost.ToString("C"));
                    Booking_Details.Items.Add("Discount : " + discountAmount.ToString("C"));
                    Booking_Details.Items.Add("Surcharge : " + surchargeamount.ToString("C"));
                    Booking_Details.Items.Add("Breakfast Bill : " + breakfast.ToString("C"));
                    Booking_Details.Items.Add("Total Bill : " + total.ToString("C"));
                    Booking_Details.Items.Add("Approved");
                }

            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing text box 
            textname.Clear();
            textage.Clear();
            textguests.Clear();
            textnights.Clear();
            //clearing radio button
            rdohight.Checked = false;
            rdonormal.Checked = false;
            rdostandard.Checked = false;
            //clearing check box
            chkoption.Checked = false;
            //clearing list box
            Booking_Details.Items.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
