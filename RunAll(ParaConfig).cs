using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;


namespace SisulaGUI
{

    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    

        private void Finish_Click(object sender, EventArgs e)
        {

           
            if (string.IsNullOrEmpty(System.Text) || string.IsNullOrEmpty(Source.Text) || string.IsNullOrEmpty(TargetDatabase.Text) || string.IsNullOrEmpty(SourceDatabase.Text) || string.IsNullOrEmpty(MetaDatabase.Text))
            {

                MessageBox.Show("All the fields has to be filled in!");
            }
            else
            {
                /*---------------------------------------------------------------*/
                OpenFileDialog SelectBatmanDialog = new OpenFileDialog();

                //SelectBatmanDialog.InitialDirectory = "c:\\" ;
                SelectBatmanDialog.Filter = "All files (*.*)|*.*|bat files (*.bat)|*.bat";
                SelectBatmanDialog.FilterIndex = 2 ;
                //SelectBatmanDialog.RestoreDirectory = true ;

                if(SelectBatmanDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        
                        //MessageBox.Show(SelectBatmanDialog.FileName);
                        /*
                        if ((myStream = SelectBatmanDialog.OpenFile()) != null)
                        {
                           
                            using (myStream)
                            {
                                myStream.

                            }
                        }
                         */
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            

    /*-----------------------------------------------------------------------------------------*/





                Process pro = new Process();

                pro.StartInfo.FileName = SelectBatmanDialog.FileName; //Change in order where your Sisula source is located at (temporary).

                Regex regex = new Regex(@"\W+");
                Match match = regex.Match(System.Text);
                Match match1 = regex.Match(Source.Text);
                Match match2 = regex.Match(TargetDatabase.Text);
                Match match3 = regex.Match(SourceDatabase.Text);
                Match match4 = regex.Match(MetaDatabase.Text);
                //MessageBox.Show(match.Value);

                //System
                if (match.Value != ""){MessageBox.Show("Incorrect characters in 'System' field. Only alphanumeric characters are allowed (A-Z, a-z, 0-9)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
                //Source
                else if (match1.Value != ""){MessageBox.Show("Incorrect characters in 'Source' field. Only alphanumeric characters are allowed (A-Z, a-z, 0-9)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
                //TargetDatabase
                else if (match2.Value != ""){MessageBox.Show("Incorrect characters in 'TargetDatabase' field. Only alphanumeric characters are allowed (A-Z, a-z, 0-9)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
                //SourceDatabase
                else if (match3.Value != ""){MessageBox.Show("Incorrect characters in 'SourceDatabase' field. Only alphanumeric characters are allowed (A-Z, a-z, 0-9)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
                //MetaDatabase
                else if (match4.Value != ""){MessageBox.Show("Incorrect characters in 'MetaDatabase' field. Only alphanumeric characters are allowed (A-Z, a-z, 0-9)", "Warning"
                    
                    
                    
                    
                    
                    
                    
                    
                    
                  
                    
                   
                    
                 , MessageBoxButtons.OK, MessageBoxIcon.Warning);}
                //All input-fields correct  
                else{ 
                      pro.StartInfo.Arguments =
                      System.Text + " " +
                      Source.Text + " " +
                      TargetDatabase.Text + " " +
                      SourceDatabase.Text + " " +
                      MetaDatabase.Text;
               
                try { pro.Start(); }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                            }

               


              

                //MessageBox.Show(
                //                System.Text.Replace(" ", "") + " " +
                //                Source.Text.Replace(" ", "") + " " +
                //                TargetDatabase.Text.Replace(" ", "") + " " +
                //                SourceDatabase.Text.Replace(" ", "") + " " +
                //                MetaDatabase.Text.Replace(" ", "")
                //                );



    
            }
        }


    }
}
