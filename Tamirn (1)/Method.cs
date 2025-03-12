using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Method
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
        public static string Cop {  get; set; }

        public Method()
        {
            Cop = "Compony Amir";
        }
        public static void Info1()
        {
            Console.WriteLine("Compony Name: {0}",Cop);
        }
        public void Info()
        {
            Console.WriteLine("Your id is: {0}\tYour Name is: {1}\tYour LastName is: {2}\tYour age is: {3}",Id,Name,Lname,Age);
        }
        public void Setter(int Id,string Name,string Lname,int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Lname = Lname;
            this.Age = Age;
        }
        public void Setter(int Id,int Age)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public void Setter(int Id)
        {
            this.Id = Id;
        }
        public void Setter(string Name)
        {
            this.Name= Name;
        }
        public void Setter(string Name,string Lname)
        {
            this.Name= Name;
            this.Lname= Lname;
        }
        public string Getter(string Name)
        {
            return this.Name;
        }
        public string Getter1(string Lname)
        {
            return this.Lname;
        }
        public int Getter(int Id)
        {
            return this.Id;
        }
        public int Getter1(int Age)
        {
            return this.Age;
        }
    }
}