using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;

using XmlObjects; //XML Classes/Objects

namespace SisulaGUI
{

    public partial class Source : Form
    {
        string Link = "";
        List<string> Insertcollection = new List<string>();
        List<string> InsertcollectionDone = new List<string>();
        string[] ArrayInsert = { "" };
        //private RichTextBox richTextBox1;
        string[] ArrayInsertDone = { "" };
        //source source = new source();
        //sourcePart sourcepart = new sourcePart();

        public Source()
        {
            InitializeComponent();
            
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            dataGridView1.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            button1.Hide();
            button2.Hide();
            menuStrip1.Hide();
            comboBox1.Hide();
        
        }
        public void GenerateXML(source SourceTest)
        {
             //----------------------FINA GREJER---------------------------------------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                XmlSerializer serializer = new XmlSerializer(typeof(source),"");                                                                                                  //
                using (TextWriter writer = new StreamWriter("Source.xml"))                                                                                                       //
                {                                                                                                                                                              //
                    try { serializer.Serialize(writer, SourceTest); MessageBox.Show("XML document successfully generated as Source.xml!"); }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                }                                                                                                                                                              //
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
        private void button1_Click(object sender, EventArgs e)
        {


            //source sourcetest = new Source();
            source SourceTest = new source();

            sourcePart SourcePartTest = new sourcePart();

            //Source efter xml-deklarering (Static values?)
            SourceTest.name = "%Source%";
            SourceTest.codepage = "ACP";
            SourceTest.datafiletype = "char";
            SourceTest.fieldterminator = @"\r\n";
            SourceTest.rowlength = 1000;
            SourceTest.split = "regex";

            /*
            //sourcePart part1
            sourcePart SourcePart1Test = new sourcePart();
            */
            //multiple parts test (part1)
            SourcePartTest.name = "TestPart";
            SourcePartTest.nulls = "";
            SourcePartTest.Text.Add("SQL?");
            /*
            //sourcePartTerm term1;
            sourcePartTerm SourcePartTerm1Test = new sourcePartTerm();

            //multiple terms in part1 (term1)
            SourcePartTerm1Test.name = "term1";
            SourcePartTerm1Test.format = "term1";
            SourcePartTerm1Test.delimiter = "term1";
            SourcePartTerm1Test.pattern = "term1";
            SourcePart1Test.Items.Add(SourcePartTerm1Test);

            //sourcePartTerm term2;
            sourcePartTerm SourcePartTerm2Test = new sourcePartTerm();

            //multiple terms in part1 (term2)
            SourcePartTerm2Test.name = "term2";
            SourcePartTerm2Test.format = "term2";
            SourcePartTerm2Test.delimiter = "term2";
            SourcePartTerm2Test.pattern = "term2";
            SourcePart1Test.Items.Add(SourcePartTerm2Test);

            //sourcePart part2
            sourcePart SourcePart2Test = new sourcePart();

            //multiple parts test (part2)
            SourcePart2Test.name = "part2";
            SourcePart2Test.nulls = "";
            SourcePart2Test.Text.Add("gg");

            //sourcePartTerm term3;
            sourcePartTerm SourcePartTerm3Test = new sourcePartTerm();

            //multiple terms in part1 (term3)
            SourcePartTerm3Test.name = "term3";
            SourcePartTerm3Test.format = "term3";
            SourcePartTerm3Test.delimiter = "term3";
            SourcePartTerm3Test.pattern = "term3";
            SourcePart2Test.Items.Add(SourcePartTerm3Test);

            //sourcePartTerm term4;
            sourcePartTerm SourcePartTerm4Test = new sourcePartTerm();

            //multiple terms in part1 (term4)
            SourcePartTerm4Test.name = "term4";
            SourcePartTerm4Test.format = "term4";
            SourcePartTerm4Test.delimiter = "term4";
            SourcePartTerm4Test.pattern = "term4";
            SourcePart2Test.Items.Add(SourcePartTerm4Test);


            //add part1 and part2 to source
            SourceTest.part.Add(SourcePart1Test);
            SourceTest.part.Add(SourcePart2Test);

            //generate xml with terms and parts
            GenerateXML(SourceTest);
            */

              
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Visible.Equals(true))
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Visible.Equals(true))
                                {
                                    if (!row.IsNewRow)
                                    {
                                        InsertcollectionDone.Add(cell.Value.ToString());
                                    }
                                }
                            }

