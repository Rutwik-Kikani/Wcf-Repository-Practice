using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryBook
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class BookService : IBookService
    {
        private string _connectionStr = ConfigurationManager.ConnectionStrings["BookSampleDB"].ConnectionString;
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string InsertBookDetails(Book bookInfo)
        {
            string Message = "default";
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText =
                    "INSERT INTO TBLBOOK(BOOKNAME,AUTHORNAME,CATEGORYNAME,DATEADDED,TOTALSTOCK,NUMBERINSTOCK) " +
                    "VALUES(@BOOKNAME,@AUTHORNAME,@CATEGORYNAME,@DATEADDED,@TOTALSTOCK,@NUMBERINSTOCK)";
                cmd.Parameters.AddWithValue("@BOOKNAME", bookInfo.BookName);
                cmd.Parameters.AddWithValue("@AUTHORNAME", bookInfo.AuthorName);
                cmd.Parameters.AddWithValue("@CATEGORYNAME", bookInfo.CategoryName);
                cmd.Parameters.AddWithValue("@DATEADDED", DateTime.Now);
                cmd.Parameters.AddWithValue("@TOTALSTOCK", bookInfo.TotalStock);
                cmd.Parameters.AddWithValue("@NUMBERINSTOCK", bookInfo.NumberInStock);

                con.Open();
                int result = (int)cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    Message = bookInfo.BookName + " added successfully ";
                    Console.WriteLine(bookInfo.BookName + " added successfully ");
                }
                else
                {
                    Message = bookInfo.BookName + " not added ";
                    Console.WriteLine(bookInfo.BookName + " not added ");
                }
            }
            return Message;

        }

        public DataSet GetAllBookDetails()
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM TBLBOOK ORDER BY DATEADDED DESC", con);

                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);

                Console.WriteLine("DataSet of All Books return successfully ");

                return dataSet;

            }

        }

        public bool DeleteBookDetails(int bookId)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM TBLBOOK " +
                                  "WHERE ID = @BOOKID";
                cmd.Parameters.AddWithValue("@BOOKID", bookId);

                con.Open();
                int result = (int)cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    Console.WriteLine("Book with id " + bookId.ToString() + " Deleted successfully ");
                    return true;

                }
                Console.WriteLine("Book with id " + bookId.ToString() + " not Deleted ");
                return false;

            }
        }

        public string UpdateBookDetails(Book bookInfo)
        {
            string Message = "uDefault";
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE TBLBOOK SET BOOKNAME = @BOOKNAME," +
                                  "AUTHORNAME = @AUTHORNAME,CATEGORYNAME = @CATEGORYNAME," +
                                  "DATEADDED = @DATEADDED,TOTALSTOCK = @TOTALSTOCK," +
                                  "NUMBERINSTOCK = @NUMBERINSTOCK WHERE ID = @BOOKID";
                cmd.Parameters.AddWithValue("@BOOKID", bookInfo.Id);
                cmd.Parameters.AddWithValue("@BOOKNAME", bookInfo.BookName);
                cmd.Parameters.AddWithValue("@AUTHORNAME", bookInfo.AuthorName);
                cmd.Parameters.AddWithValue("@CATEGORYNAME", bookInfo.CategoryName);
                cmd.Parameters.AddWithValue("@DATEADDED", DateTime.Now);
                cmd.Parameters.AddWithValue("@TOTALSTOCK", bookInfo.TotalStock);
                cmd.Parameters.AddWithValue("@NUMBERINSTOCK", bookInfo.NumberInStock);

                con.Open();
                int result = (int)cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    Message = bookInfo.BookName + " successfully updated";
                }
                else
                {
                    Message = bookInfo.BookName + " not updated  !!";
                }

            }
            return Message;
        }

        public DataSet GetBookById(int bookId)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM TBLBOOK " +
                                                            "WHERE ID = @BOOKID ORDER BY DATEADDED DESC", con);
                adapter.SelectCommand.Parameters.AddWithValue("@BOOKID", bookId);

                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count != 0)
                    Console.WriteLine("DataSet of BookId:" + bookId.ToString() + " return successfully ");
                else
                    Console.WriteLine("Null DataSet  return ");


                return dataSet;
            }
        }

        public DataSet GetBookByName(string bookInfoName)
        {
            using (SqlConnection con = new SqlConnection(_connectionStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("spSearchBookByName", con);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@BOOKNAME", bookInfoName);

                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count != 0)
                    Console.WriteLine("DataSet of BookName:" + bookInfoName.ToString() + " return successfully ");
                else
                    Console.WriteLine("Null DataSet  return ");


                return dataSet;
            }
        }
    }
}
