using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class DataSend : Form
    {
        public DataSend()
        {
            InitializeComponent();
        }
        string SendIP = "";
        public static double stime;
        public static int spack;
        public static int senrg;
        string ser1;
        string part1 = "";
        string ac1 = ""; string f1 = "";
        string ac2 = ""; string f2 = "";
        string ac3 = ""; string f3 = "";
        string ac4 = ""; string f4 = "";
        string ac5 = ""; string f5 = "";
        string ac6 = ""; string f6 = "";
        string ac7 = ""; string f7 = "";
        string ac8 = ""; string f8 = "";
        string ac9 = ""; string f9 = "";
        string ac10 = ""; string f10 = "";
        int sys1, sys2;
        string fileDes, fileini;
        int len;
        byte[] clientData;
        byte[] data1;
        byte[] data2;
        byte[] data3;
        byte[] data4;
        byte[] data5;
        byte[] data6;
        byte[] data7;
        byte[] data8;
        byte[] data9;
        byte[] data10;
        byte[] wr;
        bool iResult=false;
        string colc1, colc2, colc3, colc4, colc5, colc6, colc7, colc8, colc9, colc10;
        private void DataSend_Load(object sender, EventArgs e)
        {
            string sysname = Dns.GetHostName();
            IPHostEntry ip = Dns.GetHostByName(sysname);
            label2.Text = ip.AddressList[0].ToString();
            SendIP = ip.AddressList[0].ToString();

            backgroundWorker1.RunWorkerAsync();
        }
        TcpListener myList;
        TcpClient tcpclnt;
        Socket s;
        string str2 = "";
        Thread myth;
        string datarec = "";
        Random random = new Random();
        private int RandomNumber(int min, int max)
        {
            return random.Next(5);
        }
        public bool getclient()
        {
            try
            {
                tcpclnt = new TcpClient();
                MessageBox.Show("Connecting.....");

                tcpclnt.Connect(textBox2.Text, 8001);
                string str3 = string.Empty;
                String str = textBox2.Text;
                Stream stm = tcpclnt.GetStream();
                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);
                //  MessageBox.Show("Transmitting.....");
                stm.Write(ba, 0, ba.Length);


                byte[] bb = new byte[1024 * 10];
                int k = stm.Read(bb, 0, 100);
                System.Threading.Thread.Sleep(500);
                for (int i = 0; i < k; i++)
                    str3 = str3 + Convert.ToChar(bb[i]).ToString();
                // textBox2.Text = str2;
                MessageBox.Show(str3);
                tcpclnt.Close();
                if (str3 == "sorry U r not Authenticated user.")
                {
                    iResult = false;
                    return iResult;
                }
                else
                {
                    iResult = true;
                    return iResult;
                }

            }
            catch {
                return iResult;
            
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (getclient())
            {

                splitting();
                if (ac1 != "y" || ac2 != "y" || ac3 != "y" || ac4 != "y" || ac5 != "y")
                {
                    //if (cb1.Checked == true)
                    //{
                    int num = random.Next(5);
                    sys1 = num;
                    num = random.Next(5);
                    sys2 = num;
                    locking();
                    // }
                    if (ac1 == "")
                    {
                        if (sys1 != 1 && sys2 != 1)
                        {
                            f1 = "1";
                            send(data1);
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    if (ac2 == "")
                    {
                        if (sys1 != 2 && sys2 != 2)
                        {
                            f2 = "1";
                            send(data2);
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    if (ac3 == "")
                    {
                        if (sys1 != 3 && sys2 != 3)
                        {
                            f3 = "1";
                            send(data3);
                            Application.DoEvents();

                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    if (ac4 == "")
                    {
                        if (sys1 != 4 && sys2 != 4)
                        {
                            f4 = "1";
                            send(data4);
                            Application.DoEvents();

                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    if (ac5 == "")
                    {
                        if (sys1 != 5 && sys2 != 5)
                        {
                            f5 = "1";
                            send(data5);
                            Application.DoEvents();

                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    unlocking();
                    sys1 = 0; sys2 = 0;
                    cb1.ForeColor = Color.PeachPuff;
                    cb1.Checked = false;
                    //if (f1 != "" && f2 != "" && f3 != "" && f4 != "" && f5 != "")
                    //{
                    //    locking2();
                    //}
                    if (f1 == "1" && f2 == "1" && f3 == "1" && f4 == "1" && f5 == "1")
                    {
                        locking2();
                        MessageBox.Show("First Part is Completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                if (ac6 != "z" || ac7 != "z" || ac8 != "z" || ac9 != "z" || ac10 != "z")
                {
                    //if (cb1.Checked == true)
                    //{
                    int num = random.Next(5, 10);
                    sys1 = num;
                    num = random.Next(5, 10);
                    sys2 = num;
                    locking2();
                    //}

                    if (ac6 == "")
                    {
                        if (sys1 != 6 && sys2 != 6)
                        {
                            f6 = "1";
                            send(data6);
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    if (ac7 == "")
                    {
                        if (sys1 != 7 && sys2 != 7)
                        {
                            f7 = "1";
                            send(data7);
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    if (ac8 == "")
                    {
                        if (sys1 != 8 && sys2 != 8)
                        {
                            f8 = "1";
                            send(data8);
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    if (ac9 == "")
                    {
                        if (sys1 != 9 && sys2 != 9)
                        {
                            f9 = "1";
                            send(data9);
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    if (ac10 == "")
                    {
                        if (sys1 != 10 && sys2 != 10)
                        {
                            f10 = "1";
                            send(data10);
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    unlocking2();
                    sys1 = 0; sys2 = 0;
                    cb1.ForeColor = Color.PeachPuff;
                    cb1.Checked = false;
                    MessageBox.Show("Transaction is Completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Ur Requested IP not Responded");
            
            }
            
        }
        public void send(byte[] sen)
        {
            try
            {
                IPAddress[] ipAddress = Dns.GetHostAddresses(textBox2.Text);
                IPEndPoint ipEnd = new IPEndPoint(ipAddress[0], 5);
                Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
               // byte[] fileNameByte = Encoding.ASCII.GetBytes(fileDes);
                //byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);
                stime = Convert.ToDouble(DateTime.Now.Millisecond);
                clientSock.Connect(ipEnd);
                clientSock.Send(sen);
                System.Threading.Thread.Sleep(1000);
                spack = Convert.ToInt32((clientData.Length / 1000) + 1);
                clientSock.Close();
                System.Threading.Thread.Sleep(500);
                stime = Convert.ToDouble(DateTime.Now.Millisecond) - stime;
                senrg = spack / Convert.ToInt32(stime);

            }

            catch (Exception ex)
            {
            }
        }
        public void Rece()
        {
            try
            {
                IPAddress[] ipAddress = Dns.GetHostAddresses(textBox2.Text);
                IPEndPoint ipEnd = new IPEndPoint(ipAddress[0], 5656);
                Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);


                string filePath = "";


                //fileDes = fileDes.Replace("\\", "/");
                //while (fileDes.IndexOf("/") > -1)
                //{
                //    filePath += fileDes.Substring(0, fileDes.IndexOf("/") + 1);
                //    fileDes = fileDes.Substring(fileDes.IndexOf("/") + 1);
                //}


                //byte[] fileNameByte = Encoding.ASCII.GetBytes(fileDes);


                //byte[] fileData = File.ReadAllBytes(filePath + fileDes);
                byte[] clientData = Encoding.ASCII.GetBytes("Receive");// new byte[4 + fileNameByte.Length + fileData.Length];
                //byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);

                // fileNameLen.CopyTo(clientData, 0);
                //fileNameByte.CopyTo(clientData, 4);
                // fileData.CopyTo(clientData, 4 + fileNameByte.Length);


                clientSock.Connect(ipEnd);


                clientSock.Send(clientData);


                clientSock.Close();



                // FTServerCode fts = new FTServerCode();
                //fts.StartServer();

            }

            catch (Exception ex)
            {
                if (ex.Message == "A connection attempt failed because the connected party did not properly respond after a period of time, or established connection failed because connected host has failed to respond")
                {
                    //lblviewres.Text = "";
                    //lblviewres.Text = "No Such System Available Try other IP";
                }
                else
                {
                    if (ex.Message == "No connection could be made because the target machine actively refused it")
                    {
                        //lblviewres.Text = "";
                        // lblviewres.Text = "File Sending fail. Because server not running.";
                    }
                    else
                    {
                        // lblviewres.Text = "";
                        //lblviewres.Text = "File Sending fail." + ex.Message;
                    }
                }
            }
        }
        private void locking()
        {
            if (sys1 == 1) { ac1 = "y"; }
            if (sys1 == 2) { ac2 = "y"; }
            if (sys1 == 3) { ac3 = "y"; }
            if (sys1 == 4) { ac4 = "y"; }
            if (sys1 == 5) { ac5 = "y"; }
            if (sys1 == 6) { ac6 = ""; }
            if (sys1 == 7) { ac7 = ""; }
            if (sys1 == 8) { ac8 = ""; }
            if (sys1 == 9) { ac9 = ""; }
            if (sys1 == 10) { ac10 = ""; }
            if (sys2 == 1) { ac1 = "y"; }
            if (sys2 == 2) { ac2 = "y"; }
            if (sys2 == 3) { ac3 = "y"; }
            if (sys2 == 4) { ac4 = "y"; }
            if (sys2 == 5) { ac5 = "y"; }
            if (sys2 == 6) { ac6 = ""; }
            if (sys2 == 7) { ac7 = ""; }
            if (sys2 == 8) { ac8 = ""; }
            if (sys2 == 9) { ac9 = ""; }
            if (sys2 == 10) { ac10 = ""; }

        }
        private void unlocking()
        {
            if (sys1 == 1) { ac1 = ""; }
            if (sys1 == 2) { ac2 = ""; }
            if (sys1 == 3) { ac3 = ""; }
            if (sys1 == 4) { ac4 = ""; }
            if (sys1 == 5) { ac5 = ""; }
            if (sys1 == 6) { ac6 = ""; }
            if (sys1 == 7) { ac7 = ""; }
            if (sys1 == 8) { ac8 = ""; }
            if (sys1 == 9) { ac9 = ""; }
            if (sys1 == 10) { ac10 = ""; }
            if (sys2 == 1) { ac1 = ""; }
            if (sys2 == 2) { ac2 = ""; }
            if (sys2 == 3) { ac3 = ""; }
            if (sys2 == 4) { ac4 = ""; }
            if (sys2 == 5) { ac5 = ""; }
            if (sys2 == 6) { ac6 = ""; }
            if (sys2 == 7) { ac7 = ""; }
            if (sys2 == 8) { ac8 = ""; }
            if (sys2 == 9) { ac9 = ""; }
            if (sys2 == 10) { ac10 = ""; }

        }
        private void locking2()
        {

            if (sys1 == 6) { ac6 = "z"; }
            if (sys1 == 7) { ac7 = "z"; }
            if (sys1 == 8) { ac8 = "z"; }
            if (sys1 == 9) { ac9 = "z"; }
            if (sys1 == 10) { ac10 = "z"; }
            if (sys2 == 6) { ac6 = "z"; }
            if (sys2 == 7) { ac7 = "z"; }
            if (sys2 == 8) { ac8 = "z"; }
            if (sys2 == 9) { ac9 = "z"; }
            if (sys2 == 10) { ac10 = "z"; }

        }
        private void unlocking2()
        {

            if (sys1 == 6) { ac6 = ""; }
            if (sys1 == 7) { ac7 = ""; }
            if (sys1 == 8) { ac8 = ""; }
            if (sys1 == 9) { ac9 = ""; }
            if (sys1 == 10) { ac10 = ""; }
            if (sys2 == 6) { ac6 = ""; }
            if (sys2 == 7) { ac7 = ""; }
            if (sys2 == 8) { ac8 = ""; }
            if (sys2 == 9) { ac9 = ""; }
            if (sys2 == 10) { ac10 = ""; }

        }
        public void splitting()
        {
            //Split.Enabled = false;
            string filePath = "";


            //fileDes = fileDes.Replace("\\", "/");
            //while (fileDes.IndexOf("/") > -1)
            //{
            //    filePath += fileDes.Substring(0, fileDes.IndexOf("/") + 1);
            //    fileDes = fileDes.Substring(fileDes.IndexOf("/") + 1);
            //}


            //byte[] fileNameByte = Encoding.ASCII.GetBytes(fileDes);



            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] ipdata = enc.GetBytes(textBox2.Text);
            byte[] fileData = enc.GetBytes(textBox1.Text);
            clientData = new byte[4 + ipdata.Length + fileData.Length];
            //byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);
            ipdata.CopyTo(clientData, 0);
            fileData.CopyTo(clientData, 9);

            //fileNameLen.CopyTo(clientData, 0);
            //fileNameByte.CopyTo(clientData, 4);
            //fileData.CopyTo(clientData, 4 + fileNameByte.Length);
            int si = (int)Math.Ceiling((double)(clientData.Length / 3)); //clientData.Length / 3;



            double a = clientData.Length;
            double b = a / 10;
            string s = b.ToString();
            string[] s1 = s.Split('.');

            string c = Convert.ToString("." + s1[1]);
            double g = Convert.ToDouble(c);
            g = g * 10;
            double d = Convert.ToDouble(s1[0]) * 10;
            double f = d + g;
            int fsize = Convert.ToInt32(s1[0]);
            data1 = new byte[fsize + 1];
            data2 = new byte[fsize + 1];
            data3 = new byte[fsize + 1];
            data4 = new byte[fsize + 1];
            data5 = new byte[fsize + 1];
            data6 = new byte[fsize + 1];
            data7 = new byte[fsize + 1];
            data8 = new byte[fsize + 1];
            data9 = new byte[fsize + 1];
            data10 = new byte[fsize + Convert.ToInt32(g) + 1];
            wr = new byte[clientData.Length];
            byte[] add = Encoding.ASCII.GetBytes("0");
            Array.Copy(add, data1, 1);
            add = Encoding.ASCII.GetBytes("1");
            Array.Copy(add, data2, 1);
            add = Encoding.ASCII.GetBytes("2");
            Array.Copy(add, data3, 1);
            add = Encoding.ASCII.GetBytes("3");
            Array.Copy(add, data4, 1);
            add = Encoding.ASCII.GetBytes("4");
            Array.Copy(add, data5, 1);
            add = Encoding.ASCII.GetBytes("5");
            Array.Copy(add, data6, 1);
            add = Encoding.ASCII.GetBytes("6");
            Array.Copy(add, data7, 1);
            add = Encoding.ASCII.GetBytes("7");
            Array.Copy(add, data8, 1);
            add = Encoding.ASCII.GetBytes("8");
            Array.Copy(add, data9, 1);
            add = Encoding.ASCII.GetBytes("9");
            Array.Copy(add, data10, 1);
            string hi = Encoding.ASCII.GetString(data10, 0, 1);



            Array.Copy(clientData, 0, data1, 1, fsize);
            Array.Copy(clientData, fsize, data2, 1, fsize);
            Array.Copy(clientData, fsize + fsize, data3, 1, fsize);
            Array.Copy(clientData, fsize + fsize + fsize, data4, 1, fsize);
            Array.Copy(clientData, fsize + fsize + fsize + fsize, data5, 1, fsize);
            Array.Copy(clientData, fsize + fsize + fsize + fsize + fsize, data6, 1, fsize);
            Array.Copy(clientData, fsize + fsize + fsize + fsize + fsize + fsize, data7, 1, fsize);
            Array.Copy(clientData, fsize + fsize + fsize + fsize + fsize + fsize + fsize, data8, 1, fsize);
            Array.Copy(clientData, fsize + fsize + fsize + fsize + fsize + fsize + fsize + fsize, data9, 1, fsize);
            Array.Copy(clientData, fsize + fsize + fsize + fsize + fsize + fsize + fsize + fsize + fsize, data10, 1, fsize + Convert.ToInt32(g));




            //btnSend.Enabled = true;

        
        
        }
         FTServerCode112 objClass=new FTServerCode112();

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            objClass.StartServer();
        }
        class FTServerCode112
        {
            IPEndPoint ipEnd;
            Socket sock;
            string ser1;
            string fileDes, fileini;
            int len;
            public static string[] path = null;
            public FTServerCode112()
            {
                ipEnd = new IPEndPoint(IPAddress.Any, 6);
                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                sock.Bind(ipEnd);
            }
            public static string receivedPath;
            public static string curMsg = "Stopped";
            public static string fileName;
            public void StartServer()
            {
                try
                {

                    sock.Listen(100);


                    Socket clientSock = sock.Accept();

                    byte[] clientData = new byte[10];

                    int receivedBytesLen = clientSock.Receive(clientData);
                    curMsg = "Received";
                    fileName = Encoding.ASCII.GetString(clientData, 0, 1);
                    clientSock.Close();
                    StartServer();


                }
                catch (Exception ex)
                {
                    curMsg = "File Receving error.";
                }
            }

        }
       
    }
}