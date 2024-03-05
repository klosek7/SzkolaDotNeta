using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L7
{
    public class Task2_7_12
    {
        public static void Task12()
        {
            //Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę


            Console.Write("Wprowadź dzień tygodnia w postaci liczbowej: ");
            int.TryParse(Console.ReadLine(), out int day);

            switch (day)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Podałeś błędny numer tygodnia");
                    break;
            }
        }
    }
}
