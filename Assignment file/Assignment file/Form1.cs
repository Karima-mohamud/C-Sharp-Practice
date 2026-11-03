using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Append_Click(object sender, EventArgs e)
        {
            //importing class
            StreamWriter appends;
            appends = File.AppendText("Info.txt");
            appends.WriteLine("Student name : Karima");
            appends.WriteLine("ID :  C1240104");
            //closing
            appends.Close();
            MessageBox.Show("Added Succesfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //importing class
            StreamReader readtoend;
            readtoend = File.OpenText("Info.txt");
            //reading
            string lines;
            lines = readtoend.ReadToEnd();
            //displaying
            Result.Items.Add(lines);
            //closing
            readtoend.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            



        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            //importing class
            StreamWriter create;
            create = File.CreateText("Info.txt");
            //writing
            create.Write("Welcome to c#");
            create.Write("C# is hard  programming language");
            create.Write("C# is hard language");
            //closing
            create.Close();
            //diplaying message
            MessageBox.Show("File created successfully");
            
        }

        private void btnpath_Click(object sender, EventArgs e)
        {
            //importing class
            StreamWriter path;
            //creating file usong path
            path = File.CreateText(@"C:\Users\SMRC\OneDrive\Documents\info2.txt\information.txt");
            //writing
            path.WriteLine("Welcome to c#");
            path.WriteLine("C# is hard  programming language");
            path.WriteLine("C# is hard language");
            //closing
           path.Close();
            //diplaying message
            MessageBox.Show("File created successfully");

        }

        private void btnreadline_Click(object sender, EventArgs e)
        {
            //importing class 
            StreamReader reading;
            reading = File.OpenText(@"C:\Users\SMRC\OneDrive\Documents\info2.txt\information.txt");
            //reading
            string line;
            while (reading.EndOfStream == false)
            {
                line = reading.ReadLine();
                Result.Items.Add(line);
            }
            //closing
            reading.Close();
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            //importing class
            StreamReader read;
            read = File.OpenText(@"C:\Users\SMRC\OneDrive\Documents\info2.txt\information.txt");
            char character;
            //reading
            while (read.EndOfStream == false)
            {
                character = (char)read.Read();
                Result.Items.Add(character);
            }
            //closing
            read.Close();

        }

        private void btnreadall_Click(object sender, EventArgs e)
        {
          
            // Reading all lines into a string array
            string[] allLines = File.ReadAllLines(@"C:\Users\SMRC\OneDrive\Documents\info2.txt\information.txt");

            // Displaying each line in the ListBox
            foreach (string line in allLines)
            {
                Result.Items.Add(line);
            }        
          
        }

        private void bbtnalltext_Click(object sender, EventArgs e)
        {
            //reading using readalltext
            String all;
            all = File.ReadAllText("Info.txt");
            //displaying
            Result.Items.Add(all);
          

        }

        private void btndeletefile_Click(object sender, EventArgs e)
        {
            //deleting file
            if (File.Exists("Info.txt"))
            {
                File.Delete("Info.txt");
                MessageBox.Show("File deleted successfully");
            }
            else
            {
                MessageBox.Show("File not found");
            }
        }

        private void btndeleteitem_Click(object sender, EventArgs e)
        {
            //deleting item in file
          string content = File.ReadAllText("Info.txt");

            content = content.Replace("C#", "");

            File.WriteAllText("Info.txt", content);
        }
        

        private void btnotherfunction_Click(object sender, EventArgs e)
        {
            //other reading function
            foreach (string line in File.ReadLines("Info.txt"))
            {
                Result.Items.Add(line);
            }
        }


    }
    
}
 

