using System;
using SzkolaDotNeta.Modul2.L4;
using SzkolaDotNeta.Modul2.L7;

namespace SzkolaDotNeta
{
    class Program
    {

        public static void Main(string[] args)
        {
            int choiceLesson;
            int choiceTask;

            Console.WriteLine("Które zadania chcesz sprawdzić: \r 1. Moduł 2 - Lekcja 4 \r 2. Moduł 2 - Lekcja 7");
            int.TryParse(Console.ReadLine(), out choiceLesson);

            switch(choiceLesson)
            {
                case 1:
                    Console.Write("Wybrałeś Moduł 2 - Lekcje 4. Teraz wybierz konkretne zadanie: ");
                    int.TryParse(Console.ReadLine(), out choiceTask);
                    switch (choiceTask)
                    {
                        case 1:
                            Console.WriteLine($"Task 1: {Task2_4_1.Task1()}");
                            break;
                        case 2:
                            Console.WriteLine($"Task 2: {Task2_4_2.Task2()}");
                            break;
                        case 3:
                            Console.WriteLine($"Task 3: {Task2_4_3.Task3(5, 10)}");
                            break;
                        case 4:
                            Console.WriteLine($"Task 4: {Task2_4_4.Task4()}");
                            break;
                        case 5:
                            Console.WriteLine($"Task 5: "); Task2_4_5.Task5();
                            break;
                        default:
                            Console.WriteLine("Zły wybór");
                            break;
                    }


                    break;

                case 2:
                    Console.Write("Wybrałeś Moduł 2 - Lekcje 7. Teraz wybierz konkretne zadanie: ");
                    int.TryParse(Console.ReadLine(), out choiceTask);
                    switch (choiceTask)
                    {
                        case 1:
                            Console.WriteLine($"Task 1: "); Task2_7_1.Task1();
                            break;
                        case 2:
                            Console.WriteLine($"Task 2: "); Task2_7_2.Task2();
                            break;
                        case 3:
                            Console.WriteLine($"Task 3: "); Task2_7_3.Task3();
                            break;
                        case 4:
                            Console.WriteLine($"Task 4: "); Task2_7_4.Task4();
                            break;
                        case 5:
                            Console.WriteLine($"Task 5: "); Task2_7_5.Task5();
                            break;
                        case 6:
                            Console.WriteLine($"Task 6: "); Task2_7_6.Task6();
                            break;
                        case 7:
                            Console.WriteLine($"Task 7: "); Task2_7_7.Task7();
                            break;
                        case 8:
                            Console.WriteLine($"Task 8: "); Task2_7_8.Task8();
                            break;
                        case 9:
                            Console.WriteLine($"Task 9: "); Task2_7_9.Task9();
                            break;
                        case 10:
                            Console.WriteLine($"Task 10: "); Task2_7_10.Task10();
                            break;
                        case 11:
                            Console.WriteLine($"Task 11: "); Task2_7_11.Task11();
                            break;
                        case 12:
                            Console.WriteLine($"Task 12: "); Task2_7_12.Task12();
                            break;
                        case 13:
                            Console.WriteLine($"Task 13: "); Task2_7_13.Task13();
                            break;
                        default:
                            Console.WriteLine("Zły wybór");
                            break;
                    }                                    
                    break;

                    default:
                    Console.WriteLine("Zły wybór");
                    break;
            }
            
        }
    }
}
