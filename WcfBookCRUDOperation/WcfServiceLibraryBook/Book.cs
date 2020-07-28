using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryBook
{
    [DataContract]
    public class Book
    {
        private int _id;
        private string _bookName;
        private string _authorName;
        private int _numberInStock;
        private int _totalStock;
        private string _categoryName;
        private DateTime _dateAdded;
        [DataMember(Order = 1)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [DataMember(Order = 2)]
        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }
        [DataMember(Order = 3)]
        public string AuthorName
        {
            get { return _authorName; }
            set { _authorName = value; }
        }
        [DataMember(Order = 4)]
        public string CategoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }
        
        public DateTime DateAdded
        {
            get { return _dateAdded; }
            set { _dateAdded = value; }
        }
        [DataMember(Order = 5)]
        public int NumberInStock
        {
            get { return _numberInStock; }
            set { _numberInStock = value; }
        }
        [DataMember(Order = 6)]
        public int TotalStock
        {
            get { return _totalStock; }
            set { _totalStock = value; }
        }
        

    }
}
