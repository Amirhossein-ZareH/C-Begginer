using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Remove_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList List1 = new ArrayList();

            //اضافه کردن خانه
            List1.Add(800);
            List1.Add("amir").
            List1.Add(8.1f);
            List1.Add(null);
            List1.Add(false);

            //  حذف خانه از روش اسمی
            List1.Remove("amir");
            // حذف خانه از روش اندیس
            List1.RemoveAt(0);
            // حذف کل خانه ها
            List1.Clear();






            //با foreach
            foreach (var item in List1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //با for
            for (var i = 0; i < List1.Count; i++)
            {
                Console.WriteLine(List1[i]);
            }
            Console.WriteLine();
        }
    }
}
