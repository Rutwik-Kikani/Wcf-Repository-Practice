using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MessageContractDemoClient
{
    public partial class EmployeeServiceTestDf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetEemployee_Click(object sender, EventArgs e)
        {
            EmployeeServiceHttp.IEmployeeService client = new EmployeeServiceHttp.EmployeeServiceClient();
            EmployeeServiceHttp.EmployeeRequest request =
                new EmployeeServiceHttp.EmployeeRequest(Convert.ToInt32(tbId.Text), "XxYyZz1AaBbCc");
            EmployeeServiceHttp.EmployeeInfo employee = client.GetEmployee(request);

            tbName.Text = employee.Name;
            tbGender.Text = employee.Gender;
            tbDateOfBirth.Text = employee.DOB.ToShortDateString();

            lblMessage.Text = "Employee retrieved";

        }

        protected void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            EmployeeServiceHttp.EmployeeInfo employee = new EmployeeServiceHttp.EmployeeInfo();
            employee.ID = Convert.ToInt32(tbId.Text);
            employee.Name = tbName.Text;
            employee.DOB = Convert.ToDateTime(tbDateOfBirth.Text);
            employee.Gender = tbGender.Text;

            EmployeeServiceHttp.IEmployeeService client = new EmployeeServiceHttp.EmployeeServiceClient();
            client.SaveEmployee(employee);

            lblMessage.Text = "Employee is Saved !!";

        }
    }
}