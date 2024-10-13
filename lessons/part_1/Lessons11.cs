using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Инкремент и декримент
 */

namespace ConsoleApp1.lessons
{
  
    public class Lessons11
    {
        public Lessons11() {
        }

        public void Start() {
            int a = 1;

            a = a++ * a;

            Console.WriteLine(a++);
        }
    }
}
