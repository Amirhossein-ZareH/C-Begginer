using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Teacher : IPerson
    {
        public int TeacherCode { get; set; }
        public string Name { get ; set ; }
        public string Family { get; set; }
        public int Age { get; set; }

        public Teacher(int TeacherCode)
        {
            this.TeacherCode = TeacherCode;
        }

        public void Print()
        {
            Console.WriteLine("Teacher *******");
        }
        
    }
}
