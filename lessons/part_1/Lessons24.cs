using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.lessons
{
    class Lessons24
    {

        /*
         * Массивы
         * 
         * Одномерные массивы
         * 
         * Тип_элемента_массива [] имя_массива
         */

        public Lessons24()
        {
        }

        public void Start()
        {
            Start_1();
        }

        public void Start_1()
        {
            int[] myArray;

            myArray = new int[5];


            Console.WriteLine(myArray.Length);

            Console.ReadLine();
        }
    }
}
