﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CustomFaultDemoService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class DivideService : IDivideService
    {
        public int DivideTwoInteger(int n1, int n2)
        {
            try
            {
                return n1 / n2;
            }
            catch
            {
                MathFault mathFault = new MathFault();
                mathFault.Operation = "Divide";
                mathFault.ProblemType = "Divide by Zero";
                throw new FaultException<MathFault>(mathFault);
            }
           
        }
    }
}