using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace @break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i--) 
            {
                if (i == -200) 
                {
                    break;
                }
                Console.Write("Amir"+i);
                Console.WriteLine();
                Thread.Sleep(50);
            }
        }
    }
}
