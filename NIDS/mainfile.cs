using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnStartServer_Click(object sender, EventArgs e)
        {
            if (FTServerCode1.receivedPath != null)
            {
                backgroundWorker1.RunWorkerAsync();
               // backgroundWorker2.RunWorkerAsync();
               // backgroundWorker3.RunWorkerAsync();
                lblserver.BackColor = Color.LimeGreen;
            }
            else
            {
                MessageBox.Show("Please select file receiving path");
            }
        }

        private void BtnLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                FTServerCode1.receivedPath = fd.SelectedPath;
                FTServerCode2.receivedPath = fd.SelectedPath;
                FTServerCode3.receivedPath = fd.SelectedPath;

            }
        }
        FTServerCode1 obj1 = new FTServerCode1();
      //  FTServerCode2 obj2 = new FTServerCode2();
        //FTServerCode3 obj3 = new FTServerCode3();
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            obj1.StartServer();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FTServerCode1.filefrm1 == "0")
            {
                lblc11.BackColor = Color.LimeGreen;
                FTServerCode1.timedelay[0] += FTServerCode1.tcalc;
                //ac1 = "y";
            }
            else if (FTServerCode1.filefrm1 == "1")
            {
                FTServerCode1.timedelay[1] += FTServerCode1.tcalc;
                if (FTServerCode1.colc11 == null)
                {
                    FTServerCode1.timedelay[0] += FTServerCode1.tcalc;
                    lblc11.BackColor = Color.Blue;
                }

                lblc12.BackColor = Color.LimeGreen;
                // ac2 = "y";
            }
            else if (FTServerCode1.filefrm1 == "2")
            {
                FTServerCode1.timedelay[2] += FTServerCode1.tcalc;
                if (FTServerCode1.colc11 == null)
                {
                    FTServerCode1.timedelay[0] += FTServerCode1.tcalc;
                    lblc11.BackColor = Color.Blue;
                }
                if (FTServerCode1.colc12 == null)
                {
                    FTServerCode1.timedelay[1] += FTServerCode1.tcalc;

                    lblc12.BackColor = Color.Blue;
                }
                lblc13.BackColor = Color.LimeGreen;
                // ac3 = "y";
            }
            else if (FTServerCode1.filefrm1 == "3")
            {
                FTServerCode1.timedelay[3] += FTServerCode1.tcalc;
                if (FTServerCode1.colc11 == null)
                {
                    FTServerCode1.timedelay[0] += FTServerCode1.tcalc;
                    lblc11.BackColor = Color.Blue;
                }
                if (FTServerCode1.colc12 == null)
                {
                    FTServerCode1.timedelay[1] += FTServerCode1.tcalc;

                    lblc12.BackColor = Color.Blue;
                }
                if (FTServerCode1.colc13 == null)
                {
                    FTServerCode1.timedelay[2] += FTServerCode1.tcalc;
                    lblc13.BackColor = Color.Blue;
                }
                lblc14.BackColor = Color.LimeGreen;
                //ac4 = "y";
            }
            else if (FTServerCode1.filefrm1 == "4")
            {
                FTServerCode1.timedelay[4] += FTServerCode1.tcalc;
                if (FTServerCode1.colc11 == null)
                {
                    FTServerCode1.timedelay[0] += FTServerCode1.tcalc;
                    lblc11.BackColor = Color.Blue;
                }
                if (FTServerCode1.colc12 == null)
                {
                    FTServerCode1.timedelay[1] += FTServerCode1.tcalc;
                    lblc12.BackColor = Color.Blue;
                }
                if (FTServerCode1.colc13 == null)
                {
                    FTServerCode1.timedelay[2] += FTServerCode1.tcalc;
                    lblc13.BackColor = Color.Blue;
                }
                if (FTServerCode1.colc14 == null)
                {
                    FTServerCode1.timedelay[3] += FTServerCode1.tcalc;

                    lblc14.BackColor = Color.Blue;
                }
                lblc15.BackColor = Color.LimeGreen;
                //ac5 = "y";
            }
            else if (FTServerCode1.filefrm1 == "5")
            {
                FTServerCode1.timedelay[5] += FTServerCode1.tcalc;

                lblc16.BackColor = Color.LimeGreen;
                // ac6 = "y";
            }
            else if (FTServerCode1.filefrm1 == "6")
            {
                FTServerCode1.timedelay[6] += FTServerCode1.tcalc;

                if (FTServerCode1.colc16 == null)
                {

                    lblc16.BackColor = Color.Blue;
                }
                lblc17.BackColor = Color.LimeGreen;
                //ac7 = "y";
            }
            else if (FTServerCode1.filefrm1 == "7")
            {
                FTServerCode1.timedelay[7] += FTServerCode1.tcalc;
                if (FTServerCode1.colc16 == null)
                {
                    FTServerCode1.timedelay[6] += FTServerCode1.tcalc;
                    lblc16.BackColor = Color.Blue;
                }
                if (FTServerCode1.colc17 == null)
                {
                    FTServerCode1.timedelay[7] += FTServerCode1.tcalc;

                    lblc17.BackColor = Color.Blue;
                }
                lblc18.BackColor = Color.LimeGreen;
                //ac8 = "y";
            }
            else if (FTServerCode1.filefrm1 == "8")
            {
                FTServerCode1.timedelay[8] += FTServerCode1.tcalc;
                if (FTServerCode1.colc16 == null)
                {
                    FTServerCode1.timedelay[6] += FTServerCode1.tcalc;
                    lblc16.BackColor = Color.Blue;
                }
                if (FTServerCode1.colc17 == null)
                {
                    FTServerCode1.timedelay[7] += FTServerCode1.tcalc;
                    lblc17.BackColor = Color.Blue;
                }
                if (FTServerCode1.colc18 == null)
                {
                    FTServerCode1.timedelay[8] += FTServerCode1.tcalc;
                    lblc18.BackColor = Color.Blue;
                }
                lblc19.BackColor = Color.LimeGreen;
                //ac9 = "y";
            }
            else if (FTServerCode1.filefrm1 == "9")
            {
                FTServerCode1.timedelay[9] += FTServerCode1.tcalc;
                if (FTServerCode1.colc16 == null)
                {
                    FTServerCode1.timedelay[6] += FTServerCode1.tcalc;

                    lblc16.BackColor = Color.Blue;
                }
                if (FTServerCode1.colc17 == null)
                {
                    FTServerCode1.timedelay[7] += FTServerCode1.tcalc;

                    lblc17.BackColor = Color.Blue;
                }
                if (FTServerCode1.colc18 == null)
                {
                    FTServerCode1.timedelay[8] += FTServerCode1.tcalc;
                    lblc18.BackColor = Color.Blue;
                }
                if (FTServerCode1.colc19 == null)
                {
                    FTServerCode1.timedelay[9] += FTServerCode1.tcalc;
                    lblc19.BackColor = Color.Blue;
                }
                lblc110.BackColor = Color.LimeGreen;
                //ac10 = "y";
            }

            // send();
        }

   

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
           // obj2.StartServer();

        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            //obj3.StartServer();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Report_1 r = new Report_1();
            r.label11.Text = FTServerCode1.timedelay[0].ToString() + " MilliSeconds.";
            r.label12.Text = FTServerCode1.timedelay[1].ToString() + " MilliSeconds.";
            r.label13.Text = FTServerCode1.timedelay[2].ToString() + " MilliSeconds.";
            r.label14.Text = FTServerCode1.timedelay[3].ToString() + " MilliSeconds.";
            r.label15.Text = FTServerCode1.timedelay[4].ToString() + " MilliSeconds.";
            r.label16.Text = FTServerCode1.timedelay[5].ToString() + " MilliSeconds.";
            r.label17.Text = FTServerCode1.timedelay[6].ToString() + " MilliSeconds.";
            r.label18.Text = FTServerCode1.timedelay[7].ToString() + " MilliSeconds.";
            r.label19.Text = FTServerCode1.timedelay[8].ToString() + " MilliSeconds.";
            r.label20.Text = FTServerCode1.timedelay[9].ToString() + " MilliSeconds.";
            r.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //Report_For_Chennal_2 r = new Report_For_Chennal_2();
            //r.label11.Text = FTServerCode2.timedelay[0].ToString() + " MilliSeconds.";
            //r.label12.Text = FTServerCode2.timedelay[1].ToString() + " MilliSeconds.";
            //r.label13.Text = FTServerCode2.timedelay[2].ToString() + " MilliSeconds.";
            //r.label14.Text = FTServerCode2.timedelay[3].ToString() + " MilliSeconds.";
            //r.label15.Text = FTServerCode2.timedelay[4].ToString() + " MilliSeconds.";
            //r.label16.Text = FTServerCode2.timedelay[5].ToString() + " MilliSeconds.";
            //r.label17.Text = FTServerCode2.timedelay[6].ToString() + " MilliSeconds.";
            //r.label18.Text = FTServerCode2.timedelay[7].ToString() + " MilliSeconds.";
            //r.label19.Text = FTServerCode2.timedelay[8].ToString() + " MilliSeconds.";
           // r.label20.Text = FTServerCode2.timedelay[9].ToString() + " MilliSeconds.";
            //r.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //Report_For_Chennal_3 r = new Report_For_Chennal_3();
            //r.label11.Text = FTServerCode3.timedelay[0].ToString() + " MilliSeconds.";
            //r.label12.Text = FTServerCode3.timedelay[1].ToString() + " MilliSeconds.";
            //r.label13.Text = FTServerCode3.timedelay[2].ToString() + " MilliSeconds.";
            //r.label14.Text = FTServerCode3.timedelay[3].ToString() + " MilliSeconds.";
            //r.label15.Text = FTServerCode3.timedelay[4].ToString() + " MilliSeconds.";
            //r.label16.Text = FTServerCode3.timedelay[5].ToString() + " MilliSeconds.";
            //r.label17.Text = FTServerCode3.timedelay[6].ToString() + " MilliSeconds.";
            //r.label18.Text = FTServerCode3.timedelay[7].ToString() + " MilliSeconds.";
            //r.label19.Text = FTServerCode3.timedelay[8].ToString() + " MilliSeconds.";
            //r.label20.Text = FTServerCode3.timedelay[9].ToString() + " MilliSeconds.";
            //r.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    //Channel 1

    class FTServerCode1
    {
        IPEndPoint ipEnd;
        Socket sock;
        string ser1;
        string fileDes, fileini;
        int len;
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
        byte[] write;
        int fsize1, fsize2, fsize3, fsize4, fsize5, fsize6, fsize7, fsize8, fsize9, fsize10;
        double tstart;
        double tend;
       
        public static string[] path = null;
        public static string filefrm1;
        string akc;
        public FTServerCode1()
        {
            ipEnd = new IPEndPoint(IPAddress.Any, 5);
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            sock.Bind(ipEnd);
        }
        public static string receivedPath;
        public static string curMsg = "Stopped";
        public static string colc11;
        public static string colc12;
        public static string colc13;
        public static string colc14;
        public static string colc15;
        public static string colc16;
        public static string colc17;
        public static string colc18;
        public static string colc19;
        public static string colc110;
        public static double tcalc;
        public static double[] timedelay=new double[10];
        public void StartServer()
        {
            try
            {

                sock.Listen(100);


                Socket clientSock = sock.Accept();

                byte[] clientData = new byte[1024 * 15000];

                int receivedBytesLen = clientSock.Receive(clientData);
                curMsg = "Receiving data...";
                filefrm1 = Encoding.ASCII.GetString(clientData, 0, 1);
                tstart = Convert.ToDouble(DateTime.Now.Millisecond);
                if (filefrm1 == "0")
                {
                    colc11 = "R";
                    data1 = new byte[receivedBytesLen - 1];
                    Array.Copy(clientData, 1, data1, 0, receivedBytesLen - 1);
                    akc = "0";
                    fsize1 = receivedBytesLen - 1;
                    send();
                    tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                    tcalc = tend;
                    if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                    {
                        save();
                    }
                }
                else if (filefrm1 == "1")
                {
                    colc12 = "R";
                    data2 = new byte[receivedBytesLen - 1];
                    Array.Copy(clientData, 1, data2, 0, receivedBytesLen - 1);
                    akc = "1";
                    fsize2 = receivedBytesLen - 1;
                    send();
                    tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                    tcalc = tend;
                    if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                    {
                        save();
                    }
                }
                else if (filefrm1 == "2")
                {
                    colc13 = "R";
                    data3 = new byte[receivedBytesLen - 1];
                    Array.Copy(clientData, 1, data3, 0, receivedBytesLen - 1);
                    akc = "2";
                    fsize3 = receivedBytesLen - 1;
                    send();
                    tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                    tcalc = tend;
                    if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                    {
                        save();
                    }
                }
                else if (filefrm1 == "3")
                {
                    colc14 = "R";
                    data4 = new byte[receivedBytesLen - 1];
                    Array.Copy(clientData, 1, data4, 0, receivedBytesLen - 1);
                    akc = "3";
                    fsize4 = receivedBytesLen - 1;
                    send();
                    tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                    tcalc = tend;
                    if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                    {
                        save();
                    }
                }
                else if (filefrm1 == "4")
                {
                    colc15 = "R";
                    data5 = new byte[receivedBytesLen - 1];
                    Array.Copy(clientData, 1, data5, 0, receivedBytesLen - 1);
                    akc = "4";
                    fsize5 = receivedBytesLen - 1;
                    send();
                    tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                    tcalc = tend;
                    if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                    {
                        save();
                    }
                }
                else if (filefrm1 == "5")
                {
                    colc16 = "R";
                    data6 = new byte[receivedBytesLen - 1];
                    Array.Copy(clientData, 1, data6, 0, receivedBytesLen - 1);
                    akc = "5";
                    fsize6 = receivedBytesLen - 1;
                    send();
                    tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                    tcalc = tend;
                    if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                    {
                        save();
                    }
                }
                else if (filefrm1 == "6")
                {
                    colc17 = "R";
                    data7 = new byte[receivedBytesLen - 1];
                    Array.Copy(clientData, 1, data7, 0, receivedBytesLen - 1);
                    akc = "6";
                    fsize7 = receivedBytesLen - 1;
                    send();
                    tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                    tcalc = tend;
                    if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                    {
                        save();
                    }
                }
                else if (filefrm1 == "7")
                {
                    colc18 = "R";
                    data8 = new byte[receivedBytesLen - 1];
                    Array.Copy(clientData, 1, data8, 0, receivedBytesLen - 1);
                    akc = "7";
                    fsize8 = receivedBytesLen - 1;
                    send();
                    tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                    tcalc = tend;
                    if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                    {
                        save();
                    }
                }
                else if (filefrm1 == "8")
                {
                    colc19 = "R";
                    data9 = new byte[receivedBytesLen - 1];
                    Array.Copy(clientData, 1, data9, 0, receivedBytesLen - 1);
                    akc = "8";
                    fsize9 = receivedBytesLen - 1;
                    send();
                    tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                    tcalc = tend;
                    if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                    {
                        save();
                    }
                }
                else if (filefrm1 == "9")
                {
                    colc110 = "R";
                    data10 = new byte[receivedBytesLen - 1];
                    Array.Copy(clientData, 1, data10, 0, receivedBytesLen - 1);
                    akc = "9";
                    fsize10 = receivedBytesLen - 1;
                    send();
                    tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                    tcalc = tend;


                    if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                    {
                        save();
                    }
                }
                clientSock.Close();

                StartServer();

                curMsg = "Reeived & Saved file; Server Stopped.";



            }
            catch (Exception ex)
            {
                curMsg = "File Receving error.";
            }
        }
        private void save()
        {
            write = new byte[data1.Length + data2.Length + data3.Length + data4.Length + data5.Length + data6.Length + data7.Length + data8.Length + data9.Length + data10.Length];
            Array.Copy(data1, 0, write, 0, data1.Length);
            Array.Copy(data2, 0, write, fsize1, data2.Length);
            Array.Copy(data3, 0, write, fsize1 + fsize2, data3.Length);
            Array.Copy(data4, 0, write, fsize1 + fsize2 + fsize3, data4.Length);
            Array.Copy(data5, 0, write, fsize1 + fsize2 + fsize3 + fsize4, data5.Length);
            Array.Copy(data6, 0, write, fsize1 + fsize2 + fsize3 + fsize4 + fsize5, data6.Length);
            Array.Copy(data7, 0, write, fsize1 + fsize2 + fsize3 + fsize4 + fsize5 + fsize6, data7.Length);
            Array.Copy(data8, 0, write, fsize1 + fsize2 + fsize3 + fsize4 + fsize5 + fsize6 + fsize7, data8.Length);
            Array.Copy(data9, 0, write, fsize1 + fsize2 + fsize3 + fsize4 + fsize5 + fsize6 + fsize7 + fsize8, data9.Length);
            Array.Copy(data10, 0, write, fsize1 + fsize2 + fsize3 + fsize4 + fsize5 + fsize6 + fsize7 + fsize8 + fsize9, data10.Length);
            if (System.IO.Directory.Exists(receivedPath + "/SYS1") == false)
            {
                System.IO.Directory.CreateDirectory(receivedPath + "/SYS1");
            }
            int fileNameLen = BitConverter.ToInt32(write, 0);
            string fileName = Encoding.ASCII.GetString(write, 4, fileNameLen);

            BinaryWriter bWrite = new BinaryWriter(File.Open(receivedPath + "/SYS1/" + fileName, FileMode.Append)); ;
            bWrite.Write(write, 4 + fileNameLen, write.Length - 4 - fileNameLen);

            curMsg = "Saving file...";

            bWrite.Close();
        }
        public void send()
        {
            try
            {
                IPAddress[] ipAddress = Dns.GetHostAddresses("127.0.0.1");
                IPEndPoint ipEnd = new IPEndPoint(ipAddress[0], 6);
                Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                byte[] ackn = Encoding.ASCII.GetBytes(akc);
                clientSock.Connect(ipEnd);
                clientSock.Send(ackn);
                clientSock.Close();

            }

            catch (Exception ex)
            {
                if (ex.Message == "A connection attempt failed because the connected party did not properly respond after a period of time, or established connection failed because connected host has failed to respond")
                {
                    //lblError.Text = "";
                    //lblError.Text = "No Such System Available Try other IP";
                }
                else
                {
                    if (ex.Message == "No connection could be made because the target machine actively refused it")
                    {
                        //lblError.Text = "";
                        //lblError.Text = "File Sending fail. Because server not running.";
                    }
                    else
                    {
                        //lblError.Text = "";
                        //lblError.Text = "File Sending fail." + ex.Message;
                    }
                }
            }
        }
    }
}
//Chennal 2

