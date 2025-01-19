using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErsBary
{
    internal class Employee : Person
    {
        public int EmployeeCode { get; set; }

        public Employee(int EmployeeCode,string Name, string LastName, string PhoneNumber, int Age):
            base(Name, LastName, PhoneNumber, Age)
        {
            this.EmployeeCode = EmployeeCode;
        }

        public void Print ()
        {
            Console.WriteLine("Code: {0}",EmployeeCode);
            PrintPersonInfo();
        }
    }
}
