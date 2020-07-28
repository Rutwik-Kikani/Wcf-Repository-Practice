using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFUserCRUDOperationDemoClient.WcfUserServiceHttp;


namespace WCFUserCRUDOperationDemoClient
{
    public partial class UserTestForm : System.Web.UI.Page
    {
        WcfUserServiceHttp.WcfUserServiceClient client = 
            new WcfUserServiceHttp.WcfUserServiceClient("BasicHttpBinding_IWcfUserService");
        protected void Page_Load(object sender, EventArgs e)
        {
          Label1.Text=client.GetData(152);
          if (!IsPostBack)
          {
              showdata();
          }
        }

        protected void ImageButtonEdit_OnCommand(object sender, CommandEventArgs e)
        {
            Label1.Text = e.CommandArgument.ToString();
            int uId = int.Parse(e.CommandArgument.ToString());
            ViewState["UserId"] = uId;
            //set for update

            WcfUserServiceHttp.UserDetails userInfo = new WcfUserServiceHttp.UserDetails();
            userInfo.UserId = uId;
            DataSet ds = new DataSet();
            ds = client.GetUserDetails(userInfo);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Label1.Text =  ds.Tables[0].Rows[0]["UserID"].ToString();
                tbUserName.Text = ds.Tables[0].Rows[0]["UserName"].ToString();
                tbPassWord.Text = ds.Tables[0].Rows[0]["Password"].ToString();
                tbCountry.Text =  ds.Tables[0].Rows[0]["Country"].ToString();
                tbEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                btnSubmit.Text = "Update";
            }

        }

        protected void ImageButtonDelete_OnCommand(object sender, CommandEventArgs e)
        {
            Label1.Text = e.CommandArgument.ToString();
            int uId = int.Parse(e.CommandArgument.ToString());
            ViewState["UserId"] = uId;
            deleteuser(uId);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text.Equals("Update"))
            {
                updateuserdetails();
                reset();
            }
            else
            {
                insertuserdetail();
                showdata();
            }
        }

        //**********operation*********************//
        private void showdata()
        {
            DataSet ds = new DataSet();
            ds = client.SelectUserDetails();
            gvGridView.DataSource = ds;
            gvGridView.DataBind();
        }

        private void updateuserdetails()
        {
            WcfUserServiceHttp.UserDetails userInfo = new WcfUserServiceHttp.UserDetails();
            userInfo.UserId = int.Parse(ViewState["UserId"].ToString());
            userInfo.UserName = tbUserName.Text;
            userInfo.Password = tbPassWord.Text;
            userInfo.Country = tbCountry.Text;
            userInfo.Email = tbEmail.Text;
            client.UpdateUserTable(userInfo);
            showdata();
        }

        private void insertuserdetail()
        {
            WcfUserServiceHttp.UserDetails userInfo = new WcfUserServiceHttp.UserDetails();
            userInfo.UserName = tbUserName.Text;
            userInfo.Country = tbCountry.Text;
            userInfo.Email = tbUserName.Text;
            userInfo.Password = tbPassWord.Text;
            string result = client.InsertUserDetails(userInfo);
            lblMessage.Text = result;
            showdata();
        }
        private void deleteuser(int UserId)
        {
            WcfUserServiceHttp.UserDetails userInfo = new WcfUserServiceHttp.UserDetails();
            userInfo.UserId = UserId;
            client.DeleteUserDetails(userInfo);
            showdata();
        }

        private void reset()
        {
            tbUserName.Text = string.Empty;
            tbPassWord.Text = string.Empty;
            tbCountry.Text = string.Empty;
            tbEmail.Text = string.Empty;
            btnSubmit.Text = "Submit";
            showdata();
        }
    }
}