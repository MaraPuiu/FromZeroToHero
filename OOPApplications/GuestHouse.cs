using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApplications
{
    class GuestHouse : Property
    {
        public int ComfortIndex { get; set; }

        public GuestHouse(string name, string description, string address, int stars, double distanceToCenter,
                DateTime openingDate, Room[] rooms, int comfortIndex)
            : base(name, description, address, stars, distanceToCenter,
                openingDate, rooms)
        {
            ComfortIndex = comfortIndex;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Comfort index: " + ComfortIndex);
        }

        public sealed override double CalculateRating()
        {
            return ComfortIndex * 0.6 + 2 * Stars * 0.4;
        }
    }
}
