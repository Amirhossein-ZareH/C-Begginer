using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErsBary
{
    internal class Student:Person
    {
        public int StudentId { get; set; }
        public string StudentField { get; set; }

        public Student(int StudentId,string StudentField,string Name, string LastName, string PhoneNumber, int Age) 
            : base(Name,LastName,PhoneNumber,Age)
        {
            this.StudentId = StudentId;
            this.StudentField = StudentField;
        }

        public void Print()
        {
            Console.WriteLine("Id: {0}\tField: {1}",StudentId,StudentField);
            PrintPersonInfo();
        }
    }
}
