using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array_With_Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] name = new char[6][];

            name[0] = new char[3];
            name[1] = new char[4];
            name[2] = new char[5];
            name[3] = new char[5];
            name[4] = new char[5];
            name[5] = new char[5];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < name[i].Length; j++)
                {
                    Console.Write("Enter Your Names [{0}][{1}] : ", i + 1, j + 1);
                    name[i][j] = Convert.ToChar(Console.ReadLine());
                }
            }
            for (int i = 0; i < 6; i++)
            {
                foreach (char item in name[i])
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
    }
}
