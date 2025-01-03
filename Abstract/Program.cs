using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            Student student = new Student(1);
            Teacher teacher = new Teacher(10);
            Employee employee = new Employee(100);

            //Console.WriteLine(student.Avg(50, 20));
            //Console.WriteLine(teacher.Avg(50, 20));
            //Console.WriteLine(employee.Avg(50, 20));


            student.Print();
            teacher.Print();
            employee.Print();
        }
    }
}
