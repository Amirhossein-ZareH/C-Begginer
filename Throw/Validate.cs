using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw
{
    internal class Validate
    {
        public static void AvgValid(float avg)
        {
            if (avg >= 0 && avg <=20) 
            {
                Console.WriteLine("Avg is Valid");
            }
            else
            {
                throw new MyException("Avg is Not Valid");
            }
        }
    }
}
