using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlCommandDemo
{
    public partial class SimpleSql_CmdDF : System.Web.UI.Page
    {
        private string _connectionStr = ConfigurationManager.ConnectionStrings["AdoDatabaseSampleDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT PRODUCTID, NAME FROM TBLPRODUCTINVENTORY", con);
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }
    }
}