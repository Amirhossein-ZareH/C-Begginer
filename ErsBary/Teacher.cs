using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErsBary
{
    internal class Teacher:Person
    {
        public int MasterCode { get; set; }
        public string Degree { get; set; }

        public Teacher(int MasterCode, string Degree,string Name, string LastName, string PhoneNumber, int Age)
            :base(Name,LastName,PhoneNumber,Age)
        {
            this.MasterCode = MasterCode;
            this.Degree = Degree;
        }

        public void Print ()
        {
            Console.WriteLine("Code: {0}\tDegree: {1}",MasterCode,Degree);
            PrintPersonInfo();
        }
    }
}
