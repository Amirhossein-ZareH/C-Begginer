using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverRide
{
    internal class Child:Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override void Print()
        {
            Console.WriteLine("Id: {0}\tName: {1}"
                ,Id,Name);
            
            base.Print();
        }
    }
}
