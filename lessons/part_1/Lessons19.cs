using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.lessons
{
    /*
     * Цикл for Особенности
     * несколько переменных
     * цикл for в обратном порядке
     * несколько условий
     */
    class Lessons19
    {
        public Lessons19() 
        { 
        
        }

        public void Start() 
        {
            //this.Start_1();
            //this.Start_2();
            //this.Start_3();
            //this.Start_4();
            //this.Start_5();
            //this.Start_6();
            this.Start_7();
        }

        public void Start_1()
        {
            int limit = int.Parse(Console.ReadLine());

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        public void Start_2() {
            for (;;)
            {
                Console.WriteLine("for is working");
                System.Threading.Thread.Sleep(300);
                break;
            }
            Console.ReadLine();
        }

        public void Start_3() {

            int i = 0;

            for (; i < 3; i++)
            {
                Console.WriteLine("for_1: " + i);    
            }

            for (; i < 5; i++)
            {
                Console.WriteLine("for_2: " + i);   
            }

            Console.ReadLine();
        }

        public void Start_4()
        {

            for (int i = 0, j = 5; i < 10; i++, j++)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }

            Console.ReadLine();
        }

        private void Start_5()
        {
            for (int i = 0, j = 5; i < 10 && j < 12; i++, j++)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }

            Console.ReadLine();
        }

        private void Start_6()
        {
            int i = int.Parse(Console.ReadLine());

            for (; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        private void Start_7()
        {
            for (int i = 0, j = 5; i < 5; i++, j--)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }

            Console.ReadLine();
        }
    }
}
