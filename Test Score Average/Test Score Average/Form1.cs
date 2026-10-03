using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            
                //creating constant for high score
                const double HIGH_SCORE = 95;
                //CREATING VARIABLES
                double test1, test2, test3, total, average;
                //initializing variables and preventing data conversion exception
                if (double.TryParse(textScore1.Text, out test1) &&
                    double.TryParse(textscore2.Text, out test2) &&
                    double.TryParse(textScore3.Text, out test3))
                {


                    //calculatingthe total
                    total = test1 + test2 + test3;
                //calculating the average
                average = total / 3.0;
                //dispalying the output
                lblaverage.Text = average.ToString("n1");
                //using if  to validate the score
                if (average >= HIGH_SCORE)
                {
                    MessageBox.Show("Congratulation your average is higher than 95");
                }
                else if (average >= 80)
                    {
                        MessageBox.Show("Very Good");
                    }
                else if (average >= 70)
                    {
                        MessageBox.Show("Good");
                    }
                else if (average >= 60)
                    {
                        MessageBox.Show("You Passed");
                    }
                 else
                    {
                        MessageBox.Show("You Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid numbers.");
                }


            
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing textbox
            textScore1.Clear();
            textscore2.Clear();
            textScore3.Clear();
            //clearing label
            lblaverage.Text = "";

        }
    }
}
