using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Type
{
    //enum types
    enum Color
    {
        Red,Blue=19,Green,Black,Yellow,Pink
    }
    //struct types
    struct Parent
    {
       public string name;
       public int age;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // object    var    dynamic

            //object x;
            //x = 10;
            //x = "amir";
            //x = 12312.31232132;
            //x = 1.2132321f;
            //int number = (int)x;

            //var y = 10;

            //dynamic x;
            //x = 10;
            //x = "amir";
            //x = 3.2321434454313;

            //Console.WriteLine(x.GetType());
            #endregion
            #region
            //naullabe types
            //روش دوم
            //int? age1 = null;
            //int temp1 = age1 ?? 0;
            //Console.WriteLine(temp1);
            //روش اول
            Nullable<int> age = 26;
            //int temp = age ?? 0;
            //Console.WriteLine(temp);
            #endregion
            #region
            //Parent p1;
            //p1.age = 1;
            //p1.name = "Test";
            #endregion
            #region
            //enum
            //int a = (int)Color.Black;
            ////int b = (int)Color.Yellow;
            ////int c = (int)Color.Pink;
            ////Console.WriteLine(c);
            ////Console.WriteLine(b);
            ////Console.WriteLine(a);
            ////Console.WriteLine(Color.Black);
            #endregion
        }
    }
}
