using Boxing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent1 = new Parent() 
            {
                Id = 1,
                Name = "Foo",
                Lname = "Bar",
                Age = 22
            };

            User user1 = new User()
            {
                Id = 1,
                Name = "xd",
                Lname= "gg"
            };

            parent1.Print();
            Console.WriteLine("-----------------------------------");

            user1.Print();
            Console.WriteLine("-----------------------------------");

            //Console.WriteLine("***********************************");
            //user1 = (User)parent1;
            //user1.Print();

            Console.WriteLine("***********************************");
            parent1 = user1;
            parent1.Print();








            //boxing
            int num = 26;

            object obj = 75;
            //Implicity
            obj = num;

            Console.WriteLine(obj);

            //unboxing
            int number = 26;

            object obg = 75;
            //Explicity
            number = (int)obg;

            Console.WriteLine(number);
        }
    }
}
