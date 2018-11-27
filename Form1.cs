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

/*
 https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file
   How to write to a text file ^  
     
     
     */


namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();

        private void button1_Click(object sender, EventArgs e) 
        {
   
       

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this one is labeled as save on the designer
            sfd.ShowDialog();

            if (sfd.FileName != "") {

            //left off with google search of ho to save file in c#. Youtube video from fox learn
            //3 min 44 secs

            }


        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this is is labeled as open on the designer
            ofd.ShowDialog();

            if (ofd.ShowDialog() == DialogResult.OK) {

                textBox1.Text = ofd.FileName;//this bit pulls the file path into the text box, 
                                             //after you select it

                textBox2.Text = ofd.SafeFileName;//this bit tells you the actual file name.

            }

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
