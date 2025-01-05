using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_and_Inheirited_Founction
{
    internal class Employees : Mother
    {
        public int EmployeeId { get; set; }
       
        public Employees(int EmployeeId, string Name, string LastName, string PhoneNumber, int Age) : base()
        {
            this.EmployeeId = EmployeeId;
        }
        public void Print()
        {
            Console.WriteLine("Id: {0}",EmployeeId);
        }
    }
}
