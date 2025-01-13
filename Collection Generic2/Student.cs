using Collection_Generic2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collection_Generic2
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentLname { get; set; }
        public int StudentAge { get; set; }

        public List<Lesson> LessonsList = new List<Lesson>();

        public void AddCourse(Lesson lesson)
        {
            LessonsList.Add(lesson);
        }
            

        public Student(){}
        public Student(int StudentId,string StudentName,string StudentLname,int StudentAge)
        {
            this.StudentId = StudentId;
            this.StudentName = StudentName;
            this.StudentLname = StudentLname;
            this.StudentAge = StudentAge;
        }
        public void InfoStudent()
        {
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("Id is: {0}\tName is: {1}\tLastname is: {2}\tAge is: {3}",StudentId,StudentName,StudentLname,StudentAge);
        }

    }
}
