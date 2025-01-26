using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] list1 = new int[3][];

            list1[0] = new int[1];
            list1[1] = new int[2];
            list1[2] = new int[3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < list1[i].Length; j++)
                {
                    Console.Write("Enter Numbers:[{0}],[{1}]", i + 1, j + 1);
                    list1[i][j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
            }
            for (int i = 0;i < 3; i++)
                {
                    foreach (var item in list1[i])
                    {
                        Console.Write("\t{0}",item);
                    }
                Console.WriteLine();
            }
        }
    }
}
