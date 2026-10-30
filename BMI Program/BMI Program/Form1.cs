using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }

        private void lblweight_Click(object sender, EventArgs e)
        {

        }

        private void btncalcualte_Click(object sender, EventArgs e)
        {
            try
            {
                //creating variables
                double weight = 0;
                double height = 0;
                double BMI = 0;
                String category = "";
                //Validating inputs
                if(double.TryParse(textweight.Text, out weight) && double.TryParse(textheight.Text,out height))
                {
                    
                   
                   
                        //validating negative input
                        if (weight > 0 && height > 0)
                        {
                            //calculating
                            BMI = weight  / (height * height);
                            
                            if(BMI < 18.5)
                            {
                                category ="You Are Under weight";
                            }
                            else if(BMI >=18.5 &&BMI <= 25) {
                                category = "You Are Optimal Weight";
                                    }
                            else if(BMI > 25)
                            {
                                category ="You Are Over Weight";
                            }
                        

                    }
                        else
                        {
                            MessageBox.Show("Invalid input  ,weight and height must be positive value");
                        }
                    }
                
                else
                {
                    MessageBox.Show("Invalid inputs please enter a numeric value");
                }
                //displaying
                Result.Items.Add("Weight : " + weight);
                Result.Items.Add("Height: " + height);
                Result.Items.Add("Your BMI is  : " + BMI.ToString("f2"));
                Result.Items.Add("Category  : " + category);







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing text box
            textheight.Clear();
            textweight.Clear();
            //clearing list box
            Result.Items.Clear();

        }
    }
}
