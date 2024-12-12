using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.lessons
{
    /*
     * Вложенные циклы.
     */

    class Lessons22
    {
        public Lessons22()
        {
        }

        public void Start()
        {
            //Start1();
            Start2();
        }

        private void Start2() 
        {
            Console.Write("Введите высоту прямоугольника: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину прямоугольника: ");
            int width = int.Parse(Console.ReadLine());

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private void Start1() {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("цикл 1 итерация №:" + i);
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("\tцикл 2 интерация №:" + j);
                    for (int k = 1; k <= 2; k++)
                    {
                        Console.WriteLine("\t\tцикл 2 итерация №: " + k);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
