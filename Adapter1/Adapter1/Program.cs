using Adapter1.Interfaces;
using System;
using System.Collections.Generic;

namespace Adapter1
{
    class Program
    {
        class Client
        {
            static void Main(string[] args)
            {
                ITarget adapter = new EmployeeAdapter();
                foreach (string employee in adapter.GetEmployees())
                {
                    Console.WriteLine(employee);
                }
                Console.ReadLine();
            }
        }
    }
}
