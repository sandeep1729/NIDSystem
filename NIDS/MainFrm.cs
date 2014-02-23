using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void netWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NetAllDetails obj = new NetAllDetails();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void currentSystemInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentSystemInfo obj = new CurrentSystemInfo();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void currentSystemSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm obj = new MainForm();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void activeConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveConnections obj = new ActiveConnections();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void fileReciverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server obj = new Server();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
           
        }

        private void fileSenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client1 obj = new Client1();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void dataSendRecvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSndRecFrm obj = new DataSndRecFrm();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void dataSendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSend obj = new DataSend();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void dataRecvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceiveData obj = new ReceiveData();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void daaTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void suspectipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuspectIP obj = new SuspectIP();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transactionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDataTransfer obj = new AllDataTransfer();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are You Sure You want to close ", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            { }
        }
    }
}
