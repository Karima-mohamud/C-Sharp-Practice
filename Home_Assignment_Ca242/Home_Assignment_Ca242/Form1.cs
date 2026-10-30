using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Assignment_Ca242
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //stage  1=  input
            //Creating Variables
            String dayOfWeek, Name_of_month,  full_Date;
            int Numeric_day, Year;

            //initial values to variable
            dayOfWeek = textdayofthewek.Text;
            Name_of_month = textdayofthemonth.Text;
             Numeric_day = int.Parse(textmonth.Text);
            Year = int.Parse(textyear.Text);

            //stage 2 = process - concatination of full date
            full_Date =dayOfWeek + ","+Name_of_month +","+
                Numeric_day + ","+Year;


            //Stage 3 = The output using label 
             lbloutput.Text = full_Date;




        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing textbox and label
            //clearing textbox
            textdayofthewek.Clear();
            textmonth.Text = "";
            textdayofthemonth.Text = String.Empty;
            textyear.Clear();
            //clearing label
            //clearing label  -not used clear function
            lbloutput.Text = "";
            //lbloutput.Text =String.Empty;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
