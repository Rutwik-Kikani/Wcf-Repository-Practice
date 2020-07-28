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
    public partial class DataSetCache_MemoryDF : System.Web.UI.Page
    {
        private string _connectionStr = ConfigurationManager.ConnectionStrings["AdoDatabaseSampleDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoadData_Click(object sender, EventArgs e)
        {
            // Check if the DataSet is present in the cache
            // If the DataSet is not in the cache load data from the database into the DataSet
            if (Cache["Data"] == null)
            {
                using (SqlConnection con = new SqlConnection(_connectionStr))
                {
                    //Create instance of dataAdapter 
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM TBLPRODUCTINVENTORY", con);
                    //Create instance of DataSet for storing result in memory
                    DataSet dataSet = new DataSet();
                    //call fill() which automatically open connection and execute query and close connection
                    adapter.Fill(dataSet);

                    //Bind DataSet TO GridView
                    gvProducts.DataSource = dataSet;
                    gvProducts.DataBind();

                    // Store the DataSet in the Cache
                    Cache["Data"] = dataSet;
                    lblMessage.Text = "Data loaded from the Database";

                }
            }
            // If the DataSet is in the Cache
            else
            {
                //getting DataSet From Cache
                gvProducts.DataSource = (DataSet) Cache["Data"];
                gvProducts.DataBind();
                lblMessage.Text = "Data loaded from the Cache";
            }

        }

        protected void btnClearnCache_Click(object sender, EventArgs e)
        {
            // Check if the DataSet is present in the cache
            if (Cache["Data"] != null) { 
                //Remove DataSet From Cache
                Cache.Remove("Data");

                gvProducts.DataSource = null;
                gvProducts.DataBind();
                lblMessage.Text = "DataSet is removed from cache";

            }
            // If the DataSet is not in the Cache
            else
            {
                gvProducts.DataSource = null;
                gvProducts.DataBind();
                lblMessage.Text = "There is nothing to remove";
            }
        }
    }
}