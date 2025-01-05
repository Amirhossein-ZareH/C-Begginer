using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_and_Inheirited_Founction
{
    internal class Mother
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }

        public Mother(string Name, string LastName, string PhoneNumber, int Age) 
        {
            this.Name = Name;       
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Age = Age;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name: {0}\tLastName: {1}\tPhoneNumber: {2}\tAge: {3}",
                Name, LastName, PhoneNumber, Age);
        }
    }
}
