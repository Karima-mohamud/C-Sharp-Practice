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

namespace OpenAndSaveDialogAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblinfo_Click(object sender, EventArgs e)
        {

        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            //openfilebutton
            DialogResult result;
            result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //import class
                StreamReader read;
                read= File.OpenText(openFileDialog.FileName);
                String line;
                while(read.EndOfStream == false)
                {
                    line = read.ReadLine();
                    Displaying.Items.Add(line);
                }
                //closing file
                read.Close();
            }
            else if(result == DialogResult.Cancel) 
            {
                MessageBox.Show("File Not Selected");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //savefile
            //import class
            StreamWriter writer;
            DialogResult result;
            result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                writer = File.AppendText(saveFileDialog.FileName);
                writer.WriteLine(textinfo.Text);
                //closing file
                writer.Close();
                
            }
            else if( result == DialogResult.Cancel)
            {
                MessageBox.Show("No File Selected");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing textbox and list box
            textinfo.Clear();
            Displaying.Items.Clear();
        }
    }
}
