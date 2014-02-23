using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Management;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        public static extern int SendARP(int DestIP, int SrcIP, byte[] pMacAddr, ref uint PhyAddrLen);
        private string GetMacUsingARP(string IPAddr)
        {
            IPAddress IP = IPAddress.Parse(IPAddr);
            byte[] macAddr = new byte[6];
            uint macAddrLen = (uint)macAddr.Length;

            if (SendARP((int)IP.Address, 0, macAddr, ref macAddrLen) != 0)
                throw new Exception("ARP command failed");

            string[] str = new string[(int)macAddrLen];
            for (int i = 0; i < macAddrLen; i++)
                str[i] = macAddr[i].ToString("x2");

            return string.Join(":", str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lbl1.Text = "Hi";

            //string macAddresses = "";

            //foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            //{
            //    if (nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
            //    {
            //        macAddresses += nic.GetPhysicalAddress().ToString();
            //        break;
            //    }
            //}
            //lbl1.Text = macAddresses;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select MACAddress,PNPDeviceID FROM Win32_NetworkAdapter WHERE MACAddress IS NOT NULL AND PNPDeviceID IS NOT NULL");
            ManagementObjectCollection mObject = searcher.Get();

            foreach (ManagementObject obj in mObject)
            {
                string pnp = obj["PNPDeviceID"].ToString();
                if (pnp.Contains("PCI\\"))
                {
                    string mac = obj["MACAddress"].ToString();
                    mac = mac.Replace(":", string.Empty);
                    listBox1.Items.Add(mac);
                }
            }


        }
        private string GetMacAddress()
        {
            string macAddresses = "";

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                   // break;
                }
            }
            return macAddresses;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl1.Text = GetMacAddress();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagementScope theScope = new ManagementScope("\\\\192.168.0.3\\root\\cimv2");

            StringBuilder theQueryBuilder = new StringBuilder();
            theQueryBuilder.Append("SELECT MACAddress FROM Win32_NetworkAdapter");
            ObjectQuery theQuery = new ObjectQuery(theQueryBuilder.ToString());
            ManagementObjectSearcher theSearcher = new ManagementObjectSearcher(theScope, theQuery);
            ManagementObjectCollection theCollectionOfResults = theSearcher.Get();
string macAdd="";
            foreach (ManagementObject theCurrentObject in theCollectionOfResults)
            {
                try
                {
                    macAdd = "MAC Address: " + theCurrentObject["MACAddress"].ToString();
                }
                catch { }
                MessageBox.Show(macAdd);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool macRequired = true;

             while (macRequired)

               {

                  Console.WriteLine("Enter the IP address for which mac address is " +

                                  "required:(Enter exit to quit the program.)");

                  string ipAddress = Console.ReadLine();

                  StringComparer cp = StringComparer.OrdinalIgnoreCase;

                 if (cp.Compare(ipAddress, "Exit") == 0) break;

 

                // GetMacAddressFromIPAddress getMacAddress =new GetMacAddressFromIPAddress();

 

                 MessageBox.Show("Please wait while I try to find the MAC address...");

                 // You may also use the ARP table. Call GetMACAddressFromARP here

               //  string MacAddress = getMacAddress.GetMacAddress(ipAddress);

 

               ///  MessageBox.Show(MacAddress);

             } // end while
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Management.ManagementClass objMgmtCls = new System.Management.ManagementClass("Win32_NetworkAdapter");

            foreach (System.Management.ManagementObject objMgmt in objMgmtCls.GetInstances())
            {
                MessageBox.Show("Manufacturer : " + objMgmt["Manufacturer"]);
                MessageBox.Show("Adapter Name : " + objMgmt["Caption"]);
                MessageBox.Show("MAC Address : " + objMgmt["MACAddress"]);
                MessageBox.Show("---------------------------------------");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetMacUsingARP("192.168.0.1"));
            MessageBox.Show(GetMacUsingARP("192.168.0.3"));
        }

        private void button6_Click(object sender, EventArgs e)
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
                listBox1.Items.Add(line+"\n");
                //if (line.StartsWith("\\"))
                //{

                //    listBox1.Items.Add(line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper());
                //    // IPAddress[] allipaddlist = Dns.GetHostAddresses(Dns.GetHostName());
                //    //IPHostEntry he = new IPHostEntry();

                //}
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process netUtility = new Process();

            netUtility.StartInfo.FileName = "nbtstat.exe";

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

        private void button8_Click(object sender, EventArgs e)
        {
             ManagementObjectSearcher objQuery = null;
            ManagementObjectCollection queryCollection = null;

            try
            {
                objQuery = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration");

                queryCollection = objQuery.Get();

                foreach (ManagementObject mgmtObject in queryCollection)
                {
                    if (mgmtObject["MacAddress"] != null)
                    {
                        MessageBox.Show(mgmtObject["MacAddress"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source);
                MessageBox.Show(ex.Message);
            }

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            //for each j you can get the MAC 
            PhysicalAddress address = nics[0].GetPhysicalAddress();
            byte[] bytes = address.GetAddressBytes();
            for (int i = 0; i < bytes.Length; i++)
            {
                // Display the physical address in hexadecimal. 
                MessageBox.Show("{0}:" + bytes[i].ToString("X2"));
                // Insert a hyphen after each byte, unless we are at the end of the 
                // address. 
                if (i != bytes.Length - 1)
                {
                    MessageBox.Show("-");
                }
            }

        }
        public static String GetMACAddress1()
        {
            #region Get MAC Address
            try
            {
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                string MACAddress = String.Empty;
                foreach (ManagementObject mo in moc)
                {
                    if (MACAddress == String.Empty) // only return MAC Address from first card
                    {
                        if ((bool)mo["IPEnabled"] == true) MACAddress = mo["MacAddress"].ToString();
                    }
                    mo.Dispose();
                }

                //MACAddress = MACAddress.Replace(":", "");
                return MACAddress;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            #endregion
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("MAC Address\t:\t" + GetMACAddress1());
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<MacAddress> addresses = MacAddress.GetMacAddresses();
            foreach (MacAddress address in addresses)
            {
                listBox1.Items.Add(address);
            }

        }

    }
}
