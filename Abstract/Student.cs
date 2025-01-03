using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Student : Person
    {
        public int StudentId { get; set; }

        public Student(int StudentId)
        {
            this.StudentId = StudentId;
        }

        public override void Print()
        {
            Console.WriteLine("Student *******");
        }
        //public override float Avg(int a, int b)
        //{
        //    int sum = a - b;
        //    return sum / 2;
        //}
    }
}
