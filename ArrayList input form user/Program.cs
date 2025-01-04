using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_input_form_user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList();

            Console.Write("Enter Your Numbers: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            while (number >= 0) 
            {
                count++;
                list1.Add(number);
                Console.WriteLine("Your Num: {0}",count);
            }
            
        }
    }
}
