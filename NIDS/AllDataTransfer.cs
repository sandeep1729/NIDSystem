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
    public partial class AllDataTransfer : Form
    {
        public AllDataTransfer()
        {
            InitializeComponent();
        }
        DataCls obj_data = new DataCls();
        private void AllDataTransfer_Load(object sender, EventArgs e)
        {
            try
            {

                DataSet ds = new DataSet();
                ds = obj_data.GetAlldata("select * from [DataReceiving]");
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
