using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L7
{
    public class Task2_7_7
    {
        public static void Task7()
        {
            Console.WriteLine("Podaj trzy liczby. Sprawdzimy, która z nich jest największa: ");
            int.TryParse(Console.ReadLine(), out int firstNumber);
            int.TryParse(Console.ReadLine(), out int secondNumber);
            int.TryParse(Console.ReadLine(), out int thirdNumber);

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("Pierwsza ");
            }
            else if (secondNumber > thirdNumber && secondNumber > thirdNumber) 
            {
                Console.WriteLine("Druga ");
            }
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                Console.WriteLine("Trzecia ");
            }
            else
            {
                Console.WriteLine("Podane liczby są równe");
            }
        }
    }
}
