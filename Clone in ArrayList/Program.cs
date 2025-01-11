using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone_in_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList(){  "Amir" , "puria"};
            ArrayList list2 = (ArrayList)list1.Clone();


            foreach (var item in list1)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine("****************************");
            foreach (var item in list2)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
