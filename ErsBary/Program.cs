using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErsBary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1,"Programming","arshia","zare","09129391239",11);
            Student student2 = new Student(2,"Developer","akbar","haghighi","91340320209",21);

            Teacher teacher1 = new Teacher(100,"Riazy","Mehrdad","nebahat","34920019",32);

            Employee employee1 = new Employee(1000,"mehdi","soltani","123913900",21);

            student1.Print();

            Console.WriteLine("-------------------------");

            teacher1.Print();

            Console.WriteLine("-------------------------");

            employee1.Print();

            Console.WriteLine("-------------------------");

        }
    }
}