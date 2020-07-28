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
    public partial class Sql_StoredProcedureWithOutParamDF : System.Web.UI.Page
    {
        private string _connectionStr = ConfigurationManager.ConnectionStrings["AdoDatabaseSampleDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                //for creating stored procedure get reference to "https://www.c-sharpcorner.com/article/using-stored-procedures-with-Asp-Net/"
                //whatever they do in 'SqlManagementStudio' we do it in 'View->SQL Server Object Explorer'
                cmd.CommandText = "spAddEmployee";
                //Specify Sql command is Stored Procedure 
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Add input parameter to Cmd Object
                cmd.Parameters.AddWithValue("@Name", txtEmployeeName.Text);
                cmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedValue);
                cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);

                //Add the output parameter to the command object
                SqlParameter outPutParameter = new SqlParameter();
                outPutParameter.ParameterName = "@EmployeeId";
                outPutParameter.SqlDbType = System.Data.SqlDbType.Int;
                outPutParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outPutParameter);

                cmd.ExecuteNonQuery();

                // Retrieve the value of the output parameter
                string EmployeeId = outPutParameter.Value.ToString();
                lblMessage.Text = "Employee Id = " + EmployeeId;

            }
        }
    }
}