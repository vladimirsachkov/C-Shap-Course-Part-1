using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.lessons
{
    /*
     * Цикл while
     */

    public class Lessons16
    {
        public Lessons16() { 
        }

        public void Start() {
            int count = 0;
            int limit = int.Parse(Console.ReadLine());

            while (count < limit) {
                count++;
                Console.WriteLine(count);
            }
        }
    }
}