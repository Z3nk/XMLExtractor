using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace XMLExtractor
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void UploadFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void GOButton_Click(object sender, EventArgs e)
        {
            if (XMLExtractor.mode == Mode.Mode1)
            {
                int nbLine = 0;
                if (int.TryParse(nbLineTextBox.Text, out nbLine) && XMLExtractor.FileLocation != null)
                {
                    this.GOButton.Text = "Spliting ...";
                    ThreadStart ts = delegate
                    {
                        XMLExtractor.getFilesByNbLine(this, openFileDialog1.FileName, nbLine, XMLExtractor.FileLocation);
                    };
                    new Thread(ts).Start();
                    this.GOButton.Text = "GO";
                }
                else
                {
                    this.pictureBox1.Visible = true;
                }
            }
            else
            {  
                XmlTextReader reader = new XmlTextReader(openFileDialog1.FileName);
                XmlDocument doc = new XmlDocument();
                XPathNavigator nav = doc.CreateNavigator();
                bool isOk=true;
                try 
                {
                  XPathExpression expr = nav.Compile(conditionTextBox.Text);
                }
                catch (XPathException)
                {
                    isOk = false;
                }
                if (isOk)
                {
                    doc.Load(reader);
                    reader.Close();

                    //Select the cd node with the matching title
                    XmlNode node;
                    XmlElement root = doc.DocumentElement;
                    node = root.SelectSingleNode(conditionTextBox.Text);
                    root.InnerXml=node.OuterXml;
                    //save the output to a file
                    doc.Save(XMLExtractor.FileLocation+"\\result.xml");
                }
            }
        }

        private void outputDirectoryButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                XMLExtractor.FileLocation = this.folderBrowserDialog1.SelectedPath;
                OutputDirectoryButton.Text = XMLExtractor.FileLocation;
                OutputDirectoryButton.Font = new Font("Impact", 6);
            }
        }

        private void nbLineTextBox_Click(object sender, EventArgs e)
        {
            if (!(XMLExtractor.mode == Mode.Mode2 && ((TextBox)sender).Text!="Condition"))
            ((TextBox)sender).Text = "";
        }

        private void Mode1Button_Click(object sender, EventArgs e)
        {
            XMLExtractor.mode = Mode.Mode1;
            conditionTextBox.Visible = false;
        }

        private void Mode2Button_Click(object sender, EventArgs e)
        {
            XMLExtractor.mode = Mode.Mode2;
            conditionTextBox.Visible = true;
        }

    }
}
