using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Question
{
    internal class Child1 : Interface1, Interface2
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }

        public void Show()
        {
            Console.WriteLine("Show");
        }
    }
}
