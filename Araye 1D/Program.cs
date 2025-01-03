using System;
using static System.Console;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Araye_1D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Write("Your Lengh is : ");

            for (int i = 0; i < list1.Length; i++)
            {
                Console.Write(list1[i]);
            }
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }


        }
    }
}
