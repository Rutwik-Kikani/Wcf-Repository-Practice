using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfUserService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class WcfUserService : IWcfUserService
    {
        private string _connectionStr = ConfigurationManager.ConnectionStrings["UserSampleDB"].ConnectionString;
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string InsertUserDetails(UserDetails userInfo)
        {
            string Message = "Default";
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText =
                    "INSERT INTO TBLUSER(USERNAME,PASSWORD,COUNTRY,EMAIL) VALUES(@USERNAME,@PASSWORD,@COUNTRY,@EMAIL)";
                cmd.Parameters.AddWithValue("@USERNAME", userInfo.UserName);
                cmd.Parameters.AddWithValue("@PASSWORD", userInfo.Password);
                cmd.Parameters.AddWithValue("@COUNTRY", userInfo.Country);
                cmd.Parameters.AddWithValue("@EMAIL", userInfo.Email);

                con.Open();
                int result = (int)cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    Message = userInfo.UserName + " Details inserted successfully !!";
                }
                else
                {
                    Message = userInfo.UserName + " Details not inserted successfully !!";
                }
            }
            return Message;

        }

        public DataSet SelectUserDetails()
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT * FROM TBLUSER", con);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);

                return dataSet;
            }
        }

        public bool DeleteUserDetails(UserDetails userInfo)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM TBLUSER " +
                                                "WHERE USERID = @USERID", con);
                cmd.Parameters.AddWithValue("@USERID", userInfo.UserId);
                con.Open();
                int result = (int)cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    return true;
                }

                return false;
            }
        }

        public DataSet GetUserDetails(UserDetails userInfo)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM TBLUSER " +
                                                            "WHERE USERID = @USERID", con);
                adapter.SelectCommand.Parameters.AddWithValue("@USERID", userInfo.UserId);

                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);

                return dataSet;
            }
        }

        public void UpdateUserTable(UserDetails userInfo)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText =
                    "UPDATE TBLUSER SET USERNAME = @USERNAME,PASSWORD = @PASSWORD,COUNTRY = @COUNTRY,EMAIL = @EMAIL " +
                    "WHERE USERID = @USERID";
                cmd.Parameters.AddWithValue("@USERID", userInfo.UserId);
                cmd.Parameters.AddWithValue("@USERNAME", userInfo.UserName);
                cmd.Parameters.AddWithValue("@PASSWORD", userInfo.Password);
                cmd.Parameters.AddWithValue("@COUNTRY", userInfo.Country);
                cmd.Parameters.AddWithValue("@EMAIL", userInfo.Email);

                con.Open();
                int result = (int)cmd.ExecuteNonQuery();
                //TODO : print message on console host;
            }
        }

    }
}
