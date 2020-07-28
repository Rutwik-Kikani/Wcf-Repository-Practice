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
    public partial class ExecuteScalarSql_CmdDF : System.Web.UI.Page
    {
        private string _connectionStr = ConfigurationManager.ConnectionStrings["AdoDatabaseSampleDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(PRODUCTID) FROM TBLPRODUCTINVENTORY", con);
                con.Open();
                int TotalRows = (int) cmd.ExecuteScalar();//return type is object so typecast it to int;
                Response.Write("Total no of rows "+TotalRows.ToString());
            }
        }
    }
}