using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ViewSend : Form
    {
        public ViewSend()
        {
            InitializeComponent();
        }
        public string Enrg;
        public string Noofpack;
        public string packsize;
        private void ViewSend_Load(object sender, EventArgs e)
        {
            lblEnergy.Text = Enrg.ToString();
            lblNoofPack.Text = Noofpack.ToString();
            lblPackSize.Text = packsize.ToString();
        }
    }
}