using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Persian_Calender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersianCalendar Calendar = new PersianCalendar();
            
            int Day = Calendar.GetDayOfMonth(DateTime.Now);
            int Month = Calendar.GetMonth(DateTime.Now);
            int Year = Calendar.GetYear(DateTime.Now);

            string Calender = (Year + "/" + Month + "/" + Day);
            Console.WriteLine(Calender);
        }

    }
}
