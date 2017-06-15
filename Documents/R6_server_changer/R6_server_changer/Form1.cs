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

namespace R6_server_changer
{
    public partial class Form1 : Form
    {

        string dac;
        string fileloc;
        public Form1()
        {
            InitializeComponent();
        }
        public void filewr(string dac, string fileloc)
        {
            
            fileloc = "C:/Users/LAD/Documents/My Games/Rainbow Six - Siege/88b82571-82f9-49bd-a0df-7576dd6f39b2/GameSettings.ini";
            Stream filest = new FileStream(fileloc, FileMode.Open);
            StreamReader strd = new StreamReader(filest);
            string content = strd.ReadToEnd();
            content = content.Replace("DataCenterHint=default", "DataCenterHint=" + dac);
            StreamWriter stwr = new StreamWriter(filest);
            stwr.Write(content);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton rdbt = sender as RadioButton;
            
            if (rdbt.Checked == false)
            {
                return;
            }
            switch(rdbt.Text)
            {
                case "Auto":
                    {
                        dac = "default";
                        break;
                    }
                case "US East":
                    {
                        dac = "eus";
                        break;
                    }
                case "US Central":
                    {
                        dac = "cus";
                        break;
                    }
                case "US South Central":
                    {
                        dac = "scus";
                        break;
                    }
                case "US West":
                    {
                        dac = "wus";
                        break;
                    }
                case "Brasil South":
                    {
                        dac = "sbr";
                        break;
                    }
                case "Europe Notrh":
                    {
                        dac = "neu";
                        break;
                    }
                case "Europe West":
                    {
                        dac = "weu";
                        break;
                    }
                case "Asia East":
                    {
                        dac = "eas";
                        break;
                    }
                case "Asia South East":
                    {
                        dac = "seas";
                        break;
                    }
                case "Australia East":
                    {
                        dac = "aeu";
                        break;
                    }
                case "Japan West":
                    {
                        dac = "wja";
                        break;
                    }
                

            }
        }
        /*
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Stream filelocation = new FileStream("fileloc.txt", FileMode.OpenOrCreate);
            filelocation.Write(sender);

        }
        */

    }
}