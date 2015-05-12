using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime t = DateTime.Now;
            bool response = checkIfWeekend(t);
            Console.WriteLine("Is weekend: " + response);
        }

        public static bool checkIfWeekend(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) return true;
            return false;
        }
    }
}
