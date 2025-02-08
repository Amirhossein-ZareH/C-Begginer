using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Printing_Star
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            for (int i = 0; i <= num1; i++)
            {
                for (int j = num2; j <= i; j++)
                {
                    Thread.Sleep(60);
                    if (i == j)
                    {
                        Console.Write("* ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
