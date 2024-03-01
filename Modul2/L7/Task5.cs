using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L7
{
    public class Task2_7_5
    {
        public static void Task5()
        {
            Console.WriteLine("Podaj swój wiek: ");
            int.TryParse(Console.ReadLine(), out int age);

            var result = age switch
            {
                < 21 => "Jesteś za młody, nie możesz kandydować na stanowisko w rządzie.",
                21 or < 30 => "Możesz zostać posłem i premierem.",
                30 or < 35 => "Możesz zostać senatorem, posłem i premierem.",
                35 or < 65 => "Możesz zostać prezydentem, senatorem, posłem i premierem.",
                >= 65 => "Czas na emeryturę."                
            };

            Console.WriteLine($"Masz {age} lat. {result}");

        }  
    }
}
