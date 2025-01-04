using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Arraye_2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 4];
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Enter Some Numbers [{0},{1}] : ",i,j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();

            Console.Clear();

            for (int i = 0;i < 3; i++)
            {
                for (int j = 0;j < 4; j++)
                {
                    Console.Write(a[i,j]+ " " );
                }
                Console.WriteLine();
            }

        }
    }
}
