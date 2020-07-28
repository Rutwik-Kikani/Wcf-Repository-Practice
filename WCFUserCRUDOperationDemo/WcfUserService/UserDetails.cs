using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfUserService
{
    [DataContract]
    public class UserDetails
    {
        private int _userid;
        private string _username;
        private string _password;
        private string _country;
        private string _email;
        [DataMember]
        public int UserId
        {
            get { return _userid; }
            set { _userid = value; }
        }
        [DataMember]
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        [DataMember]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        [DataMember]
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        [DataMember]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
