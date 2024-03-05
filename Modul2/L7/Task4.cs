using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L7
{
    public class Task2_7_4
    {
        public static void Task4()
        {
            //Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.

            Console.WriteLine("Podaj rok: ");
            int.TryParse(Console.ReadLine(), out int year);

            if (year % 4 == 0)
            {
                Console.WriteLine("Podany rok jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine("Podany rok jest rokiem zwykłym");
            }
        }  
    }
}