class FTServerCode2
{
    IPEndPoint ipEnd;
    Socket sock;
    string ser1;
    string fileDes, fileini;
    int len;
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
    byte[] write;
    int fsize1, fsize2, fsize3, fsize4, fsize5, fsize6, fsize7, fsize8, fsize9, fsize10;
    public static string[] path = null;
    public static string filefrm2;
    string akc;
    double tstart;
    double tend;
    public FTServerCode2()
    {
        ipEnd = new IPEndPoint(IPAddress.Any, 7);
        sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        sock.Bind(ipEnd);
    }
    public static string receivedPath;
    public static string curMsg = "Stopped";
    public static string colc21;
    public static string colc22;
    public static string colc23;
    public static string colc24;
    public static string colc25;
    public static string colc26;
    public static string colc27;
    public static string colc28;
    public static string colc29;
    public static string colc210;
    public static double tcalc;
    public static double[] timedelay = new double[10];
    public void StartServer()
    {
        try
        {

            sock.Listen(100);


            Socket clientSock = sock.Accept();

            byte[] clientData = new byte[1024 * 15000];

            int receivedBytesLen = clientSock.Receive(clientData);
            tstart = Convert.ToDouble(DateTime.Now.Millisecond);
            curMsg = "Receiving data...";
            filefrm2 = Encoding.ASCII.GetString(clientData, 0, 1);
            if (filefrm2 == "0")
            {
                colc21 = "R";
                data1 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data1, 0, receivedBytesLen - 1);
                akc = "0";
                fsize1 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm2 == "1")
            {
                colc22 = "R";
                data2 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data2, 0, receivedBytesLen - 1);
                akc = "1";
                fsize2 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm2 == "2")
            {
                colc23 = "R";
                data3 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data3, 0, receivedBytesLen - 1);
                akc = "2";
                fsize3 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm2 == "3")
            {
                colc24 = "R";
                data4 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data4, 0, receivedBytesLen - 1);
                akc = "3";
                fsize4 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm2 == "4")
            {
                colc25 = "R";
                data5 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data5, 0, receivedBytesLen - 1);
                akc = "4";
                fsize5 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm2 == "5")
            {
                colc26 = "R";
                data6 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data6, 0, receivedBytesLen - 1);
                akc = "5";
                fsize6 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm2 == "6")
            {
                colc27 = "R";
                data7 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data7, 0, receivedBytesLen - 1);
                akc = "6";
                fsize7 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm2 == "7")
            {
                colc28 = "R";
                data8 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data8, 0, receivedBytesLen - 1);
                akc = "7";
                fsize8 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm2 == "8")
            {
                colc29 = "R";
                data9 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data9, 0, receivedBytesLen - 1);
                akc = "8";
                fsize9 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm2 == "9")
            {
                colc210 = "R";
                data10 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data10, 0, receivedBytesLen - 1);
                akc = "9";
                fsize10 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;


                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            clientSock.Close();

            StartServer();

            curMsg = "Reeived & Saved file; Server Stopped.";



        }
        catch (Exception ex)
        {
            curMsg = "File Receving error.";
        }
    }
    private void save()
    {
        write = new byte[data1.Length + data2.Length + data3.Length + data4.Length + data5.Length + data6.Length + data7.Length + data8.Length + data9.Length + data10.Length];
        Array.Copy(data1, 0, write, 0, data1.Length);
        Array.Copy(data2, 0, write, fsize1, data2.Length);
        Array.Copy(data3, 0, write, fsize1 + fsize2, data3.Length);
        Array.Copy(data4, 0, write, fsize1 + fsize2 + fsize3, data4.Length);
        Array.Copy(data5, 0, write, fsize1 + fsize2 + fsize3 + fsize4, data5.Length);
        Array.Copy(data6, 0, write, fsize1 + fsize2 + fsize3 + fsize4 + fsize5, data6.Length);
        Array.Copy(data7, 0, write, fsize1 + fsize2 + fsize3 + fsize4 + fsize5 + fsize6, data7.Length);
        Array.Copy(data8, 0, write, fsize1 + fsize2 + fsize3 + fsize4 + fsize5 + fsize6 + fsize7, data8.Length);
        Array.Copy(data9, 0, write, fsize1 + fsize2 + fsize3 + fsize4 + fsize5 + fsize6 + fsize7 + fsize8, data9.Length);
        Array.Copy(data10, 0, write, fsize1 + fsize2 + fsize3 + fsize4 + fsize5 + fsize6 + fsize7 + fsize8 + fsize9, data10.Length);
        if (System.IO.Directory.Exists(receivedPath + "/SYS2") == false)
        {
            System.IO.Directory.CreateDirectory(receivedPath + "/SYS2");
        }

        int fileNameLen = BitConverter.ToInt32(write, 0);
        string fileName = Encoding.ASCII.GetString(write, 4, fileNameLen);

        BinaryWriter bWrite = new BinaryWriter(File.Open(receivedPath + "/SYS2/" + fileName, FileMode.Append)); ;
        bWrite.Write(write, 4 + fileNameLen, write.Length - 4 - fileNameLen);

        curMsg = "Saving file...";

        bWrite.Close();
    }
    public void send()
    {
        try
        {
            IPAddress[] ipAddress = Dns.GetHostAddresses("127.0.0.1");
            IPEndPoint ipEnd = new IPEndPoint(ipAddress[0], 8);
            Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            byte[] ackn = Encoding.ASCII.GetBytes(akc);
            clientSock.Connect(ipEnd);
            clientSock.Send(ackn);
            clientSock.Close();

        }

        catch (Exception ex)
        {
            if (ex.Message == "A connection attempt failed because the connected party did not properly respond after a period of time, or established connection failed because connected host has failed to respond")
            {
                //lblError.Text = "";
                //lblError.Text = "No Such System Available Try other IP";
            }
            else
            {
                if (ex.Message == "No connection could be made because the target machine actively refused it")
                {
                    //lblError.Text = "";
                    //lblError.Text = "File Sending fail. Because server not running.";
                }
                else
                {
                    //lblError.Text = "";
                    //lblError.Text = "File Sending fail." + ex.Message;
                }
            }
        }
    }
}


