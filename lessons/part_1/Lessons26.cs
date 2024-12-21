using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.lessons
{
    /*
     * Масссивы и циклы
     */

    class Lessons26
    {
        public Lessons26()
        {
        }

        public void Start ()
        {
            Start_1();
        }

        public void Start_1()
        {
            int[] myArray = { 10, 3, 2, 55 };

            for (int i = 0; i < myArray.Length; i++) 
            {
                Console.WriteLine(myArray[i]);
            }

            Console.ReadLine();
        }
    }
}
