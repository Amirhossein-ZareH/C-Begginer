using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Bug_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region//multi catch
            //multi-catching
            int num1 = 50;
                int num2 = 0;
            try
            {
                int avg = num1 / num2;
                Console.WriteLine("Avg is : {0}",avg);
                //----------------------------
                string family = null;
                Console.WriteLine(family.Length);
                //----------------------------
                Console.WriteLine("Enter Num: ");
                int num = Convert.ToInt32(Console.ReadLine());
                num--;
                Console.WriteLine(num);
                //----------------------------
                File.OpenRead("d://Chdsdas.png");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error 1 : {0}\n",ex.Message);
                Console.WriteLine("Error 1 : number 2 == 0");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error 2 : {0}\n", ex.Message);
                Console.WriteLine("Error 2 : string == null");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error 3 : {0}\n", ex.Message);
                Console.WriteLine("Error 3 : Write correct format");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error 4 : {0}\n", ex.Message);
                Console.WriteLine("Error 4 : theres no file here");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error 5 : {0}\n", ex.Message);
                Console.WriteLine("Error 5 : amir in bug ro deghat nakarde body");
            }
            finally
            {

            }
            #endregion
            #region//finally
            //finally
            //try
            //{
            //    File.OpenRead("c://rad.crd");
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("Error : {0}", ex.Message);
            //}
            //finally 
            //{
            //    Console.WriteLine("Hala boro hal kon");
            //}
            #endregion
            #region//file exeption
            ////file not found exeption
            //try
            //{
            //File.OpenRead("d://csharp.png");
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("Error : {0}", ex.Message);
            //}
            #endregion
            #region//index exeption
            //index out of range exeption
            //int[] age = { 1, 2, 3 };
            //Console.WriteLine(age[2]);
            //try
            //{
            //    Console.WriteLine(age[3]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Error : {0}", ex.Message);
            //}
            #endregion
            #region//format exeption
            //format exeption
            //try
            //{
            //    Console.Write("Enter num : ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    num--;
            //    Console.WriteLine("Num is : {0}", num);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Error : {0}", ex.Message);
            //}
            //#endregion
            //#region//null exeption
            ////null refrence exeptiom
            //string family = null;
            //try
            //{
            //    Console.WriteLine(family.Length);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine("Error : {0}", ex.Message);
            //}
            #endregion
            #region//divide by zero
            //divide by zero exeption
            //try
            //{
            //
            //    Console.Write("Enter Num1: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter Num2: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());
            //
            //    int avg = num1 / num2;
            //
            //    Console.WriteLine("Avg is : {0}", avg);
            //}
            //catch (DivideByZeroException ex)
            //{ 
            //    Console.WriteLine("Error : {0}",ex.Message);
            //}
            //#endregion
            //#region//exeption
            //try
            //{
            //    Console.Write("Enter Num1: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter Num2: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());
            //
            //    int avg = num1 / num2;
            //
            //    Console.WriteLine("Avg is : {0}", avg);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Error : {0}",ex.Message);
            //}
            #endregion
        }
    }
}
