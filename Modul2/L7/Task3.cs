using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L7
{
    public class Task2_7_3
    {
        public static void Task3()
        {
            Console.WriteLine("Podaj liczbę: ");
            int.TryParse(Console.ReadLine(), out int number);

            if (number > 0)
            {
                Console.WriteLine("Podana liczba jest liczbą dodatnią");
            }
            else
            {
                Console.WriteLine("Podana liczba jest liczbą ujemną");
            }
        }  
    }
}
