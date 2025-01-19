using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extencion_Methods
{
    static class MyExtencions
    {
       public static string ToShamsi(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
           
            return  pc.GetYear(date) + "/" + pc.GetMonth(date) + "/" + pc.GetDayOfMonth(date);
        }
        public static void Print(this string str)
        {
            Console.WriteLine(str);
        }
    }
}
