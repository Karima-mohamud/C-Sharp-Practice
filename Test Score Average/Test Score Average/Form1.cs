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
            try
            {
                //creating constant for high score
                const double HIGH_SCORE = 95;
                //CREATING VARIABLES
                double test1, test2, test3, total, average;
                //initializing variables
                test1 = double.Parse(textScore1.Text);
                test2 = double.Parse(textscore2.Text);
                test3 = double.Parse(textScore3.Text);
                //calculatingthe total
                total = test1 + test2 + test3;
                //calculating the average
                average = total / 3.0;
                //dispalying the output
                lblaverage.Text = average.ToString("n1");
                //using if  to validate the score
                if (average > HIGH_SCORE)
                {
                    MessageBox.Show("Congratulation");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
