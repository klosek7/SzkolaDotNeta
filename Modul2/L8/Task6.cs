namespace SzkolaDotNeta.Modul2.L8
{
    class Task2_8_6
    {
        public static void Task6()
        {
            /* Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
             1 + ½ +1 / 3 + ¼ itd.*/

            double result = 0;

            for (double i = 1; i <= 20; i++)
            {
                result += 1 / i;
            }
            Console.WriteLine(result);
        }
    }
}

