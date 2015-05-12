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
        public enum DiscountType { General = 0, Promotion = 25, BestDeal = 50 }

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

            //Console.WriteLine("Highest number of letters: " + highestNumberofLetters("Romatia", "Romania", "Anglia"));
            //Console.WriteLine("Highest number of letters: " + highestNumberofLetters());
            //Console.WriteLine("Highest number of letters: " + highestNumberofLetters("Romania", "Anglia"));
       
            //double price = 100.00;
            //int age = 14;
            //double priceWithDiscount;
            //discountPrice(price, age, out priceWithDiscount);
            //Console.WriteLine("Price with discount: " + priceWithDiscount);

            //double price = 100.00;
            //int age = 14;
            //discountPrice(ref price, age);
            //Console.WriteLine("Price with discount: " + price);

            double price = 100.00;
            int price2 = 200;
            int age = 6;
            double newPrice3 = discountPrice(price);
            Console.WriteLine("Price with discount: " + newPrice3);
            double newPrice = discountPrice(price, discType: DiscountType.BestDeal);
            Console.WriteLine("Price with discount: " + newPrice);
            double newPrice2 = discountPrice(price, discType: DiscountType.BestDeal, age:age);
            Console.WriteLine("Price with discount: " + newPrice2);
            double newPrice4 = discountPrice(price2, discType: DiscountType.BestDeal, age: age);
            Console.WriteLine("Price with discount: " + newPrice4);
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

        public static double discountPrice(double price, int age = 14, DiscountType discType = DiscountType.General)
        {
            double newPrice;
            int discount = 5;
            if (age < 7) discount = 25;
            else if (age <= 14) discount = 15;

            newPrice = price * (100 - discount) / 100;
            newPrice = newPrice * (100 - (int)discType) / 100;
            return newPrice;
        }

        public static double discountPrice(int price, int age = 14, DiscountType discType = DiscountType.General)
        {
            double newPrice;
            int discount = 5;
            if (age < 7) discount = 25;
            else if (age <= 14) discount = 15;

            newPrice = price * (100 - discount) / 100;
            newPrice = newPrice * (100 - (int)discType) / 100;
            return newPrice;
        }
    }
}
