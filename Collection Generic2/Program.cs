using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter id {0}: ",i+1);
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter name {0}: ",i+1);
                string name = Console.ReadLine();

                Console.Write("Enter lastname {0}: ", i + 1);
                string lname = Console.ReadLine();

                Console.Write("Enter age {0}: ", i + 1);
                int age = Convert.ToInt32(Console.ReadLine());

                Student student = new Student(id, name, lname, age);

                Console.Write("Enter Number of Courses you need: ");
                int count = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < count; j++)
                {
                    Lesson lesson = new Lesson();


                    Console.Write("Enter Code {0}-{1}: ",i,j);
                    lesson.CourseCode = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Name {0}-{1}: ",i,j);
                    lesson.CourseName = Console.ReadLine();

                    Console.Write("Enter Master {0}-{1}: ", i, j);
                    lesson.CourseMaster = Console.ReadLine();

                    Console.Write("Enter Unit {0}-{1}: ", i, j);
                    lesson.CourseUnit = Convert.ToInt32(Console.ReadLine());

                    student.AddCourse(lesson);
                    Console.Clear();

                }
                students.Add(student);
                Console.Clear();
            }
            foreach (var item in students)
            {
                item.InfoStudent();
                for (int k = 0;k < item.LessonsList.Count;k++)
                {
                    item.LessonsList[k].InfoCourse();
                }
            }
        }
    }
}
