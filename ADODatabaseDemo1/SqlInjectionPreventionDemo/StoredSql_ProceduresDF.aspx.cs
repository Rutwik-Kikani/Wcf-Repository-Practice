using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlInjectionPreventionDemo
{
    public partial class StoredSql_ProceduresDF : System.Web.UI.Page
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

                cmd.Connection = con;
                //for creating stored procedure get reference to "https://www.c-sharpcorner.com/article/using-stored-procedures-with-Asp-Net/"
                //whatever they do in 'SqlManagementStudio' we do it in 'View->SQL Server Object Explorer'
                cmd.CommandText = "spGetProductsByName";
                //Specify Sql command is Stored Procedure 
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductName", ProductNameTextBox.Text + "%");
                ProductsGridView.DataSource = cmd.ExecuteReader();
                ProductsGridView.DataBind();
            }
        }
    }
}