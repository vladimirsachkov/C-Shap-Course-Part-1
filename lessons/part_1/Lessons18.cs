using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.lessons
{
    /*
     *  Цикл for
     */

    public class Lessons18
    {
        public Lessons18() {

        }

        public void Start()
        {
            this.Start_1();
            //this.Start_2(); 
        }

        public void Start_1() {
            int limit = int.Parse(Console.ReadLine());
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Start_2()
        {
            int limit = int.Parse(Console.ReadLine());

            int i = 0; 

            while (i < limit) {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
