using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lname { get; set; }
       

        public User()
        {
        }

        public void Print()
        {
            Console.WriteLine("ID: {0}\tName: {1}\tFamily: {2}\t"
                , Id, Name, Lname );
        }
        public static implicit operator Parent(User user)
        {
            Parent parent = new Parent()
            {
                Id = user.Id,
                Name = user.Name,
                Lname = user.Lname,
            };
            return parent;
        }
    }
}
