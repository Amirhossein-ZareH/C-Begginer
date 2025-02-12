using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number :");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (num >= 0) 
            {
                sum += num;
                Console.Write("Enter Number :");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
