namespace SzkolaDotNeta.Modul2.L8
{
    class Task2_8_4
    {
        public static void Task4()
        {
            /*  
                Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej
                liczby w formie jak poniżej:
                1
                2 3
                4 5 6
                7 8 9 10 
                11 12 13 14 15
                16 17 18 19 20 21
            */
            Console.Write("Podaj liczbę całkowitą: ");
            int.TryParse(Console.ReadLine(), out int number);
            int printNumber = 0;


            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (number != printNumber)
                    {
                        printNumber++;
                        Console.Write($"{printNumber} ");

                    }
                }
                if (number != printNumber)
                {
                    Console.WriteLine("");
                }


            }
        }
    }
}

