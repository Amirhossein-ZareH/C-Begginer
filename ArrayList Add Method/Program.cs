using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Add_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList();

            list1.Add(Console.ReadLine());

            foreach (var item in list1)
            {
                while (list1.Count <= 10)
                {
                    Console.Write(item);
                }
            }
            Console.WriteLine();
        }
    }
}
