using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverRide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Child child1 = new Child();

            child1.Id = 1;
            child1.Name = "amir"; 
            child1.PhoneNumber = "1234567890";
            child1.Adress = "iran - urmia";

            child1.Print();

            Console.WriteLine();
            Child child2 = new Child();
            child2.Id = 2;
            child2.Name = "arshia";
            child2.PhoneNumber = "1234567320";
            child2.Adress = "iran - urmia";

            child2.Print();
        }
    }
}
