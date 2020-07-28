using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfUserService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWcfUserService
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string InsertUserDetails(UserDetails userInfo);

        [OperationContract]
        DataSet SelectUserDetails();

        [OperationContract]
        bool DeleteUserDetails(UserDetails userInfo);

        [OperationContract]
        DataSet GetUserDetails(UserDetails userInfo);

        [OperationContract]
        void UpdateUserTable(UserDetails userInfo);

    }

}
