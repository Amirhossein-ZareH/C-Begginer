using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    internal class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        public Parent()
        {
        }

        public void Print()
        {
            Console.WriteLine("ID: {0}\tName: {1}\tFamily: {2}\tAge: {3}"
                ,Id,Name,Lname,Age);
            if (Age == 0) Console.WriteLine("Hanoz To Notfe Hasty");
        }
        

        public static explicit operator User(Parent parent)
        {
            User user = new User()
            {
                Id = parent.Id,
                Name = parent.Name,
                Lname = parent.Lname,
            };
            return user;
        }
    }
}
