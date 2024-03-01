using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L7
{
    public class Task2_7_10
    {
        public static void Task10()
        {
            Console.WriteLine("Wprowadź trzy liczby. Sprawdzimy czy można z nich zbudować trójkąt");
            Console.Write("Wprowadź pierwszą liczbę: ");
            int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.Write("Wprowadź drugą liczbę: ");
            int.TryParse(Console.ReadLine(), out int secondNumber);
            Console.Write("Wprowadź trzecią liczbę: ");
            int.TryParse(Console.ReadLine(), out int thirdNumber);

            if (firstNumber + secondNumber > thirdNumber)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Z podanych wartości nie zbudujesz trójkąta.");
            }
        }
    }
}
