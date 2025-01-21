using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
        GetNumber:
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            goto GetNumber;
        }
    }
}