////Chennal 3

class FTServerCode3
{
    IPEndPoint ipEnd;
    Socket sock;
    string ser1;
    string fileDes, fileini;
    int len;
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
    byte[] write;
    int fsize1, fsize2, fsize3, fsize4, fsize5, fsize6, fsize7, fsize8, fsize9, fsize10;
    public static string[] path = null;
    public static string filefrm3;
    string akc;
    double tstart;
    double tend;
    public FTServerCode3()
    {
        ipEnd = new IPEndPoint(IPAddress.Any, 9);
        sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        sock.Bind(ipEnd);
    }
    public static string receivedPath;
    public static string curMsg = "Stopped";
    public static string colc31;
    public static string colc32;
    public static string colc33;
    public static string colc34;
    public static string colc35;
    public static string colc36;
    public static string colc37;
    public static string colc38;
    public static string colc39;
    public static string colc310;
    public static double tcalc;
    public static double[] timedelay = new double[10];
    public void StartServer()
    {
        try
        {

            sock.Listen(100);


            Socket clientSock = sock.Accept();

            byte[] clientData = new byte[1024 * 15000];

            int receivedBytesLen = clientSock.Receive(clientData);
            tstart = Convert.ToDouble(DateTime.Now.Millisecond);
            curMsg = "Receiving data...";
            filefrm3 = Encoding.ASCII.GetString(clientData, 0, 1);
            if (filefrm3 == "0")
            {
                colc31 = "R";
                data1 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data1, 0, receivedBytesLen - 1);
                akc = "0";
                fsize1 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm3 == "1")
            {
                colc32 = "R";
                data2 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data2, 0, receivedBytesLen - 1);
                akc = "1";
                fsize2 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm3 == "2")
            {
                colc33 = "R";
                data3 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data3, 0, receivedBytesLen - 1);
                akc = "2";
                fsize3 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm3 == "3")
            {
                colc34 = "R";
                data4 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data4, 0, receivedBytesLen - 1);
                akc = "3";
                fsize4 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm3 == "4")
            {
                colc35 = "R";
                data5 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data5, 0, receivedBytesLen - 1);
                akc = "4";
                fsize5 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm3 == "5")
            {
                colc36 = "R";
                data6 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data6, 0, receivedBytesLen - 1);
                akc = "5";
                fsize6 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm3 == "6")
            {
                colc37 = "R";
                data7 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data7, 0, receivedBytesLen - 1);
                akc = "6";
                fsize7 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm3 == "7")
            {
                colc38 = "R";
                data8 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data8, 0, receivedBytesLen - 1);
                akc = "7";
                fsize8 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm3 == "8")
            {
                colc39 = "R";
                data9 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data9, 0, receivedBytesLen - 1);
                akc = "8";
                fsize9 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;
                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            else if (filefrm3 == "9")
            {
                colc310 = "R";
                data10 = new byte[receivedBytesLen - 1];
                Array.Copy(clientData, 1, data10, 0, receivedBytesLen - 1);
                akc = "9";
                fsize10 = receivedBytesLen - 1;
                send();
                tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                tcalc = tend;


                if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
                {
                    save();
                }
            }
            clientSock.Close();

            StartServer();

            curMsg = "Reeived & Saved file; Server Stopped.";



        }
        catch (Exception ex)
        {
            curMsg = "File Receving error.";
        }
    }
    private void save()
    {
        write = new byte[data1.Length + data2.Length + data3.Length + data4.Length + data5.Length + data6.Length + data7.Length + data8.Length + data9.Length + data10.Length];
        Array.Copy(data1, 0, write, 0, data1.Length);
        Array.Copy(data2, 0, write, fsize1, data2.Length);
        Array.Copy(data3, 0, write, fsize1 + fsize2, data3.Length);
        Array.Copy(data4, 0, write, fsize1 + fsize2 + fsize3, data4.Length);
        Array.Copy(data5, 0, write, fsize1 + fsize2 + fsize3 + fsize4, data5.Length);
        Array.Copy(data6, 0, write, fsize1 + fsize2 + fsize3 + fsize4 + fsize5, data6.Length);
        Array.Copy(data7, 0, write, fsize1 + fsize2 + fsize3 + fsize4 + fsize5 + fsize6, data7.Length);
        Array.Copy(data8, 0, write, fsize1 + fsize2 + fsize3 + fsize4 + fsize5 + fsize6 + fsize7, data8.Length);
        Array.Copy(data9, 0, write, fsize1 + fsize2 + fsize3 + fsize4 + fsize5 + fsize6 + fsize7 + fsize8, data9.Length);
        Array.Copy(data10, 0, write, fsize1 + fsize2 + fsize3 + fsize4 + fsize5 + fsize6 + fsize7 + fsize8 + fsize9, data10.Length);
        if (System.IO.Directory.Exists(receivedPath + "/SYS3") == false)
        {
            System.IO.Directory.CreateDirectory(receivedPath + "/SYS3");
        }

        int fileNameLen = BitConverter.ToInt32(write, 0);
        string fileName = Encoding.ASCII.GetString(write, 4, fileNameLen);

        BinaryWriter bWrite = new BinaryWriter(File.Open(receivedPath + "/SYS3/" + fileName, FileMode.Append)); ;
        bWrite.Write(write, 4 + fileNameLen, write.Length - 4 - fileNameLen);

        curMsg = "Saving file...";

        bWrite.Close();
    }
    public void send()
    {
        try
        {
            IPAddress[] ipAddress = Dns.GetHostAddresses("127.0.0.1");
            IPEndPoint ipEnd = new IPEndPoint(ipAddress[0], 10);
            Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            byte[] ackn = Encoding.ASCII.GetBytes(akc);
            clientSock.Connect(ipEnd);
            clientSock.Send(ackn);
            clientSock.Close();

        }

        catch (Exception ex)
        {
            if (ex.Message == "A connection attempt failed because the connected party did not properly respond after a period of time, or established connection failed because connected host has failed to respond")
            {
                //lblError.Text = "";
                //lblError.Text = "No Such System Available Try other IP";
            }
            else
            {
                if (ex.Message == "No connection could be made because the target machine actively refused it")
                {
                    //lblError.Text = "";
                    //lblError.Text = "File Sending fail. Because server not running.";
                }
                else
                {
                    //lblError.Text = "";
                    //lblError.Text = "File Sending fail." + ex.Message;
                }
            }
        }
    }
}
