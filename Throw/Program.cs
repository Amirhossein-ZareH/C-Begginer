using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Avg; ");
            float avg = float.Parse(Console.ReadLine());

            try
            {
                Validate.AvgValid(avg);
            }
            catch (MyException ex)
            {
                Console.WriteLine("Error : {0}",ex.Message);
            }
        }
    }
}
