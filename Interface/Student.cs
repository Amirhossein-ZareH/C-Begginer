using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Student : IPerson
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Family { get ; set ; }
        public int Age { get; set; }

        public Student(int StudentId)
        {
            this.StudentId = StudentId;
        }

        public void Print()
        {
            Console.WriteLine("Student *******");
        }
    }
}
