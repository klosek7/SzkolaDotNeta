using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L8
{
    class Task2_8_10
    {
        public static void Task10()
        {
            //Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb

            Console.WriteLine("Sprawdzimy NWW wprowadzonych liczb.\r\nPodaj pierwszą liczbę: ");
            int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Wprowadź drugą liczbę: ");
            int.TryParse(Console.ReadLine(), out int secondNumber);

            int x = firstNumber * secondNumber;
            int w;

            while (secondNumber != 0)
            {
                w = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = w;
            }

            int nww = x / firstNumber;
            Console.WriteLine($"NWW wynosi: {nww}");
        }
    }
}
    
