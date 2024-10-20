using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Логические операторы
 * 
 * && Сокращённое И
 * || Сокращённое ИЛИ
 * & И
 * | ИЛИ
 * ! НЕ (унарный)
 * 
 */

namespace ConsoleApp1.lessons
{
    class Lessons14
    {
        public Lessons14()
        {
        }

        public void Start()
        {
            //this.startCode_1();
            //this.startCode_2();
            this.StartCode_3();
        }

        public void startCode_1()
        {
            bool isInfected = false;

            if (!isInfected)
            {
                Console.WriteLine("Персонаж здоров!");
            }
        }

        public void startCode_2()
        {
            //int fanSpeen = -1;

            //bool isHighTemperature = false;

            //bool hasNoCooling = fanSpeen == 0;

            //if (isHighTemperature || hasNoCooling)
            //{
            //    Console.WriteLine("Угроза повреждения процессора!!!");
            //}

            bool isHighTemperature = true;

            bool hasNoCooling = true;

            if (isHighTemperature || hasNoCooling)
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }
        }

        public void StartCode_3() { 
            
            if (GetTemperature() && GetCoolingStatus())
            {
                Console.WriteLine("Угроза повреждению процессора");
            }

        }

        public static bool GetTemperature() 
        {
            return false;
        }

        public static bool GetCoolingStatus()
        {
            return true;
        }
    }
}
