using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Reflection;

namespace Call_By_Refrence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Method1(x);
            Console.WriteLine("X is: {0}",x);

            //Method2(ref x);
            //Console.WriteLine("X is : {0}",x);

            //int y;
            //Method3(out y);
            //Console.WriteLine("X is : {0}",y);

        }
        static void Method1(int a)
        {
            a += 100;
            Console.WriteLine("A is : {0}",a);
        }
        static void Method2(ref int a)
        {
            a += 100;
        }
        static void Method3(out int a)
        {
            a = 5;
            a += 100;
        }
    }
}
