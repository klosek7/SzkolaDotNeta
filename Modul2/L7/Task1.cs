using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L7
{
    public class Task2_7_1
    {
        public static void Task1()
        {
            //Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.

            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine($"Liczby {a} i {b} są równe");
            }
            else
            {
                Console.WriteLine("Podane liczby różnią się od siebie");
            }
        }  
    }
}
