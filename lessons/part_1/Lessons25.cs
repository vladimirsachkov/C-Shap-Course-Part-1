using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.lessons
{
    class Lessons25
    {
        /*
         * Массивы
         * 
         * Одномерные массивы
         * 
         * Способы инициализации массива
         */

        public Lessons25()
        {
        }

        public void Start() {
            Start_1();
        }

        public void Start_1()
        {
            int[] myArray = new int[] {5,6};
            int[] myArray_2 = new int[3] { 5, 3, 2 };
            int[] myArray_3 = Enumerable.Repeat(5, 10).ToArray();
            int[] myArray_4 = Enumerable.Range(4, 5).ToArray();

            Console.ReadLine();
        }
    }
}