                            //insert cells to array
                            ArrayInsertDone = InsertcollectionDone.ToArray();

                            //Ny term
                            sourcePartTerm SourcePartTermTest = new sourcePartTerm();

                            //insert input values to xml-object
                            SourcePartTermTest.name = ArrayInsertDone[0].ToString();
                            SourcePartTermTest.format = ArrayInsertDone[1].ToString();
                            SourcePartTermTest.delimiter = ArrayInsertDone[2].ToString();
                            SourcePartTermTest.pattern = ArrayInsertDone[3].ToString();

                            //Add this term to this part
                            SourcePartTest.Items.Add(SourcePartTermTest);

                            //Remove old data from array
                            Array.Clear(ArrayInsertDone, 0, ArrayInsertDone.Length);
                            InsertcollectionDone.Clear();

                        }
                }
                SourceTest.part.Add(SourcePartTest);
                //Generate xml (test)
                GenerateXML(SourceTest);
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
             
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bool condition1 = false;
            bool condition2 = false;

            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                condition1 = true;
            }

            Regex regex = new Regex(@"\W+");
            Match match = regex.Match(textBox2.Text);
            if (match.Value != "")
            { condition2 = true; }

            if (condition1 == true && condition2 ==  false) { MessageBox.Show("All of the fields must be filled in.", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            if (condition2 == true && condition1 == false ) { MessageBox.Show("Incorrect characters in 'Name' field. Only alphanumeric characters are allowed (A-Z, a-z, 0-9)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            if (condition2 == false && condition1 == false)
            {
                this.dataGridView1.Rows.Add(textBox2.Text, comboBox1.Text, textBox4.Text, textBox3.Text);
            }
        }
        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //Filter
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Openlink = openFileDialog1.ToString();
                Link = Openlink.Substring(Openlink.IndexOf("FileName:") + 10, Openlink.Length - (Openlink.IndexOf("FileName:") + 10));
                

                var lines = File.ReadAllLines(Link);
                if (lines.Count() > 0)
                {
                 
                    foreach (var cellValues in lines.Skip(1))
                    {
                        var cellArray = cellValues
                            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (cellArray.Length == dataGridView1.Columns.Count)
                            dataGridView1.Rows.Add(cellArray);
                    }
                }
            }
        }
        
        private void currentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.Write("Name " + "Datatype " + "Delimiter " + "Pattern");
                    sw.WriteLine();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        if (row.Visible.Equals(true))
                            if (!row.IsNewRow)
                            {

                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Visible.Equals(true))
                                        if (!row.IsNewRow)
                                        {
                                            Insertcollection.Add(cell.Value.ToString() + " ");

                                        }
                                }

                                ArrayInsert = Insertcollection.ToArray();

                                sw.Write(ArrayInsert[0]);
                                sw.Write(ArrayInsert[1]);
                                sw.Write(ArrayInsert[2]);
                                sw.Write(ArrayInsert[3].Replace(" ", ""));
                                sw.WriteLine();
                                Array.Clear(ArrayInsert, 0, ArrayInsert.Length);
                                Insertcollection.Clear();

                            }
                    }
                }


            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                textBox3.Enabled = true;
            }
        }

        private void Source_Load(object sender, EventArgs e)
        {
            //global::SisulaGUI.Form1.sh
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            source.description = textBox1.Text;
            source.datafiletype = "char";
            source.codepage = "ACP";
            source.fieldterminator = "\r\n";
            source.rowlength = 1000;
            source.name = "%Source%";
            source.split = "regex";
            source.Serialize();
            */

            //Hide when pressed
            textBox1.Hide();
            button3.Hide();
            label5.Hide();

            //Show when pressed
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            dataGridView1.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            button1.Show();
            button2.Show();
            menuStrip1.Show();
            comboBox1.Show();
           

        }

        public void SourceXML1_FormClosing (object sender, FormClosingEventArgs e)
        {
            //SisulaGUI.Form1.Show();
        }


        //private void InitializeComponent()
        //{
        //    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Source));
        //    this.SuspendLayout();
        //    // 
        //    // Source
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        //    //this.Name = "Source";
        //    this.ResumeLayout(false);

        //}
    }
}

    

                             