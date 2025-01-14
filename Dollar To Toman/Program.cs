using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dollar_To_Toman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Money In Dollar: ");
            float dollar = float.Parse(Console.ReadLine());

            //dollar.Dollar();
            Console.WriteLine("Your Money In Toman Is : {0}",((int)dollar).Dollar());
        }
    }
}
