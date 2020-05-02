using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter1
{
    class EmployeeAdaptee
    {
        public List<string> GetListOfEmployees()
        {
            List<string> employees = new List<string>();
            employees.Add("Jonel");
            employees.Add("Xheljani");
            employees.Add("Edi");
            employees.Add("Nikolin");
            return employees;
        }
    }
}
