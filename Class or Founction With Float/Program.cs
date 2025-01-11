using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_or_Founction_With_Float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your First Num: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.Write("Enter Your Second Num: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.Write("Enter Your Third Num: ");
            float num3 = float.Parse(Console.ReadLine());

            float avg = Avg(num1 , num2 , num3); 
            Console.WriteLine(avg);
        }
        static float Avg(float a, float b, float c)
        {
            float avg = a + b + c;
            return avg / 3;
        }
    }
}
