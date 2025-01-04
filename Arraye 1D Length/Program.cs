using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraye_1D_Length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list1 = new int[5];

            for (int i = 0; i < list1.Length; i++)
            {
                Console.Write("Enter Your Numbers: a[{0}]", i+1);
                list1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < list1.Length; i++)
            {
                list1[i] = i;
            }
            for (int i = 0;i < list1.Length; i++)
            {
                Console.WriteLine(list1[i]+"\t");
            }
        }
    }
}
