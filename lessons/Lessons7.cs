using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 * Конвертация строки
 * parse и tryparse
 * 
 */

namespace ConsoleApp1.lessons
{
    internal class Lessons7
    {
        static void Main(string[] args)
        {
            //string str = "5.2";

            //NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            //{
            //    NumberDecimalSeparator = ".",
            //};

            //double a = double.Parse(str, numberFormatInfo);


            //string str = "1фывф";

            //try
            //{
            //    double a = double.Parse(str);
            //    Console.WriteLine("Успешная конвертация");
            //}
            //catch (Exception e) 
            //{ 
            //    Console.WriteLine("Ошибка при конвертации");
            //}


            string str = "1";

            int a;

            bool result = int.TryParse(str, out a);

            if (result)
            {
                Console.WriteLine("Операция успешна, значение = " + a);
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать");
            }
        }
    }
}
