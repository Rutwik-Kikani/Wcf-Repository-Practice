using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlDataSetDemo
{
    public partial class DataSetTable_CollectionPropDF : System.Web.UI.Page
    {
        private string _connectionStr = ConfigurationManager.ConnectionStrings["AdoDatabaseSampleDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                //Create instance of dataAdapter 
                SqlDataAdapter adapter = new SqlDataAdapter("spGetProductAndCategoriesData", con);
                //set adapter command type
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                //Create instance of DataSet for storing result in memory
                DataSet dataSet = new DataSet();
                //call fill() which automatically open connection and execute query and close connection
                adapter.Fill(dataSet);

                dataSet.Tables[0].TableName = "Products";
                dataSet.Tables[1].TableName = "Categories";

                ProductsGridView.DataSource = dataSet.Tables["Products"];
                ProductsGridView.DataBind();

                CategoryGridView.DataSource = dataSet.Tables["Categories"];
                CategoryGridView.DataBind();



            }
        }
    }
}