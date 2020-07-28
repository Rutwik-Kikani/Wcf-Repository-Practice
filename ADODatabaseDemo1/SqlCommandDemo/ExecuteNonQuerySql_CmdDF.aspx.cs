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
    public partial class ExecuteNonQuerySql_CmdDF : System.Web.UI.Page
    {
        private string _connectionStr = ConfigurationManager.ConnectionStrings["AdoDatabaseSampleDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();

                //Execute each block one at a time for others comment it 
                {
                    //Inserting new row;
                    //if you run this record is in database then you have an primary key violation error 
                    //Note Uncomment it while runing first time and then comment it again; otherwise it cause problem 
                    cmd.CommandText = "INSERT INTO TBLPRODUCTINVENTORY VALUES (4,'Mouse',350,15)";
                    cmd.Connection = con;
                    int insertedRowNo = cmd.ExecuteNonQuery(); //returns int of which row is affected in database
                    Response.Write(insertedRowNo.ToString() + " INSERTED </br>");
                    //see changes in database tbl
                }
                {
                    //Updating row;
                    cmd.CommandText = "UPDATE TBLPRODUCTINVENTORY SET QTYAVAILABLE = 45 WHERE PRODUCTID = 4";
                    cmd.Connection = con;
                    int uRowAffected = (int) cmd.ExecuteNonQuery();
                    Response.Write(uRowAffected.ToString() + " UPDATED </br>");
                    //see changes in database tbl
                }
                {
                    //Deleting row;
                    cmd.CommandText = "DELETE FROM TBLPRODUCTINVENTORY WHERE PRODUCTID = 4";
                    cmd.Connection = con;
                    int dRowAffected = (int) cmd.ExecuteNonQuery();
                    Response.Write(dRowAffected.ToString() + " DELETED</br>");
                    //see changes in database tbl
                }
            }
        }
    }
}