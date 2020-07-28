using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfClassLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DumWcfService" in both code and config file together.
    public class DumWcfService : IDumWcfService
    {
        public string GetText()
        {
            StreamReader reader = new StreamReader(@"C:\Users\Rutvik Kikani\source\repos\WcfBindingDemo\WcfClassLibrary\Data\TextFile1.txt");
            return reader.ReadLine();
        }

        public int MultiplyTwoInteger(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        public int AddTwoInteger(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
