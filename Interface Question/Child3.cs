using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Question
{
    internal class Child3 : Interface4
    {
        public void Print()
        {
            Console.WriteLine("Print2");
        }

        public void Send()
        {
            Console.WriteLine("Send2");
        }
    }
}
