using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class DataSndRecFrm : Form
    {
        public DataSndRecFrm()
        {
            InitializeComponent();
        }
        TcpListener myList;
        TcpClient tcpclnt;
        Socket s;
        string str2 = "";
        Thread myth;
        string datarec = "";
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

                ASCIIEncoding asen = new ASCIIEncoding();

                s.Send(asen.GetBytes("The string was recieved by the server."));
                System.Threading.Thread.Sleep(100);
                myList.Stop();
                
                if (s.Connected != true)
                {
                    //s.Connected = false;
                    while (true)
                    {
                        ServerStarter();
                    }
                }
                else
                {
                    
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..... " + ex.StackTrace);
            }


        
        
        }
        private void DataSndRecFrm_Load(object sender, EventArgs e)
        {
            // Start Thread Session

            myth = new Thread(new System.Threading.ThreadStart(ServerStarter));
            myth.Start();
           // ServerStarter();
            textBox2.Text = str2;

        }
        public void GetClient()
        { 
        try{
            tcpclnt = new TcpClient();
                MessageBox.Show("Connecting.....");

                tcpclnt.Connect("127.0.0.1", 8001);
                string str3 = string.Empty;
                String str = textBox1.Text;
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

                if (tcpclnt.Connected == false)
                {
                    GetClient();
                
                }


            }
            catch { 
            
            
            }
        
        
        }
        Thread mythh;
        private void button1_Click(object sender, EventArgs e)
        {

            mythh = new Thread(new System.Threading.ThreadStart(GetClient));
            mythh.Start();
            myth = new Thread(new System.Threading.ThreadStart(ServerStarter));
            myth.Start();
            
            textBox2.Text = str2;
            
        }
    }
}
