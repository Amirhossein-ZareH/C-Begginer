using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic2
{
    internal class Lesson
    {
        public int CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseMaster { get; set; }
        public int CourseUnit {  get; set; }

        public Lesson(){}
        public Lesson(int CourseCode,string CourseName,string CourseMaster,int CourseUnit)
        {
            this.CourseCode = CourseCode;
            this.CourseName = CourseName;
            this.CourseMaster = CourseMaster;
            this.CourseUnit = CourseUnit;
        }
        public void InfoCourse()
        {
            Console.WriteLine("\t\tcode: {0}\tname: {1}\tmaster: {2}\tunit: {3}",CourseCode,CourseName,CourseMaster,CourseUnit);
        }
    }
}
