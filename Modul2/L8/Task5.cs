﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L8
{
    class Task2_8_5
    {
        public static void Task5()
        {
            //Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę


            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Liczba {i} do potęgi 3 wynosi: {Math.Pow(i, 3)}");
            }
        }
    }
}
    
