using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L7
{
    public class Task2_7_9
    {
        public static void Task9()
        {
            //Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach


            Console.WriteLine("Wprowadź temepraturę: ");
            int.TryParse(Console.ReadLine(), out int temperature);

            var result = temperature switch
            {
                < 0 => "Cholernie piździ",
                >= 0 and < 10 => "Zimno",
                < 20 => "Chłodno",
                < 30 => "W sam raz",
                < 40 => "Zaczyna być słabo, bo gorąco",
                >= 40 => "A weź, wyprowadzam się na Alaskę"
            };

            Console.WriteLine(result);
        }  
    }
}
