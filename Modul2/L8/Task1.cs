using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L8
{
    class Task2_8_1
    {
        public static void Task1()
        {
            //Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100

            int counter;
            int primeNumbersCounter = 0;

            for (int i = 2; i <= 100; i++)
            {
                counter = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                        
                    }
                }

                if (counter == 0 && i != 1)
                {
                    primeNumbersCounter++;
                    Console.Write("{0} ", i);                    
                }
            }

            Console.WriteLine($"\r\nIlość liczb pierwszych w zakresie od 0 do 100 to: {primeNumbersCounter}");



        }
    }
}
    
