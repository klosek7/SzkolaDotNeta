using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotNeta.Modul2.L4
{     
    public class Task2_4_5
    {
        public static void Task5()
        {
            /*Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko, 
            numer telefonu, adres email, wzrost, waga (np. 85,7), itp (postaraj się wymyślić jak najwięcej) 
            i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody: 
            typDanych.Parse(odpowiedźOdUżytkownika).*/

            string firstName;
            string lastName;
            int age;
            char sex;
            string phoneNumber;
            double weight;
            string email;

            Console.WriteLine("Podaj imię:");
            firstName = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            lastName = Console.ReadLine();
            Console.WriteLine("Podaj wiek:");
           
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Wpisałeś niepoprawny wiek");
                Environment.Exit(0);
            }
                       
            Console.WriteLine("Podaj płeć, wpisz znak 'm' - mężczyzna, 'k' - kobieta");            
            if (!char.TryParse(Console.ReadLine(), out sex))
            {
                Console.WriteLine("Musisz wpisać znak 'm' - mężczyzna, 'k' - kobieta");
                Environment.Exit(0);
            }

            Console.WriteLine("Podaj wagę:");
            if (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Podana waga jest nieprawidłowa");
                Environment.Exit(0);
            }

            Console.WriteLine($"Imię: {firstName}\nNazwisko: {lastName}\nWiek: {age}\nPłeć: {sex}\nWaga: {weight}");

        }
    }
}