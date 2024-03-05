using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L7
{
    public class Task2_7_6
    {
        public static void Task6()
        {
            //Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.


            Console.WriteLine("Podaj swój wzrost: ");
            int.TryParse(Console.ReadLine(), out int growth);

            if (growth <= 140)
            {
                Console.WriteLine("Jesteś niski");
            } 
            else if (growth >= 141 && growth < 179)
            {
                Console.WriteLine("Jesteś średni");
            } 
            else if (growth >= 180)
            {
                Console.WriteLine("Jesteś wysoki.");
            }
            else
            {
                Console.WriteLine("Błąd.");
            }
        }  
    }
}
