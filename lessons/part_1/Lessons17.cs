using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.lessons
{
    /*
     *  Цикл do while
     */

    public class Lessons17
    {   
        public Lessons17() { 
        
        }

        public void Start() {

            int count = 0;



            //while (count < 5) {
            //    count++;
            //    Console.WriteLine(count);
            //}

            do
            {
                count++;
                Console.WriteLine(count);
            } while (count < 5);
        }
    }
}
