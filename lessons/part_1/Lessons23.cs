using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.lessons
{
    /*
     * Тернарный оператор
     * 
     * [первый операнд - условие] ? [второй операнд if_true] : [третий опернад if_false]
     */

    class Lessons23
    {
        public Lessons23()
        {
        }

        public void Start() 
        {
            //Start_1();
            //Start_2();
            Start_3();
        }

        public void Start_1() 
        {
            bool accessAllowed;

            string storedPassword = "qwerty";
            string entredPassword = Console.ReadLine();

            if (entredPassword == storedPassword) 
            { 
                accessAllowed = true;
            }
            else
            {
                accessAllowed = false;
            }


            Console.WriteLine(accessAllowed);

            Console.ReadLine();
        }

        public void Start_2()
        {
            bool accessAllowed;

            string storedPassword = "qwerty";
            string entredPassword = Console.ReadLine();

            accessAllowed = storedPassword == entredPassword ? true : false;
            
            Console.WriteLine(accessAllowed);

            Console.ReadLine();
        }

        public void Start_3()
        {
            int inputData = int.Parse(Console.ReadLine());

            int outputData = (inputData < 0) ? 0 : inputData;

            Console.WriteLine(outputData);

            //Console.ReadLine();
        }
    }
}
