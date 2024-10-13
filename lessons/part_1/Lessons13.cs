using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Конструкция if else
 */

/*
 * 
 *        if (утверждение или выражение)
 *        {
 *          Действие 1;
 *        }
 *        else 
 *        {
 *          Действие 2;
 *        }
 * 
 */

namespace ConsoleApp1.lessons
{
    public class Lessons13
    {
        public Lessons13()
        {
        }

        public void Start()
        {
            //bool isInfected = true;

            //if (isInfected)
            //{
            //    Console.WriteLine("Персонаж инфицирован");
            //}   
            //else
            //{
            //    Console.WriteLine("Персонаж инфицирован");
            //}

            int a;

            a = int.Parse(Console.ReadLine());

            if (a == 5) {
                Console.WriteLine("a равно 5");
            }
            else
            {
                Console.WriteLine("a не равно 5"); 
            }
        }
    }
}
