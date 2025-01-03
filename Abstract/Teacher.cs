using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Teacher:Person
    {
        public int TeacherCode { get; set; }

        public Teacher(int TeacherCode)
        {
            this.TeacherCode = TeacherCode;
        }

        public override void Print()
        {
            Console.WriteLine("Teacher *******");
        }
        //public override float Avg(int a, int b)
        //{
        //    int sum = a % b;
        //    return sum / 2;
        //}
    }
}
