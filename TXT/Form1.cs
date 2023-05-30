using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace TXT
{
    public partial class Form1 : Form
    {
        string TXTfile_Location;

       

        public class CardData
        {
            public string name { get; set; }
            public string owner { get; set; }
            public string ChannelName { get; set; }

            public string ChannelScheme { get; set; }

            public CardData()
            {
                this.name = string.Empty;
                this.owner = string.Empty;
                this.ChannelName = string.Empty;
                this.ChannelScheme = string.Empty;
            }
        }

        Dictionary<string, CardData> resultDict = new Dictionary<string, CardData>();

        public Form1()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            TXTfile_Location = Properties.Settings.Default.TXTfileLoc_Settings;
            textBox_Search.Text = TXTfile_Location;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            //Opening a file
            String searchPath = "";
            if (TXTfile_Location != "")
            {
                if (Directory.Exists(Path.GetDirectoryName(TXTfile_Location)))
                    searchPath = Path.GetDirectoryName(TXTfile_Location);
                else
                    searchPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); //Gets the default Deskptop location without needing the machine's name to be updated.
            }
            OpenFileDialog wbFile = new OpenFileDialog
            {
                //Properties of OpenFileDialog
                CheckFileExists = true,
                CheckPathExists = true,
                InitialDirectory = searchPath
            };

            if (wbFile.ShowDialog() == DialogResult.OK)
            {
                TXTfile_Location = wbFile.FileName; //save the file's path to be used elsewhere in the  code
                textBox_Search.Text = TXTfile_Location; //update the textbox to show the file path
                Properties.Settings.Default.TXTfileLoc_Settings = TXTfile_Location; //Save location to program settings

                Properties.Settings.Default.Save();
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {

            

            foreach (string line in File.ReadLines(TXTfile_Location))
            {
                    Console.WriteLine(line);

                //string[] splitSTR = line.Split(' ');

            }

            Console.WriteLine("\n\n");



            foreach (string line in File.ReadLines(TXTfile_Location))
            {

                Console.WriteLine("\n--------------------\n");

                string[] splitSTR = line.Split(null);

                //TB
                foreach(string val in splitSTR)
                {
                    Console.Write(val + ", ");
                }
                Console.WriteLine("");


                string[] resultSTR = new string[10];
                int counter = 0;

                CardData cData = new CardData();

                foreach (string val in splitSTR)
                {
                    if (!String.IsNullOrWhiteSpace(val))
                    {
                        resultSTR[counter] = val.Trim();

                        Console.Write(resultSTR[counter] + ", ");
                        counter++;
                    }

                   

                    if(counter > 2)
                    {
                        Array.Resize(ref resultSTR, counter);

                        cData.name = resultSTR[0];
                        cData.ChannelName = resultSTR[1];
                        cData.ChannelScheme = resultSTR[2];
                        resultDict.Add(cData.name, cData);
                    }


                }
                Console.WriteLine("");




                string owner = "";
                string ownerFormated = "";
                Regex regEx = new Regex(@"\d");

                //while(owner.Length < 4)
               // {
                    string name = cData.name;
                    for ( int i = 0; i < cData.name.Length; i++)
                    {
                        if(regEx.IsMatch(name.Substring(i, 1)) & owner.Length < 4)
                        {
                            owner += name.Substring(i, 1);
                        }

                    }

                if (!string.IsNullOrWhiteSpace(owner))
                {
                    ownerFormated = "/" + owner.Substring(0, 1) + "." + owner.Substring(1, 1) + "/" + owner.Substring(2, 1) + "." + owner.Substring(3, 1);
                    cData.owner = ownerFormated;
                }
                else
                {
                    cData.owner = null;
                }

                //}
                Console.WriteLine(ownerFormated);

            }
        }
    }
}
