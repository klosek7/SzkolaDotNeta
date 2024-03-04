namespace SzkolaDotNeta.Modul2.L8
{
    class Task2_8_7
    {
        public static void Task7()
        {
            /* Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej 
            przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
                *    
               *** 
              *****
             *******
            *********
             *******
              *****
              ***
               * 
                        */
            Console.WriteLine("Wprowadź liczbę: ");
            int.TryParse(Console.ReadLine(), out int number);

            for (int i = 1; i <= number; i++) 
            {
                for (int j = 1; j <= number - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.WriteLine("");
            }
            for (int i = number - 1; i >= 1; i--)
            {
                for (int j = 1; j <= number - i; j++)
                    Console.Write(" ");  

                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");  

                Console.Write("\n"); 
            }


        }
    }
}

