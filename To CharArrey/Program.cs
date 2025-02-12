using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_CharArrey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Text: ");
            string text = Console.ReadLine();

            char[] charArrey = text.ToCharArray();
            foreach (var item in charArrey) 
            {
                if (item ==  ' ')
                    Console.Write("\n");
                else 
                    Console.Write(item);
            }
            Console.WriteLine();

            string str = new string(charArrey);
            Console.Write(str);

            Console.WriteLine();

        }
    }
}
