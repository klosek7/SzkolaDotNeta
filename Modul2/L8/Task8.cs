using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SzkolaDotNeta.Modul2.L8
{
    class Task2_8_8
    {
        public static void Task8()
        {
            Console.Write("Wprowadź ciąg znaków: ");
            string input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
    
