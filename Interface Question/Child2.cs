using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Question
{
    internal class Child2 : Interface1, Interface2,Interface3
    {
        public void Message()
        {
            Console.WriteLine("Message1");
        }

        public void Print()
        {

            Console.WriteLine("Print1");
        }

        public void Show()
        {
            Console.WriteLine("Show1");
        }
    }
}
