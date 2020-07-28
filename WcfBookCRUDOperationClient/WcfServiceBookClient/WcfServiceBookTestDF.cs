using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfServiceBookClient
{
    public partial class WcfServiceBookTestDF : Form
    {

        WcfServiceBookCHClientHttp.BookServiceClient client =
            new WcfServiceBookCHClientHttp.BookServiceClient("BasicHttpBinding_IBookService");

        private int BookIdForUpdation,BookIdForDeletion;

        public WcfServiceBookTestDF()
        {
            InitializeComponent();
            //Testing purpose
            //lblTest.Text = client.GetData(152);
            //Testing purpose
            //DataSet ds = client.GetBookById(1);
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSave.Text.Equals("Save"))
                {
                    lblTest.Text = SaveBookInfo();
                    lblTest.ForeColor = Color.Green;
                }
                else
                {
                    lblTest.Text = UpdateBookInfo();
                    lblTest.ForeColor = Color.Green;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Reset();
            
              
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeleteBookInfo())
                {
                    lblTest.Text="Delete SuccessFully";
                    lblTest.ForeColor = Color.Green;
                }
                else
                {
                    lblTest.Text = "Some Problem !!";
                    lblTest.ForeColor = Color.OrangeRed;

                }
                Reset();
                lblTest.Text = "";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = client.GetBookByName(tbSearchBox.Text);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    PopulateDataGridView(dataSet);
                    lblTest.Text = "Here is the result";
                    lblTest.ForeColor = Color.Green;
                }
                else
                {
                    lblTest.Text = "Book With Name " + tbSearchBox.Text + " not Present !!";
                    lblTest.ForeColor = Color.OrangeRed;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
        private void dgvBookDetails_DoubleClick(object sender, EventArgs e)
        {
            if (dgvBookDetails.CurrentRow.Index != -1)
            {
                BookIdForDeletion = BookIdForUpdation = Convert.ToInt32(dgvBookDetails.CurrentRow.Cells[0].Value.ToString());
                tbBookName.Text = dgvBookDetails.CurrentRow.Cells[1].Value.ToString();
                tbAuthorName.Text = dgvBookDetails.CurrentRow.Cells[2].Value.ToString();
                tbCategoryName.Text = dgvBookDetails.CurrentRow.Cells[3].Value.ToString();
                tbTotalStock.Text = dgvBookDetails.CurrentRow.Cells[5].Value.ToString();
                btnSave.Text = "Update";
                btnDelete.Enabled = true;

            }
        }

        //************************Operation****************************************//
        private string SaveBookInfo()
        {
            string Message;
            WcfServiceBookCHClientHttp.Book  bookInfo = new WcfServiceBookCHClientHttp.Book();
            bookInfo.BookName = tbBookName.Text;
            bookInfo.AuthorName = tbAuthorName.Text;
            bookInfo.CategoryName = tbCategoryName.Text;
            bookInfo.TotalStock = int.Parse(tbTotalStock.Text.ToString());
            bookInfo.NumberInStock = int.Parse(tbTotalStock.Text.ToString());
            Message = client.InsertBookDetails(bookInfo);
            return Message;
        }

        private string UpdateBookInfo()
        {
            string Message;
            WcfServiceBookCHClientHttp.Book bookInfo = new WcfServiceBookCHClientHttp.Book();
            bookInfo.Id = BookIdForUpdation;
            bookInfo.BookName = tbBookName.Text;
            bookInfo.AuthorName = tbAuthorName.Text;
            bookInfo.CategoryName = tbCategoryName.Text;
            bookInfo.TotalStock = int.Parse(tbTotalStock.Text.ToString());
            bookInfo.NumberInStock = int.Parse(tbTotalStock.Text.ToString());
            Message = client.UpdateBookDetails(bookInfo);
            return Message;

        }

        private bool DeleteBookInfo()
        {
            bool deletebool = client.DeleteBookDetails(BookIdForDeletion);
            return deletebool;
        }
        private void Reset()
        {
            tbBookName.Text = tbCategoryName.Text = tbAuthorName.Text = tbTotalStock.Text = tbSearchBox.Text = String.Empty;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            BookIdForDeletion = BookIdForUpdation = 0;
            DataSet ds = new DataSet();
            ds = client.GetAllBookDetails();
            PopulateDataGridView(ds);
        }

        private void PopulateDataGridView(DataSet dataSet)
        {
            dgvBookDetails.DataSource = dataSet.Tables[0];
            dgvBookDetails.Columns[0].Visible = false;
        }

        
    }
}
