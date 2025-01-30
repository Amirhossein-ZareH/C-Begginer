using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverRide
{
    class Parent
    {
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("PhoneNumber: {0}\t\tAdress: {1}"
                ,PhoneNumber,Adress);
        }
    }
}
