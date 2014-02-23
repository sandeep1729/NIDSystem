using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Management.Instrumentation;
using System.Configuration.Assemblies;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class CurrentSystemInfo : Form
    {
        public CurrentSystemInfo()
        {
            InitializeComponent();
        }
      //  Login lg = new Login();

        private void CurrentSystemInfo_Load(object sender, EventArgs e)
        {DriveInfo dinfo;
            string alldrive = string.Empty;
            ManagementObjectSearcher Search = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");
            System.Management.ManagementObjectSearcher objSearcher = new System.Management.ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");
            string sDrive = string.Empty;
            string[] drv = Directory.GetLogicalDrives();
            foreach (string strdrive in drv)
            {
                dinfo = new DriveInfo(strdrive);
                 alldrive = alldrive + "\n" + strdrive;
            }
            
            //string str = dinfo.ToString();
           // label2.Text = str;
           
            foreach (ManagementObject Mobject in Search.Get())
            {
                double Ram_Bytes = (Convert.ToDouble(Mobject["TotalPhysicalMemory"]));
                double d = Ram_Bytes / 1073741824;
                richTextBox1.Text = "RAM SIZE " + " -- " + Convert.ToString(d) + " GB";
                
            }
            //System.Configuration.
            richTextBox1.Text = richTextBox1.Text + "\n\n" + "COMPUTER NAME" + " -- " + SystemInformation.ComputerName.ToString() + "\n\n" + "USER NAME" + "--" + SystemInformation.UserName.ToString() + "\n\n" + "OS VERSION" + " -- " + System.Environment.OSVersion.ToString() + "\n\n" + "MONITOR SIZE" + " -- " + SystemInformation.PrimaryMonitorSize.ToString() + "\n\n" + "MOUSE SPEED" + " -- " + SystemInformation.MouseSpeed.ToString() + "\n\n" + "KEYBOARD SPEED" + " -- " + SystemInformation.KeyboardSpeed.ToString()+"\n"+"all available drives are:"+alldrive;
           // label2.Text = Login.str;
            richTextBox2.Text = richTextBox2.Text+label2.Text + "\t" + System.DateTime.Now.ToString();
           // richTextBox2.SaveFile("c:\\trylogic New\\log.rtx", RichTextBoxStreamType.RichText);
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instructions ins = new Instructions();
            //ins.Show();
            //this.Hide();
        }
    }
}
