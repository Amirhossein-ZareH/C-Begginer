using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interface2 ch3 = new Child1();
            ch3.Show();
            
            Interface1 ch2 = new Child2();
            ch2.Print();

            Child2 ch4 = new Child2();
            ch4.Show(); 
            ch4.Print();
            ch4.Message();

            Interface2 ch5 = new Child2();
            ch5.Show();

            Interface3 ch6 = new Child2();
            ch6.Message();
        }
    }
}
