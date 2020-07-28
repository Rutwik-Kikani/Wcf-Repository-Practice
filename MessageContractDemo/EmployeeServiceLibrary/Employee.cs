using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServiceLibrary
{
    [MessageContract(IsWrapped = true,
        WrapperName = "EmployeeRequestObject",
        WrapperNamespace = "http://EmployeeServiceLibrary.com/Employee")]
    public class EmployeeRequest
    {
        [MessageBodyMember(Namespace = "http://EmployeeServiceLibrary.com/Employee")]
        public int EmployeeId { get; set; }
        [MessageBodyMember(Namespace = "http://EmployeeServiceLibrary.com/Employee")]
        public string LicenseKey { get; set; }

    }

    [MessageContract(IsWrapped = true,
        WrapperName = "EmployeeInfoObject",
        WrapperNamespace = "http://EmployeeServiceLibrary.com/Employee")]
    public class EmployeeInfo
    {
        public EmployeeInfo()
        {

        }

        public EmployeeInfo(Employee employee)
        {
            this.ID = employee.Id;
            this.Name = employee.Name;
            this.Gender = employee.Gender;
            this.DOB = employee.DateOfBirth;
        }
        [MessageBodyMember (Order = 1,Namespace= "http://EmployeeServiceLibrary.com/Employee")]
        public int ID { get; set; }
        [MessageBodyMember(Order = 2, Namespace = "http://EmployeeServiceLibrary.com/Employee")]
        public string Name { get; set; }
        [MessageBodyMember(Order = 3, Namespace = "http://EmployeeServiceLibrary.com/Employee")]
        public string Gender { get; set; }
        [MessageBodyMember(Order = 4, Namespace = "http://EmployeeServiceLibrary.com/Employee")]
        public DateTime DOB { get; set; }
    }

    [DataContract(Namespace = "http://EmployeeServiceLibrary.com/2020/03/23/Employee")]
    public class Employee
    {

        private int _id;
        private string _name;
        private string _gender;
        private DateTime _dateOfBirth;
        [DataMember(Name = "ID", Order = 1)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [DataMember(Order = 2)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [DataMember(Order = 3)]
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        [DataMember(Order = 4)]
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
    }
}
