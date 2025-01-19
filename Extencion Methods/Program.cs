using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Extencion_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine( DateTime.Now.ToShamsi());
            string name = "amir";
            name.Print();
        }
    }
}
