using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OOP__This_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            //Console.Write("Enter Your IDnumber:");
            int id = Convert.ToInt32(Console.ReadLine());
            //person1.SetPersonId(id);

            //Console.Write("Enter Your Name: ");
            string name = Convert.ToString(Console.ReadLine());
            //person1.SetPersonName(name);

            //Console.Write("Enter Your LastName: ");
            string lname = Convert.ToString(Console.ReadLine());
            //person1.SetPersonFamily(name);

            //Console.Write("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            //person1.SetPersonAge(age);

            //Console.Write("Enter Your Avg: ");
            float avg = float.Parse(Console.ReadLine());
            //person1.SetPersonAvg(avg);

            person1.Setter(1);   
            







        }
    }
    /// <summary>
    /// اطلاعات شخص
    /// </summary>
    class Person
    {
        private int personId;
        private string personFirstName;
        private string personLastName;
        private int personAge;
        private float personAvg;

        public void PersonId { set; get; }
        /// <summary>
        /// چاپ اطلاعات
        /// </summary>
        public void personInfo()
        {
            Console.WriteLine("id: {0}\tName: {1}\tLastName: {2}\tAge: {3}\tAvg: {4}",personId,personFirstName,personLastName,personAge,personAvg);
        }
        /// <summary>
        /// راه کامل تر برای دریافت اطلاعات
        /// </summary>
        /// <param name="personId">آیدی</param>
        /// <param name="personFirstName">نام</param>
        /// <param name="personLastName">فامیلی</param>
        /// <param name="personAge">سن</param>
        /// <param name="personAvg">میانگین نمرات</param>
        public void Setter(int personId, string personFirstName, string personLastName, int personAge, float personAvg)
        {
            this.personId = personId;
            this.personFirstName = personFirstName;
            this.personLastName = personLastName;
            this.personAge = personAge;
            this.personAvg = personAvg;
        }
        public void Setter(int personId, string personFirstName, string personLastName, int personAge)
        {
            this.personId = personId;
            this.personFirstName = personFirstName;
            this.personLastName = personLastName;
            this.personAge = personAge;
        }
        public void Setter(int personId, string personFirstName, string personLastName)
        {
            this.personId = personId;
            this.personFirstName = personFirstName;
            this.personLastName = personLastName;
        }
        public void Setter(int personId, string personFirstName)
        {
            this.personId = personId;
            this.personFirstName = personFirstName;
        }
        public void Setter(int personId)
        {
            this.personId = personId;
        }
        /// <summary>
        /// برای دریافت کردن آیدی
        /// </summary>
        /// <param name="id">شناسه</param>
        public void SetPersonId(int id)
        {
            personId = id;
        }
        /// <summary>
        /// برای چاپ آیدی
        /// </summary>
        /// <returns></returns>
        public int GetPersonId()
        {
            return personId;
        }
        /// <summary>
        /// برای دریافت کردن نام
        /// </summary>
        /// <param name="name">نام</param>
        public void SetPersonName(string name)
        {
            personFirstName = name;
        }
        /// <summary>
        /// برای چاپ نام
        /// </summary>
        /// <returns></returns>
        public string GetPersonName()
        {
            return personFirstName;
        }
        /// <summary>
        /// برای دریافت کردن فامیلی
        /// </summary>
        /// <param lName="lName">فامیلی</param>
        public void SetPersonFamily(string lName)
        {
            personLastName = lName;
        }
        /// <summary>
        /// برای چاپ فامیلی
        /// </summary>
        /// <returns></returns>
        public string GetPersonFamily()
        {
            return personLastName;
        }
        /// <summary>
        /// برای دریافت کردن سن
        /// </summary>
        /// <param name="age">سن</param>
        public void SetPersonAge(int age)
        {
            personAge = age;
        }
        /// <summary>
        /// برای چاپ سن
        /// </summary>
        /// <returns></returns>
        public int GetPersonAge()
        {
            return personAge;
        }
        /// <summary>
        /// برای دریافت کردن میانگین معدل
        /// </summary>
        /// <param name="Avg">میانگین</param>
        public void SetPersonAvg(float Avg)
        {
            personAvg = Avg;
        }
        /// <summary>
        /// برای چاپ معدل
        /// </summary>
        /// <returns></returns>
        public float GetPersonAvg()
        {
            return personAvg;
        }
    }
}
