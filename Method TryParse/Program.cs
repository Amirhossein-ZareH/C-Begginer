using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Number: ");
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Number Plz Not Other Things -_-\n");
            }
            Console.WriteLine();
        }
    }
}
