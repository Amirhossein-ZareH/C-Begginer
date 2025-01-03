using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Employee : Person
    {
        public int EmployeeCode { get; set; }

        public Employee(int EmployeeCode)
        {
            this.EmployeeCode = EmployeeCode;
        }
        public override void Print()
        {
            Console.WriteLine("Employee *****");
        }

        //public override float Avg(int a, int b)
        //{
        //    int sum = a * b;
        //    return sum / 2;
        //}
    }
}
