using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L8
{
    class Task2_8_9
    {
        public static void Task9()
        {
            //Napisz program, który zamieni liczbę dziesiętną na liczbę binarną


            Console.Write("Wprowadź liczbę całkowitą: ");
            int.TryParse(Console.ReadLine(), out int number);

            string result = string.Empty;
            for (int i = 0; number > 0; i++)
            {
                result = number % 2 + result;
                number = number / 2;
            }
            Console.WriteLine($"Postać binarna liczby {number} to: {result}");
        }
    }
}
    
