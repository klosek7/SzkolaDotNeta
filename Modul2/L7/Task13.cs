using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L7
{
    public class Task2_7_13
    {
        public static void Task13()
        {
            //Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem

            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine("------ Kalkulator ------");

                Console.Write("Wprowadź pierwszą liczbę: ");
                double.TryParse(Console.ReadLine(), out double firstNumber);

                Console.Write("Wprowadź drugą liczbę: ");
                double.TryParse(Console.ReadLine(), out double secondNumber);

                Console.WriteLine("Podaj numer operacji do wykonania:\r\n1. Dodawanie \r\n2. Odejmowanie \r\n3. Mnożenie \r\n4. Dzielenie ");
                int.TryParse(Console.ReadLine(), out int choiceOperation);

                switch (choiceOperation)
                {
                    case 1:
                        Console.WriteLine($"Dodawanie \r\nWynik: {firstNumber + secondNumber}");
                        break;
                    case 2:
                        Console.WriteLine($"Odejmowanie \r\nWynik: {firstNumber - secondNumber}");
                        break;
                    case 3:
                        Console.WriteLine($"Mnożenie \r\nWynik: {firstNumber * secondNumber}");
                        break;
                    case 4:
                        if (firstNumber > 0 && secondNumber > 0)
                        {
                            Console.WriteLine($"Dzielenie \r\nWynik: {firstNumber / secondNumber}");
                        }
                        else
                        {
                            Console.WriteLine("Nie dzielimy przez 0");
                        }
                        break;
                    default:
                        Console.WriteLine("Wprowadziłeś błędny numer operacji");
                        break;
                }

                Console.WriteLine("Wpisz 'e', jeśli chcesz opuścić program\r\nWpisz 's', jeśli chcesz wykonać inne działanie");

                if (Console.ReadLine() == "e")
                {
                    exit = true;
                }
                else
                {
                    exit = false;
                }
            }            
        }
    }
}
