using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L7
{
    public class Task2_7_8
    {
        public static void Task8()
        {
            Console.WriteLine("Wprowadź swoje wyniki z matury. Sprawdzimy czy będziesz mógł dostać się na studia.");
            Console.Write("Liczba punktów z matematyki: ");
            int.TryParse(Console.ReadLine(), out int resultMathematics);
            Console.Write("Liczba punktów z fizyki: ");
            int.TryParse(Console.ReadLine(), out int resultPhysics);
            Console.Write("Liczba punktów z chemii: ");
            int.TryParse(Console.ReadLine(), out int resultChemistry);

            int total = resultChemistry + resultMathematics + resultPhysics;
            Console.WriteLine($"Łącznie uzyskałeś {total} punktów");

            if ((total > 180 && resultChemistry > 45 && resultMathematics > 70 && resultPhysics > 55) || (resultMathematics + resultPhysics > 150 || resultMathematics + resultChemistry > 150) )
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Nie masz szans, aby dostać się na studia");
            }
        }  
    }
}
