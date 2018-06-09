using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FaultServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public int Div(int value1, int value2)
        {
            if (value2 == 0)
                throw new FaultException("Value 2 cannot be 0");
            else
            return value1 / value2;
        }
    }
}
