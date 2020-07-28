using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataContractDemoClient.EmployeeServiceHttp;

namespace DataContractDemoClient
{
    public partial class EmployeeServiceTestDF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetEemployee_Click(object sender, EventArgs e)
        {
            EmployeeServiceHttp.EmployeeServiceClient client = new EmployeeServiceHttp.EmployeeServiceClient();
            EmployeeServiceHttp.Employee employee = client.GetEmployee(Convert.ToInt32(tbId.Text.ToString()));

            tbName.Text = employee.Name;
            tbGender.Text = employee.Gender;
            tbDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();

            lblMessage.Text = "Employee retrieved";

        }

        protected void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            EmployeeServiceHttp.Employee employee = new EmployeeServiceHttp.Employee();
            employee.ID = Convert.ToInt32(tbId.Text);
            employee.Name = tbName.Text;
            employee.DateOfBirth = Convert.ToDateTime(tbDateOfBirth.Text);
            employee.Gender = tbGender.Text;

            EmployeeServiceHttp.EmployeeServiceClient client = new EmployeeServiceHttp.EmployeeServiceClient(); 
            client.SaveEmployee(employee);

            lblMessage.Text = "Employee is Saved !!";


        }
    }
}