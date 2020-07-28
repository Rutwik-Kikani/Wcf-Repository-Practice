using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADODatabaseDemo
{
    public partial class AdoDatabasseTestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rutvik Kikani\source\repos\ADODatabaseDemo\ADODatabaseDemo\App_Data\Test.mdf;Integrated Security=True";
            try
            {
                using (con)
                {
                    string command = "Select * from Customer";
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        ListItem item = new ListItem();
                        item.Text = rdr["Name"].ToString();
                        ddlCustomers.Items.Add(item);
                    }
                    rdr.Close();


                }
            }
            catch (Exception ex)
            {
                Response.Write("Errors: " + ex.Message);
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rutvik Kikani\source\repos\ADODatabaseDemo\ADODatabaseDemo\App_Data\Test.mdf;Integrated Security=True";
            try
            {
                using (con)
                {
                    string command = "Select * from Customer";
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    GridViewCustomers.DataSource = rdr;
                    GridViewCustomers.DataBind();
                    rdr.Close();


                }
            }
            catch (Exception ex)
            {
                Response.Write("Errors: " + ex.Message);
            }
        }
    }
}