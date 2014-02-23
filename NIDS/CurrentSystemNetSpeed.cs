using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class CurrentSystemNetSpeed : Form
    {
        public CurrentSystemNetSpeed()
        {
            InitializeComponent();
        }

        private void CurrentSystemNetSpeed_Load(object sender, EventArgs e)
        {

            foreach (System.Net.NetworkInformation.NetworkInterface networkinterface in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {

                if (networkinterface.Name.ToLower() == "local area connection")
                {
                    break;
                }
                
            }
        }
           
            private void fun()
                {
               
                }
        }
       

    }
