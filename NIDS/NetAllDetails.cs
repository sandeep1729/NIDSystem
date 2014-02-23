using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;

namespace WindowsFormsApplication1
{
    public partial class NetAllDetails : Form
    {
        public NetAllDetails()
        {
            InitializeComponent();
        }
        UkkonsALg obj_alg = new UkkonsALg();
        DataCls obj_data = new DataCls();
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
            Process netUtility = new Process();

            netUtility.StartInfo.FileName = "net.exe";

            netUtility.StartInfo.CreateNoWindow = true;

            netUtility.StartInfo.Arguments = "view";

            netUtility.StartInfo.RedirectStandardOutput = true;

            netUtility.StartInfo.UseShellExecute = false;

            netUtility.StartInfo.RedirectStandardError = true;

            netUtility.Start();

            StreamReader streamReader = new StreamReader(netUtility.StandardOutput.BaseStream, netUtility.StandardOutput.CurrentEncoding);

            string line = "";

            while ((line = streamReader.ReadLine()) != null)
            {

                if (line.StartsWith("\\"))
                {

                    listView1.Items.Add(line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper());
                    // IPAddress[] allipaddlist = Dns.GetHostAddresses(Dns.GetHostName());
                    //IPHostEntry he = new IPHostEntry();

                }
            }
            IPHostEntry h; int j = 0;
            try
            {
                for (j = 0; j < listView1.Items.Count; j++)
                {
                    try
                    {
                        string hostname = listView1.Items[j].Text;
                        h = Dns.GetHostByName(hostname);
                        for (int i = 0; i < h.AddressList.Length; i++)
                        {
                            listView1.Items[j].SubItems.Add(h.AddressList[i].ToString());

                        }
                        if (h.AddressList.Length == 1)
                            listView1.Items[j].SubItems.Add("No Another IP");
                        listView1.Items[j].SubItems.Add(GetMacUsingARP(h.AddressList[0].ToString()));

                        Ping obj_ping = new Ping();
                        PingOptions obj_opt = new PingOptions();
                        PingReply obj_reply;
                        obj_reply = obj_ping.Send(h.AddressList[0].ToString());
                        if (obj_reply.Status == IPStatus.Success)
                        {
                            listView1.Items[j].SubItems.Add("Active");
                            listView1.Items[j].SubItems.Add("Checking..");

                            listView1.Items[j].SubItems.Add(obj_reply.Buffer.Length.ToString());
                            listView1.Items[j].SubItems.Add(obj_reply.Options.Ttl.ToString());
                        }
                    }
                    catch { }



                }
            }
            catch
            {
            }
          
        }
        int insCount = 0;

        private void NetAllDetails_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Host Name",200);
            listView1.Columns.Add("IP Address 1", 200);
            listView1.Columns.Add("IP Address 2", 200);
            listView1.Columns.Add("MAC/Physical Address", 200);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add("Signature", 200);
            listView1.Columns.Add("Data Received", 100);
            listView1.Columns.Add("Responce Time(Ttl)", 100);
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int jrows = 0; jrows < listView1.Items.Count; jrows++)
            {
                try
                {
                    string mac = listView1.Items[jrows].SubItems[3].Text;
                    string mac6 = mac.Replace(":", "");
                    string mac66 = mac6.Substring(0, 6);
                   
                    try
                    {

                        //for (int i = 0; i < listView1.Items.Count; i++)
                      //  {
                            listView1.Items[jrows].SubItems[5].Text = obj_alg.algorthm(mac66);
                       // }
                    }
                    catch
                    {


                    }
                }
                catch { }
            }
            //store the alldetails into the database for future purpose
            string deleteQuery = "delete  from [TotalALLSignatures]";
            int j = obj_data.InsUpDel(deleteQuery);
            for (int RowCount = 0; RowCount < listView1.Items.Count; RowCount++)
            {

                try
                {

                    string hostname = listView1.Items[RowCount].SubItems[0].Text;
                    string ipadd1 = listView1.Items[RowCount].SubItems[1].Text;
                    string ipadd2 = listView1.Items[RowCount].SubItems[2].Text;
                    string mac = listView1.Items[RowCount].SubItems[3].Text;
                    string status = listView1.Items[RowCount].SubItems[4].Text;
                    string signature = listView1.Items[RowCount].SubItems[5].Text;
                    string datare = listView1.Items[RowCount].SubItems[6].Text;
                    string respotime = listView1.Items[RowCount].SubItems[7].Text;
                   
                    string insertQuery = "insert into [TotalALLSignatures] values('" + hostname + "','" + ipadd1 + "','" + ipadd2 + "','" + mac + "','" + status + "','" + signature + "','" + datare + "','" + respotime + "')";
                    int i = obj_data.InsUpDel(insertQuery);
                    if (i > 0)
                    {
                        insCount++;
                    }


                }
                catch
                { 
                
                }

                
            
            }
MessageBox.Show(insCount+"Record(S) inserted");
        }
    }
}
