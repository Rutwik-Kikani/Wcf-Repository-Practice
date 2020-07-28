using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQLConnectionDemo
{
    public partial class SimpleCon_StrDF : System.Web.UI.Page
    {
        private string _connectionStr = @"Data Source=(localdb)\MSSqlLocalDb;Initial Catalog=AdoSampleDatabase;Integrated Security=True;Pooling=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBLPRODUCTINVENTORY", con);
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }
    }
}