using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraye_1D_nameList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nameList = new string[5];
            
            for (int i = 0; i < 5; i++) 
            {
                Console.Write("Enter Some Names: ");
                nameList[i] = Convert.ToString(Console.ReadLine());
            }
            foreach (var item in nameList)
            {
                Console.Write("{0}",item);
            }
            Console.WriteLine();
        }
    }
}
