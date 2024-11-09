using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.lessons
{
    /*
     * Ключевое слово continue;
     */

    class Lessons21
    {
        public Lessons21() { 
        
        }

        public void Start() {
            
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
