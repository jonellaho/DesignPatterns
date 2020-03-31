using System;
namespace Prototype
{
    
    public interface IEmployee
    {
        IEmployee Clone();
    }
   
    public class PermanentEmployee : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmploymentType { get; set; }

       
        public IEmployee Clone()
        {
            
            return this.MemberwiseClone() as IEmployee;

          
        }
    }

    public class TemporaryEmployee : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmploymentType { get; set; }

    
        public IEmployee Clone()
        {
             
            return this.MemberwiseClone() as IEmployee;

            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployee permanentEmployee = new PermanentEmployee();
            permanentEmployee.Name = "JONEL";
            permanentEmployee.Age = 21;
            permanentEmployee.EmploymentType = "Permanent";

           
            PermanentEmployee permanentEmployeeClone = (PermanentEmployee)permanentEmployee.Clone();
            permanentEmployeeClone.Name = "xHELJAN";
            permanentEmployeeClone.Age = 26;

            Console.WriteLine("Permanent Employee Details");
            Console.WriteLine("Name: {0}; Age: {1}; Employment Type: {2}", permanentEmployee.Name, permanentEmployee.Age, permanentEmployee.EmploymentType);

            Console.WriteLine("Cloned Permanent Employee Details");
            Console.WriteLine("Name: {0}; Age: {1}; Employment Type: {2}", permanentEmployeeClone.Name, permanentEmployeeClone.Age, permanentEmployeeClone.EmploymentType);

           

            Console.ReadLine();
        }
    }
}