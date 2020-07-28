using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlInjectionDemo
{
    public partial class SimpleSql_InjectionDF : System.Web.UI.Page
    {
        private string _connectionStr = ConfigurationManager.ConnectionStrings["AdoDatabaseSampleDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBLPRODUCTINVENTORY", con);
                ProductsGridView.DataSource = cmd.ExecuteReader();
                ProductsGridView.DataBind();
            }
        }

        protected void GetProductsButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM TBLPRODUCTINVENTORY WHERE NAME LIKE '" + ProductNameTextBox.Text +
                                  "%'";
                cmd.Connection = con;
                ProductsGridView.DataSource = cmd.ExecuteReader();
                ProductsGridView.DataBind();
            }
        }

        //test1;
        //Enter letter "l" into the textbox and click Get Products button

        //test2
        //Enter " l'; Delete from tblProductInventory -- " string in textbox and then see what happen in db.
    }
}