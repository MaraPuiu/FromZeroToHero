using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        public enum Seasons { Winter = 0, Spring = 1, Summer = 2, Autumn = 3}

        static void Main(string[] args)
        {
            //DateTime t = DateTime.Now;
            //bool response = checkIfWeekend(t);
            //Console.WriteLine("Is weekend: " + response);
           
            //Seasons season = Seasons.Winter;
            //customSeasonMessage(season);

            //string[] countries = new string[] { "Romatia", "Romania", "Anglia", "Franta" };

            //Console.WriteLine("Highest number of letters: " + highestNumberofLetters(countries));

            //int length;
            //string[] countriesHighest = highestNumberofLettersArray(countries, out length);
            //for (int i = 0; i < length; i++)
            //{
            //    Console.WriteLine("Highest number: " + countriesHighest[i]);
            //}

            Console.WriteLine("Highest number of letters: " + highestNumberofLetters("Romatia", "Romania", "Anglia"));
            Console.WriteLine("Highest number of letters: " + highestNumberofLetters());
            Console.WriteLine("Highest number of letters: " + highestNumberofLetters("Romania", "Anglia"));
        }

        public static bool checkIfWeekend(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) return true;
            return false;
        }

        public static void customSeasonMessage(Seasons enumSeason)
        {
            switch (enumSeason)
            {
                case Seasons.Autumn:
                    Console.WriteLine("Hello Autumn");
                    break;
                case Seasons.Winter:
                    Console.WriteLine("Hello Winter");
                    break;
                case Seasons.Summer:
                    Console.WriteLine("Hello Summer");
                    break;
                case Seasons.Spring:
                    Console.WriteLine("Hello Spring");
                    break;
            }

        }

        public static string highestNumberofLetters(params string[] countries)
        {
            if (countries.Length == 0) return "No countries";
            string longestWord = "";

            foreach (string country in countries)
            {
                if (longestWord.Length < country.Length) longestWord = country;
            }

            return longestWord;
        }

        public static string[] highestNumberofLettersArray(string[] countries, out int length)
        {
            int maxLength = 0;
            string[] response = new string[countries.Length];
            int index = 0;

            foreach (string country in countries)
            {
                if (maxLength < country.Length) maxLength = country.Length;
            }

            foreach (string country in countries)
            {
                if (maxLength == country.Length)
                    response[index++] = country;
            }

            length = index;
            return response;
        }
    }
}
