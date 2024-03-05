using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L7
{
    public class Task2_7_2
    {
        public static void Task2()
        {
            //Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.


            Console.WriteLine("Podaj liczbę całkowitą");
            int.TryParse(Console.ReadLine(),out int number);            

            if (number % 2 == 0) 
            {
                Console.WriteLine($"Liczba {number} jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine($"Liczba {number} jest liczbą nieparzystą");
            }
        }  
    }
}
