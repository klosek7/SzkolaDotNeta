﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L4
{     
    public class Task2_4_2
    {
        public static string Task2()
        {
            //Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w  odwrotnej kolejności niż zostały zadeklarowane.


            char firstChar = 'a';
            char secondChar = 'b';
            char thirdChar = 'c';

            return $"\n{thirdChar} {secondChar} {firstChar}";
        }
    }
}