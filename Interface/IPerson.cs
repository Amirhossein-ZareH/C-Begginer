using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IPerson
    {
        string Name { get; set; }
        string Family { get; set; }
        int Age { get; set; }

        //Person()
        //{

        //}
        //Person(string Name, string Family, int Age)
        //{
        // this.Name = Name;
        // this.Family = Family;
        //this.Age = Age;
        // }
        void Print();

       


    }
}
