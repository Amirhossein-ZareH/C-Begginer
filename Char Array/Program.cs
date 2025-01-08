using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = { 'a', 'm', 'i', 'r', 'h', 'o', 's', 's', 'i', 'n' };

            Console.Write(charArray.Length);
            foreach (var item in charArray)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            string name = "amirhossein";
            Console.Write(name);

            Console.WriteLine();
        }
    }
}
