using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SzkolaDotNeta.Modul2.L4
{     
    public class Task2_4_3
    {
        public static double Task3(double a, double b)
        {
            //Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość 
            //przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())

            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
}