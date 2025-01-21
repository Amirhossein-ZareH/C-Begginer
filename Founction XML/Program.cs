using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founction_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number1: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.Write("Enter Number2: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.Write("Enter Number3: ");
            float num3 = float.Parse(Console.ReadLine());

            Console.Write(Avg(num1,num2,num3));
            Console.WriteLine();
        }
     /// <summary>
     /// این کد برای محاسبه 3 تا عدد با میانگین است
     /// </summary>
     /// <param name="a">اول</param>
     /// <param name="b">دوم</param>
     /// <param name="c">سوم</param>
     /// <returns></returns>
    static float Avg(float a , float b, float c)
    {
        float sum = a + b + c;
        return sum / 3;
    }
        /// <summary>
        /// این کد برای محاسبه 2 تا عدد با میانگین است
        /// </summary>
        /// <param name="a">اول</param>
        /// <param name="b">دوم</param>
        /// <returns></returns>
    static float Avg(float a , float b)
    {
        float sum = a + b;
        return sum / 2;
    }
    }
}
