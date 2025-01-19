using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entekhab_Vahed_Simple
{
    internal class Student
    {
        public int ShmreDaneshjo { get; set; }
        public string UserName  { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }

        public List<Course> courses = new List<Course>();
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Student() { }
        public Student (int ShmreDaneshjo, string UserName, string Family, int Age)
        {
            this.ShmreDaneshjo = ShmreDaneshjo;
            this.UserName = UserName;
            this.Family = Family;
            this.Age = Age;
        }
        public void Etelaat()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Id: {0}\tName: {1}\tLname: {2}\tAge: {3}",ShmreDaneshjo,UserName,Family,Age);
        }

    }
    
}
