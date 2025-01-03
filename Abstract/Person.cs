using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int  Age { get; set; }

        public Person()
        {
            
        }
        public Person(string Name,string Family,int Age)
        {
            this.Name = Name;
            this.Family = Family;
            this.Age = Age;
        }
        public abstract void Print();

        public float Avg(int a, int b)
        {
            int sum = a + b;
            return sum / 2;
        }
       
        
    }
}
