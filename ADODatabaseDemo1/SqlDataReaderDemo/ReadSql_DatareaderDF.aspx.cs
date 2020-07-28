using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlDataReaderDemo
{
    public partial class ReadSql_DatareaderDF : System.Web.UI.Page
    {
        private string _connectionStr = ConfigurationManager.ConnectionStrings["AdoDatabaseSampleDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBLPRODUCTINVENTORY", con);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    //Create DataTable Structure and columns,This will be act as source for GridView
                    DataTable sTable = new DataTable();
                    sTable.Columns.Add("ID");
                    sTable.Columns.Add("Name");
                    sTable.Columns.Add("Qty");
                    sTable.Columns.Add("Price");
                    sTable.Columns.Add("DiscountedPrice");

                    //Read() will provide you to iterate over each row in one result set;
                    while (reader.Read())
                    {
                        //Calculate discount 10% price
                        int OriginalAmount = Convert.ToInt32(reader["UNITAMOUNT"]);
                        double DiscountedPrice = OriginalAmount * 0.9;

                        //populate DataTable column values from the DataReader OR create a single row for this iteration
                        DataRow dataRow = sTable.NewRow();
                        dataRow["ID"] = reader["PRODUCTID"];
                        dataRow["Name"] = reader["NAME"];
                        dataRow["Qty"] = reader["QTYAVAILABLE"];
                        dataRow["Price"] = reader["UNITAMOUNT"];
                        dataRow["DiscountedPrice"] = DiscountedPrice;

                        //add row to DataTable
                        sTable.Rows.Add(dataRow);
                    }
                    //Set sTable as DataSource for GridView
                    ProductsGridview.DataSource = sTable;
                    ProductsGridview.DataBind();
                }
            }
        }
    }
}