using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class ActiveConnections : Form
    {
        public ActiveConnections()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process netUtility = new Process();

            netUtility.StartInfo.FileName = "netstat.exe";

            netUtility.StartInfo.CreateNoWindow = true;

            netUtility.StartInfo.Arguments = "-a";

            netUtility.StartInfo.RedirectStandardOutput = true;

            netUtility.StartInfo.UseShellExecute = false;

            netUtility.StartInfo.RedirectStandardError = true;

            netUtility.Start();

            StreamReader streamReader = new StreamReader(netUtility.StandardOutput.BaseStream, netUtility.StandardOutput.CurrentEncoding);

            string line = "";

            while ((line = streamReader.ReadLine()) != null)
            {
                listBox1.Items.Add(line + "\n");
                //if (line.StartsWith("\\"))
                //{

                //    listBox1.Items.Add(line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper());
                //    // IPAddress[] allipaddlist = Dns.GetHostAddresses(Dns.GetHostName());
                //    //IPHostEntry he = new IPHostEntry();

                //}
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            listBox1.Items.Clear();
            Process netUtility = new Process();

            netUtility.StartInfo.FileName = "netstat.exe";

            netUtility.StartInfo.CreateNoWindow = true;

            netUtility.StartInfo.Arguments = "-a 192.168.0.15";
            //netUtility.StartInfo.Arguments = textBox1.Text;
            netUtility.StartInfo.RedirectStandardOutput = true;

            netUtility.StartInfo.UseShellExecute = false;

            netUtility.StartInfo.RedirectStandardError = true;

            netUtility.Start();

            StreamReader streamReader = new StreamReader(netUtility.StandardOutput.BaseStream, netUtility.StandardOutput.CurrentEncoding);

            string line = "";
            
            while ((line = streamReader.ReadLine()) != null)
            {
                listBox1.Items.Add(line + "\n");
                //if (line.StartsWith("\\"))
                //{

                //    listBox1.Items.Add(line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper());
                //    // IPAddress[] allipaddlist = Dns.GetHostAddresses(Dns.GetHostName());
                //    //IPHostEntry he = new IPHostEntry();

                //}
            }

        }
    }
}
