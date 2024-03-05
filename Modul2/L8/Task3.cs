using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L8
{
    class Task2_8_3
    {
        public static void Task3()
        {
            //Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.


            Console.Write("Który wyraz ciągu Fibonacciego chcesz sprawdzić? Podaj cyfrę: ");
            int.TryParse(Console.ReadLine(), out int number);
            int a = 0;
            int b = 1;

            for (int i = 0; i < number; i++) 
            {
                b = a + b;
                a = b - a;
            }
            Console.WriteLine(a);
        }
    }
}
    
