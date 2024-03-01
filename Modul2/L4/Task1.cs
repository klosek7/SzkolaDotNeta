using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L4
{
    class Task2_4_1
    {
        public static string Task1()
        {
            string imie = "Jan";
            string nazwisko = "Kowalski";
            int wiek = 23;
            char plec = 'm';
            string pesel = "78541232122";
            string numerPracownika = "2509324094";

            return $"\nImie i nazwisko: {imie} {nazwisko} \nWiek: {wiek} \nPłeć: {plec} \nPesel: {pesel} \nNumer pracownika: {numerPracownika}";
        }
    }
}
    
