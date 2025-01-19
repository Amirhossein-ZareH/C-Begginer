using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErsBary
{
    internal class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }

        public Person(string Name,string LastName,string PhoneNumber,int Age)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Age = Age;
        }

        public void PrintPersonInfo()
        {
            Console.WriteLine("Name: {0}\tFamily: {1}\tPhone: {2}\tAge: {3}",
                Name,LastName,PhoneNumber,Age);
        }
    }
}
