using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number;
            do
            {
                Console.Write("Enter Number:");
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;

            }while (number > 0);
            if (number < 0) 
            {
                Console.Write("bad number");
            }
            else
            {
                Console.WriteLine(sum);
            }
            Console.WriteLine();
        }
    }
}
