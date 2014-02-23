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
    public partial class ReceiveData : Form
    {
        public ReceiveData()
        {
            InitializeComponent();
        }
        string SendIP = "";
        string comingip = "";
        TcpListener myList;
        TcpClient tcpclnt;
        Socket s;
        string str2 = "";
        Thread myth;
        string datarec = "";
        bool iresult = false;
        bool iResult;
        DataCls obj_data = new DataCls();
        FTServerCode112 obj1 = new FTServerCode112();
        public bool checking(string ipaddress)
        {
            DataCls obj_data = new DataCls();
            DataSet ds = new DataSet();
            ds = obj_data.GetAlldata("select * from TotalALLSignatures where [IPAdd1]='" + ipaddress + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                //textBox3.Text = ds.Tables[0].Rows[0][5].ToString();
                //textBox4.Text = "Active";
               iresult= true;
            }
            else
            {
               // textBox3.Text ="Suspective";
                //textBox4.Text = "Action Closed";
                iresult= false;
            }
            return iresult;
        
        }
        public void ServerStarter()
        {
            try
            {

                IPAddress ipAd = IPAddress.Parse("127.0.0.1");

                myList = new TcpListener(ipAd, 8001);

                myList.Start();
                s = myList.AcceptSocket();

                byte[] b = new byte[1024 * 10];

                int k = s.Receive(b);

                for (int i = 0; i < k; i++)

                    str2 = str2 + Convert.ToChar(b[i]).ToString();
                // textBox2.Text = str2;
                iresult = checking(str2);
                if (iresult == true)
                {

                    ASCIIEncoding asen = new ASCIIEncoding();
                    s.Send(asen.GetBytes("Thank u for Contacting."));
                    System.Threading.Thread.Sleep(100);
                    myList.Stop();
                    iResult= true;
                    obj1.SEnderIP = str2;
                    obj1.StartServer();
                   // backgroundWorker1.RunWorkerAsync();
                }
                else
                {
                    ASCIIEncoding asen = new ASCIIEncoding();
                    s.Send(asen.GetBytes("sorry U r not Authenticated user."));
                    System.Threading.Thread.Sleep(100);
                    myList.Stop();
                    iResult= false;
                    string InsertDetails = "insert into [SaveALlRequests] values('" + SendIP + "','" + str2 + "','" + DateTime.Now.ToShortDateString() + "','Closed','Suspective')";
                    obj_data.InsUpDel(InsertDetails);
                    //obj1.StartServer();
                }
                //if (s.Connected != true)
                //{
                //    //s.Connected = false;
                //    while (true)
                //    {
                //        ServerStarter();
                //    }
                //}
                //else
                //{

                //}



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error..... " + ex.StackTrace);
                iResult= false;
            }




        }
       
        private void ReceiveData_Load(object sender, EventArgs e)
        {
          
            string sysname = Dns.GetHostName();
            IPHostEntry ip = Dns.GetHostByName(sysname);
            label1.Text = ip.AddressList[0].ToString();
            SendIP = ip.AddressList[0].ToString();
           
                myth = new Thread(new System.Threading.ThreadStart(ServerStarter));
                myth.Start();
                System.Threading.Thread.Sleep(2000);
            if (iResult)
            {
              //  MessageBox.Show("Data Receiving Starts");
                //backgroundWorker1.RunWorkerAsync();
            }
            else if(iResult==false)
            {
               // string InsertDetails = "insert into [SaveALlRequests] values('"+SendIP+"','"+str2+"','"+DateTime.Now.ToShortDateString()+"','Closed','Suspective')";
                //obj_data.InsUpDel(InsertDetails);
            }
        }
        byte[] bbb=new byte[1];
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           //// if (iResult == true)
           // {
              //  obj1.StartServer();
              //  bbb = FTServerCode112.data1;
                           // }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = File.ReadAllText(@"C:\Users\Public\\murali.txt"); ;
                textBox2.Text = obj1.textBox2;
                textBox3.Text = obj1.textBox3;
                textBox4.Text = obj1.textBox4;
                string InsertData = "insert into [DataReceiving] values('"+textBox2.Text+"','"+label1.Text+"','"+textBox3.Text+"','"+DateTime.Now.ToShortDateString()+"','"+textBox1.Text+"','"+textBox4.Text+"')";
                obj_data.InsUpDel(InsertData);
            }
            catch { 
            
            
            }
        }
    }
    class FTServerCode112
    {
        IPEndPoint ipEnd;
        Socket sock;
        string ser1;
        string fileDes, fileini;
        int len;
      public static  byte[] data1=new byte[1];
        byte[] data2 = new byte[1];
        byte[] data3 = new byte[1];
        byte[] data4 = new byte[1];
        byte[] data5 = new byte[1];
        byte[] data6 = new byte[1];
        byte[] data7 = new byte[1];
        byte[] data8 = new byte[1];
        byte[] data9 = new byte[1];
        byte[] data10 = new byte[1];
 public   static byte[] write;
        int fsize1, fsize2, fsize3, fsize4, fsize5, fsize6, fsize7, fsize8, fsize9, fsize10;
        double tstart;
        double tend;

        public static string[] path = null;
        public static string filefrm1;
        string akc;

        string comingIP = "";
        public   FTServerCode112()
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
        public static double[] timedelay = new double[10];
        public string SEnderIP = "";
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
                    ASCIIEncoding enc = new ASCIIEncoding();
                    
                    Array.Copy(clientData, 1, data1, 0, receivedBytesLen - 1);
                    comingIP= enc.GetString(clientData, 1, 9);
                    //signature checking
                  
                    
                        akc = "0";
                        fsize1 = receivedBytesLen - 1;
                        send();
                       
                        tend = tstart - Convert.ToDouble(DateTime.Now.Millisecond) / 1000;
                        tcalc = tend;
                        save();  
                   
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
                    save();
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
                    save();
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
                    save();
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
                    save();
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
                    save();
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
                    save();
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
                    save();
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

                    save(); 
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
                save();


            }
            catch (Exception ex)
            {
                curMsg = "File Receving error.";
            }
        }
        bool iresult = false;
     public  string textBox3="";
     public  string textBox4 = "";
     public  string textBox1 = "";
     public string textBox2 = "";
        public bool checking(string ipaddress)
        {
            textBox2 = ipaddress;
            DataCls obj_data = new DataCls();
            DataSet ds = new DataSet();
            ds = obj_data.GetAlldata("select * from TotalALLSignatures where [IPAdd1]='" + ipaddress + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                textBox3 = ds.Tables[0].Rows[0][5].ToString();
                textBox4 = "Active";
                return true;
            }
            else
            {
                textBox3 = "Suspective";
                textBox4 = "Action Closed";
                return false;
            }

        }
      //  FTServerCode112 objcls = new FTServerCode112();
        public void save()
        {
            ASCIIEncoding enc1 = new ASCIIEncoding();
              comingIP= enc1.GetString(data1, 0, 9);
                    //signature checking
              textBox1 = comingIP;
             // FTServerCode112 obj_cls = new FTServerCode112();
              if (checking(comingIP) == true)
              {
                 
                  if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
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

                     // ASCIIEncoding snc = new ASCIIEncoding();
                      //FTServerCode112.textBox1 = snc.GetString(write);
                      int fileNameLen = BitConverter.ToInt32(write, 0);
                      string fileName = Encoding.ASCII.GetString(write, 1, 9);
                      ASCIIEncoding enc = new ASCIIEncoding();
                      comingIP = enc.GetString(write, 0, 9);
                      FileStream ss = File.Create(@"C:\Users\Public\\murali.txt");
                      ss.Write(write, 0, write.Length);
                      ss.Close();

                  }
              }
              else
              {
                  if (data1 != null && data2 != null && data3 != null && data4 != null && data5 != null && data6 != null && data7 != null && data8 != null && data9 != null && data10 != null)
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

                    //  ASCIIEncoding snc = new ASCIIEncoding();
                      

                  }
              
              }
            //if (System.IO.Directory.Exists(receivedPath + "/SYS1") == false)
            //{
            //    System.IO.Directory.CreateDirectory(receivedPath + "/SYS1");
            //}
         
           //BinaryWriter bWrite = new BinaryWriter(File.Create("c:/murali New/murali.txt" , FileMode.Open)); ;
           // bWrite.Write(write, 0,write.Length);
        
           // curMsg = enc.GetString(write); ;

          // bWrite.Close();
        }
        public void send()
        {
            try
            {
                IPAddress[] ipAddress = Dns.GetHostAddresses(SEnderIP);
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
