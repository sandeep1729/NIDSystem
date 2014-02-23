using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    class DataCls
    {
        public DataSet GetAlldata(string query)
        {
            SqlConnection con = new SqlConnection("user id=sa;password=trylogic;database=IntruderDeection");
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public int InsUpDel(string query)
        {
            SqlConnection con = new SqlConnection("user id=sa;password=trylogic;database=IntruderDeection");
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            return i;



        }
    }
}
