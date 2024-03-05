using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L7
{
    public class Task2_7_11
    {
        public static void Task11()
        {
            //Napisz program, który zmieni ocenę ucznia na jej opis


            Console.Write("Wprowadź ocenę w postaci liczbowej: ");
            int.TryParse(Console.ReadLine(), out int grade);

            switch (grade)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Podałeś błędną ocenę");
                    break;
            }
        }
    }
}
