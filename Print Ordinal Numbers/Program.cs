using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Ordinal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Sec Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int temp;
            if (num1 > num2)
            {
                temp = num1;
                num2 = num1;
                num2 = temp;
            }

            if (num1 % 2 == 0)
            {
                num1++;
            }
            if (num2 % 2 == 0)
            {
                num2--;
            }

            int sum = 0;
            for (int i = num1; i < num2; i+=2)
            {
                sum += i;
                if (i != num2)
                {
                    Console.Write(i + "+");
                }
                else 
                    Console.Write(i + "=");
            }
            Console.WriteLine(sum);
        }
    }
}
