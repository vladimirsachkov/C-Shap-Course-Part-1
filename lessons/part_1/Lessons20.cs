using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.lessons
{
    /*
     * Ключевое слово break
     */

    class Lessons20
    {  
        public Lessons20() { 
        
        }

        public void Start()
        {
            for (int i = 0; i < 100; i++)
            {
                
                string msg = Console.ReadLine();

                if (msg == "exit") 
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }
    }
}
