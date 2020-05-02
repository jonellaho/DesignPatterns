using Adapter1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter1
{
    class EmployeeAdapter : ITarget
    {
        public List<string> GetEmployees()
        {
            EmployeeAdaptee adaptee = new EmployeeAdaptee();
            return adaptee.GetListOfEmployees();
        }
    }
}
