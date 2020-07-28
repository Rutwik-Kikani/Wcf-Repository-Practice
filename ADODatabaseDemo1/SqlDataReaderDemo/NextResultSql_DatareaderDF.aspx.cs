using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlDataReaderDemo
{
    public partial class NextResultSql_DatareaderDF : System.Web.UI.Page
    {
        private string _connectionStr = ConfigurationManager.ConnectionStrings["AdoDatabaseSampleDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBLPRODUCTINVENTORY;SELECT * FROM TBLPRODUCTCATEGORIES", con);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    ProductsGridView.DataSource = reader;
                    ProductsGridView.DataBind();

                    while (reader.NextResult())
                    {
                        CategoriesGridView.DataSource = reader;
                        CategoriesGridView.DataBind();
                    }
                }
            }
        }
    }
}