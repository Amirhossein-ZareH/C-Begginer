using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // You can get range of random number from user with Conver class

            for (int i = 0; i < 50; i++)
            {
                int a = rand.Next(1, 10);
                int b = rand.Next(11, 21);
                int c = rand.Next(22, 33);
                int d = rand.Next(34, 45);
                int e = rand.Next(46, 57);
                int f = rand.Next(58, 69);
                Console.Write("Ressault: \t1. {0} \t2. {1}\t 3. {2}\t 4. {3}\t 5. {4}\t 6. {5}      [{6}]",a,b,c,d,e,f,i);
                Console.WriteLine();
            }

        }
    }
}
