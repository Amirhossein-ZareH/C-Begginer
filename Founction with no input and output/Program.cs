using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founction_with_no_input_and_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            lastName(number);

            
        }
        /// <summary>
        /// For Printing Name
        /// </summary>
        static void Name()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Amir {0}",i);
            }
        }
        /// <summary>
        /// For Printing lastName
        /// </summary>
        /// <param name="count"></param>
        static void lastName(int count)
        {
            for (int i = 0;i < count;i++)
            {
                Console.WriteLine("Zare {0}", i);
            }
        }
    }
}
