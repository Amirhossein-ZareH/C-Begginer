using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Employee : IPerson
    {
        public int EmployeeCode { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }

        public Employee(int EmployeeCode)
        {
            this.EmployeeCode = EmployeeCode;
        }
        public void Print()
        {
            Console.WriteLine("Employee *****");
        }

       
    }
}
