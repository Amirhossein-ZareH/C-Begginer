using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entekhab_Vahed_Simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i <= 1;i++)
            {
                //Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("Shomare DaneshJoi Ra Vared Konid : ");
                int id = Convert.ToInt32(Console.ReadLine());

                //Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Nam Khod Ra Vared Konid : ");
                string name = Console.ReadLine();

                //Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write("Family Khod Ra Vared Konid : ");
                string family = Console.ReadLine();

                //Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Write("Sen Khod Ra Vared Konid : ");
                int age = Convert.ToInt32(Console.ReadLine());

                Student student = new Student(id,name,family,age);

                Console.Write("Tedad Vahed Ra Vared Konid : ");
                int count = Convert.ToInt32(Console.ReadLine());
                
                for (int j = 0; j < students.Count; j++)
                {
                    Course course = new Course();

                    Console.Write("Code Dars Ra Vared Konid {0}-{1} : ", i+1, j+1);
                    int code = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Nam Dars Ra Vared Konid {0}-{1} : ", i + 1, j + 1);
                    string Cname = Console.ReadLine();

                    Console.Write("Nam Ostad Ra Vared Konid {0}-{1} : ",i + 1, j + 1);
                    string master = Console.ReadLine();

                    Console.Write("Tedad Vahed Dars Ra Vared Konid {0}-{1} : ",i + 1, j + 1);
                    int unit = Convert.ToInt32(Console.ReadLine());

                    student.AddCourse(course);
                    Console.Clear();
                }
                students.Add(student);
                Console.Clear();
            }
            foreach (var item in students)
            {
                item.Etelaat();
                for (int k = 0;k < item.courses.Count;k++)
                {
                    item.courses[k].Vahed();
                }
            }
        }
    }
}
