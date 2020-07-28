using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryBook
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string InsertBookDetails(Book bookInfo);

        [OperationContract]
        DataSet GetAllBookDetails();

        [OperationContract]
        bool DeleteBookDetails(int bookId);

        [OperationContract]
        string UpdateBookDetails(Book bookInfo);

        [OperationContract]
        DataSet GetBookById(int bookId);

        [OperationContract]
        DataSet GetBookByName(string bookInfoName);


    }

    
}
