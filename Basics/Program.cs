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
           
            Seasons season = Seasons.Winter;
            customSeasonMessage(season);
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
    }
}
