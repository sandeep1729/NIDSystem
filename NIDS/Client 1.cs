using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Client1 : Form
    {
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
        public Client1()
        {
            InitializeComponent();
            
        }
        string colc1, colc2, colc3, colc4, colc5, colc6, colc7, colc8, colc9,colc10;
        private void Normal_File_Load(object sender, EventArgs e)
        {
            
            backgroundWorker1.RunWorkerAsync();
            //btnSend.Enabled = false;

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            txtFilePath.Text = "";
            openFileDialog1.ShowDialog();
            txtFilePath.Text = openFileDialog1.FileName;
            fileDes = openFileDialog1.FileName;
            if (fileDes == "openFileDialog1")
            {
                lblError.Text = "";
                lblError.Text = "Select a File first";
                txtFilePath.Text = "";
            }
            else
            {
                lblError.Text = "";
                len = fileDes.Length;
                fileini = fileDes.Substring(fileDes.IndexOf("\\") + 1);
                Split.Enabled = true;
            }

        }
        Random random = new Random();
        private int RandomNumber(int min, int max)
        {
            return random.Next(5);
        }
       // FTServerCode11 fts = new FTServerCode11();
        private void btnSend_Click(object sender, EventArgs e)
        {
            BtnSView.Enabled = true;
            
            if (ac1 != "y" ||ac2 != "y" || ac3 != "y" || ac4 != "y" || ac5 != "y")
            {
                if (cb1.Checked == true)
                {
                    int num = random.Next(5);
                    sys1 = num;
                    num = random.Next(5);
                    sys2 = num;
                    locking();
                }
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
                cb1.ForeColor = Color.PeachPuff ;
                cb1.Checked = false;
                //if (f1 != "" && f2 != "" && f3 != "" && f4 != "" && f5 != "")
                //{
                //    locking2();
                //}
                if (f1 == "1" && f2 == "1" && f3 == "1" && f4 == "1" && f5 == "1")
                {
                    MessageBox.Show("First Part is Completed","Message",MessageBoxButtons.OK,MessageBoxIcon.Information );
                }

                
            }
            else if (ac6 != "z" || ac7 != "z" || ac8 != "z" || ac9 != "z" || ac10 != "z")
            {
                if (cb1.Checked == true)
                {
                    int num = random.Next(5, 10);
                    sys1 = num;
                    num = random.Next(5, 10);
                    sys2 = num;
                    locking2();
                }

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
            //send();

            //fts.StartServer();


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
        public void send(byte[] sen)
        {
            try
            {
                IPAddress[] ipAddress = Dns.GetHostAddresses("172.16.19.210");
                IPEndPoint ipEnd = new IPEndPoint(ipAddress[0], 5);
                Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                byte[] fileNameByte = Encoding.ASCII.GetBytes(fileDes);
                byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);
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
                if (ex.Message == "A connection attempt failed because the connected party did not properly respond after a period of time, or established connection failed because connected host has failed to respond")
                {
                    lblError.Text = "";
                    lblError.Text = "No Such System Available Try other IP";
                }
                else
                {
                    if (ex.Message == "No connection could be made because the target machine actively refused it")
                    {
                        lblError.Text = "";
                        lblError.Text = "File Sending fail. Because server not running.";
                    }
                    else
                    {
                        lblError.Text = "";
                        lblError.Text = "File Sending fail." + ex.Message;
                    }
                }
            }
        }
        public void Rece()
        {
            try
            {
                IPAddress[] ipAddress = Dns.GetHostAddresses("127.0.0.1");
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
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }
        public void Buffer()
        {
            DirectoryInfo di = new DirectoryInfo("C:\\Buffer");
            if (di.Exists)
            {
                //MessageBox.Show("DAI");
            }
            else
            {

                di.Create();
            }
            FileInfo fi = new FileInfo("C:\\Buffer\\" + fileini + "");
            if (fi.Exists)
            {
            }
            else
            {
                File.Copy(fileDes, "C:\\Buffer\\" + fileini + "");

            }

        }
        //FTServerCode fts = new FTServerCode();
        private void btnReceive_Click(object sender, EventArgs e)
        {
            //BtnRView.Enabled = true;
            Rece();

           // fts.StartServer();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnReceivePath_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                //FTServerCode11.receivedPath = fd.SelectedPath;
                // btnReceive.Enabled = true;
                //lblviewres.Text = "";
                // txtReceivePath.Text = fd.SelectedPath;

            }
            else
            {
                // lblviewres.Text = "Select The Destination Folder";
            }





            //txtReceivePath.Text = "";
            //openFileDialog1.ShowDialog();
            //txtReceivePath.Text = openFileDialog1.FileName;
            //fileDes = openFileDialog1.FileName;
            //if (fileDes == "openFileDialog1")
            //{
            //    MessageBox.Show("Pease Select The Destination Path");
            //    txtFilePath.Text = "";
            //}
            //else
            //{
            //    len = fileDes.Length;
            //    fileini = fileDes.Substring(fileDes.IndexOf("\\") + 1);
            //}

        }

        private void BtnSView_Click(object sender, EventArgs e)
        {
            ViewSend vs = new ViewSend();
            vs.Enrg = senrg.ToString();
            vs.packsize = "1000";
            vs.Noofpack = spack.ToString();
            vs.Show();
            int num = random.Next(5, 10);

            label2.Text = num.ToString();

            //double a = 10874;
            //double b = a / 5;
            //string s = b.ToString();
            //string[] s1 = s.Split('.');

            //string c = Convert.ToString("." + s1[1]);
            //double g = Convert.ToDouble(c);
            //g = g * 5;
            //double d = Convert.ToDouble(s1[0]) * 5;
            //double f = d + g;
            //MessageBox.Show(b.ToString());
        }

        private void BtnRView_Click(object sender, EventArgs e)
        {
            //ViewReceive vr = new ViewReceive();
            //vr.Enrg = FTServerCode11.renrg.ToString();
            //vr.packsize = "1000";
            //vr.Noofpack = FTServerCode11.rpack.ToString();
            //vr.Show();
        }

        private void Split_Click(object sender, EventArgs e)
        {
            Split.Enabled = false;
            string filePath = "";


            fileDes = fileDes.Replace("\\", "/");
            while (fileDes.IndexOf("/") > -1)
            {
                filePath += fileDes.Substring(0, fileDes.IndexOf("/") + 1);
                fileDes = fileDes.Substring(fileDes.IndexOf("/") + 1);
            }


            byte[] fileNameByte = Encoding.ASCII.GetBytes(fileDes);


            byte[] fileData = File.ReadAllBytes(filePath + fileDes);
            clientData = new byte[4 + fileNameByte.Length + fileData.Length];
            byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);

            fileNameLen.CopyTo(clientData, 0);
            fileNameByte.CopyTo(clientData, 4);
            fileData.CopyTo(clientData, 4 + fileNameByte.Length);
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
            string hi = Encoding.ASCII.GetString(data10,0,1);



            Array.Copy(clientData,0, data1,1, fsize);
            Array.Copy(clientData, fsize, data2, 1, fsize);
            Array.Copy(clientData, fsize + fsize, data3, 1, fsize);
            Array.Copy(clientData, fsize + fsize + fsize, data4, 1, fsize);
            Array.Copy(clientData, fsize + fsize + fsize + fsize, data5, 1, fsize);
            Array.Copy(clientData, fsize + fsize + fsize + fsize + fsize, data6, 1, fsize);
            Array.Copy(clientData, fsize + fsize + fsize + fsize + fsize + fsize, data7, 1, fsize);
            Array.Copy(clientData, fsize + fsize + fsize + fsize + fsize + fsize + fsize, data8, 1, fsize);
            Array.Copy(clientData, fsize + fsize + fsize + fsize + fsize + fsize + fsize + fsize, data9, 1, fsize);
            Array.Copy(clientData, fsize + fsize + fsize + fsize + fsize + fsize + fsize + fsize + fsize, data10, 1, fsize + Convert.ToInt32(g));




            btnSend.Enabled = true;
        }
        FTServerCode11 obj1 = new FTServerCode11();
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           obj1.StartServer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FTServerCode11.curMsg == "Received")
            {
               // FTServerCode11.curMsg = "";
                if (FTServerCode11.fileName == "0")
                {
                    lbls1.BackColor = Color.LimeGreen;
                    ac1 = "y";
                    colc1 = "y";
                }
                else if (FTServerCode11.fileName == "1")
                {
                    if (colc1 != "y")
                    {

                        lbls1.BackColor = Color.Blue;
                    }
                    lbls2.BackColor = Color.LimeGreen;
                    colc2 = "y";
                    ac2 = "y";
                }
                else if (FTServerCode11.fileName == "2")
                {
                    if (colc1 != "y")
                    {

                        lbls1.BackColor = Color.Blue;
                    }
                    if (colc2 != "y")
                    {

                        lbls2.BackColor = Color.Blue;
                    }
                    lbls3.BackColor = Color.LimeGreen;
                    colc3 = "y";
                    ac3 = "y";
                }
                else if (FTServerCode11.fileName == "3")
                {
                    if (colc1 != "y")
                    {

                        lbls1.BackColor = Color.Blue;
                    }
                    if (colc2 != "y")
                    {

                        lbls2.BackColor = Color.Blue;
                    }
                    if (colc3 != "y")
                    {

                        lbls3.BackColor = Color.Blue;
                    }
                    lbls4.BackColor = Color.LimeGreen;
                    colc4 = "y";
                    ac4 = "y";
                }
                else if (FTServerCode11.fileName == "4")
                {
                    if (colc1 != "y")
                    {

                        lbls1.BackColor = Color.Blue;
                    }
                    if (colc2 != "y")
                    {

                        lbls2.BackColor = Color.Blue;
                    }
                    if (colc3 != "y")
                    {

                        lbls3.BackColor = Color.Blue;
                    }
                    if (colc4 != "y")
                    {

                        lbls4.BackColor = Color.Blue;
                    }
                    lbls5.BackColor = Color.LimeGreen;
                    colc5 = "y";
                    ac5 = "y";
                }
                else if (FTServerCode11.fileName == "5")
                {
                    if (colc1 != "y")
                    {

                        lbls1.BackColor = Color.Blue;
                    }
                    if (colc2 != "y")
                    {

                        lbls2.BackColor = Color.Blue;
                    }
                    if (colc3 != "y")
                    {

                        lbls3.BackColor = Color.Blue;
                    }
                    if (colc4 != "y")
                    {

                        lbls4.BackColor = Color.Blue;
                    }
                    if (colc5 != "y")
                    {

                        lbls5.BackColor = Color.Blue;
                    }
                    lbls6.BackColor = Color.LimeGreen;
                    colc6 = "y";
                    ac6 = "y";
                }
                else if (FTServerCode11.fileName == "6")
                {
                    if (colc6 != "y")
                    {

                        lbls6.BackColor = Color.Blue;
                    }
                    lbls7.BackColor = Color.LimeGreen;
                    colc7 = "y";
                    ac7 = "y";
                }
                else if (FTServerCode11.fileName == "7")
                {
                    if (colc6 != "y")
                    {

                        lbls6.BackColor = Color.Blue;
                    }
                    if (colc7 != "y")
                    {

                        lbls7.BackColor = Color.Blue;
                    }
                    lbls8.BackColor = Color.LimeGreen;
                    colc8 = "y";
                    ac8 = "y";
                }
                else if (FTServerCode11.fileName == "8")
                {
                    if (colc6 != "y")
                    {

                        lbls6.BackColor = Color.Blue;
                    }
                    if (colc7 != "y")
                    {

                        lbls7.BackColor = Color.Blue;
                    }
                    if (colc8 != "y")
                    {

                        lbls8.BackColor = Color.Blue;
                    }
                    lbls9.BackColor = Color.LimeGreen;
                    colc9 = "y";
                    ac9 = "y";
                }
                else if (FTServerCode11.fileName == "9")
                {
                    if (colc6 != "y")
                    {

                        lbls6.BackColor = Color.Blue;
                    }
                    if (colc7 != "y")
                    {

                        lbls7.BackColor = Color.Blue;
                    }
                    if (colc8 != "y")
                    {

                        lbls8.BackColor = Color.Blue;
                    }
                    if (colc9 != "y")
                    {

                        lbls9.BackColor = Color.Blue;
                    }
                    lbls10.BackColor = Color.LimeGreen;
                    colc10 = "y";
                    ac10 = "y";
                }
                Application.DoEvents();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            cb1.ForeColor = Color.OrangeRed;
        }
     

    }
    class FTServerCode11
    {
        IPEndPoint ipEnd;
        Socket sock;
        string ser1;
        string fileDes, fileini;
        int len;
        public static string[] path = null;
        public FTServerCode11()
        {
            try
            {
                ipEnd = new IPEndPoint(IPAddress.Any, 6);
                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                sock.Bind(ipEnd);

            }
            catch (Exception ems)
            {
                Application.Exit();
                
            }
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

