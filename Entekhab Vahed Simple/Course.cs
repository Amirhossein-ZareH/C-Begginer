using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entekhab_Vahed_Simple
{
    internal class Course
    {
        public int CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseMaster { get; set; }
        public int CourseUnit { get; set; }

        public Course() { }
        public Course(int CourseCode, string CourseName, string CourseMaster, int CourseUnit)
        {
            this.CourseCode = CourseCode;
            this.CourseName = CourseName;
            this.CourseMaster = CourseMaster;
            this.CourseUnit = CourseUnit;
        }
        public void Vahed()
        {
            Console.WriteLine("\t\tcourseCode: {0}\tcourseName: {1}\tcourseMaster: {2}\tcourseUnit: {3}",CourseCode,CourseName,CourseMaster,CourseUnit);
        }
    }
}
