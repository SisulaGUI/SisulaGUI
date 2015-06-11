using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Excel =  Microsoft.Office.Interop.Excel;
using ReadFile = System.IO;

namespace SisulaGUI
{
    public partial class Form1 : Form
    {
       Form2 ConfigForm = new Form2();
       private PictureBox pictureBox1;
       Source FirstXML = new Source();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                // workaround for multiple exits and starts
            ConfigForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                // workaround for multiple exits and starts
            FirstXML.ShowDialog();
        }


           
        }
          
}
           
      

