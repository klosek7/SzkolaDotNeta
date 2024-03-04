using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L8
{
    class Task2_8_2
    {
        public static void Task2()
        {
            int a = 0;

            do
            {
                a++;

                if (a % 2 == 0)
                {
                    Console.Write("{0} ", a);
                }                
            } 
            while (a < 1000);           
        }
    }
}
    
