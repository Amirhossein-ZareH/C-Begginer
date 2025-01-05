using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator_With_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("I Get Random Numbers And Operate On Them ((These Are Random!!!!))");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter First Random Number: ");
            int random1 = rnd.Next(Convert.ToInt32(Console.ReadLine()));

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Plz Write Random Number :) ");
            Console.Write("Enter Second Random Number: ");
            int random2 = rnd.Next(Convert.ToInt32(Console.ReadLine()));

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Enter Your Operation: \n1.+ \t2.- \t3./ \t4.* \t5.% \nYour Choice =");
            var opr = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Date = {0}", MiladyToShamsy());
            Console.WriteLine("Time = {0}", Time());

            int temp;
            if (random1 > random2)
            {
                temp = random1;
                random2 = random1;
                random2 = temp;
            }

            switch (opr)
            {
                case 1:
                    Console.WriteLine("{0} + {1} = {2}", random1, random2, random1 + random2);
                    break;

                case 2:
                    Console.WriteLine("{0} - {1} = {2}", random1, random2, random1 - random2);
                    break;

                case 3:
                    Console.WriteLine("{0} / {1} = {2}", random1 / random2, random1 / random2);
                    break;

                case 4:
                    Console.WriteLine("{0} * {1} = {2}", random1 * random2, random1 * random2);
                    break;

                case 5:
                    Console.WriteLine("{0} % {1} = {2}", random1 % random2, random1 % random2);
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Error .. Plz Write Correct Number -_- ");
                    break;
            }
            Console.Write("Enter Your First Num: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Enter Your Sec Num: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    Thread.Sleep(100);
                    if (i == j)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            do
            {
                Console.WriteLine("Start Of New Loop");
                Loop();
                // You can Commend This Break Point To Get The do-while Loop Impact
                break;
            } while (true);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Tnx For Your Using Have a Nice Day");

        }
        /// <summary>
        /// For Converting Milady To Shamsy
        /// </summary>
        /// <returns></returns>
        static string MiladyToShamsy()
        {
            PersianCalendar Date = new PersianCalendar();

            int Day = Date.GetDayOfMonth(DateTime.Now);
            int Month = Date.GetMonth(DateTime.Now);
            int Year = Date.GetYear(DateTime.Now);

            string dateTime = Year + "/" + Month + "/" + Day;
            return dateTime;

        }
        /// <summary>
        /// For Converting Time
        /// </summary>
        /// <returns></returns>
        static string Time()
        {
            PersianCalendar time = new PersianCalendar();

            int Second = time.GetSecond(DateTime.Now);
            int Minute = time.GetMinute(DateTime.Now);
            int Hour = time.GetHour(DateTime.Now);

            string timeDate = Hour + "/" + Minute + "/" + Hour;
            return timeDate;
        }
        /// <summary>
        /// For Printing *
        /// </summary>
        static void Loop()
        {
            for (int i = 0; i < 9; i++)
            {
                Thread.Sleep(100);
                Console.Write("* ");
            }
        }
    }
}
