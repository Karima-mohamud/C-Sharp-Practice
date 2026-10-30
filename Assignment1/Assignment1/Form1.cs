using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void lblstudentid_Click(object sender, EventArgs e)
        {

        }

        private void lbldeparmnet_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //input creating variables
            String Sname, department, semester; 
             int sID;
            
            //initial values to variables
            Sname = textname.Text;
            sID = int.Parse(textstudentid.Text);
            department = textdepartment.Text;
            semester = textsemester.Text;

            //process
            String fullinfo;
            fullinfo = "Name : " + Sname + " ID : " + sID +
                "  Department : " + department 
                + "  semester : " + semester;
            // output
            lbloutput.Text = fullinfo;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing textboxes
            textname.Clear();
            textstudentid.Clear();
            textdepartment.Text = "";
            textsemester.Text = String.Empty;

            //clearing label
            lbloutput.Text = "";
            
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void textstudentid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
