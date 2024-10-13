using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *   Операторы отношений
 *   Операции сравнений
 *   
 *          == Равно 
 *          != Не равно
 *          > Больше
 *          < Меньше
 *          >= Больше или равно
 *          <= Меньше или равно
 */
namespace ConsoleApp1.lessons
{
    public class Lessons12
    {
        public Lessons12()
        {
        }

        public void Start()
        {
            int a = 4;

            int b = 4;

            Console.WriteLine(a == b);

            Console.WriteLine(b != a);

            Console.WriteLine(a > b);

            Console.WriteLine(b < a);

            Console.WriteLine(a >= b);

            Console.WriteLine(b <= a);
        }
    }
}
