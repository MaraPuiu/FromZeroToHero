using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApplications
{
    class Hotel
    {
        public string name;
        public string description;
        public string address;
        public int stars;
        public double distanceToCenter;
        public DateTime openingDate;
        public Room[] rooms;
        private static string distanceMeasurementUnit;

        static Hotel() {
            distanceMeasurementUnit = "Miles";
        }

        public Hotel(string name, string description, string address, int stars, double distanceToCenter,
                DateTime openingDate, Room[] rooms)
        {
            this.name = name;
            this.description = description;
            this.address = address;
            this.stars = stars;
            this.distanceToCenter = distanceToCenter;
            this.openingDate = openingDate;
            this.rooms = rooms;
        }

        public static void SetDistanceMeasurementUnit(string distanceMeasurementUnit)
        {
            Hotel.distanceMeasurementUnit = distanceMeasurementUnit;
        }

        public static string GetDistanceMeasurementUnit()
        {
            return Hotel.distanceMeasurementUnit;
        }

        public double GetDistance(string unit)
        {
            if (unit.Equals(distanceMeasurementUnit)) return distanceToCenter;
            if (unit.Equals("KM")) return DistanceMeasurementConverter.milesToKM(distanceToCenter);
            if (unit.Equals("Miles")) return DistanceMeasurementConverter.kmToMiles(distanceToCenter);
            return 0;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Description: " + description);
            Console.WriteLine("Adress: " + address);
            Console.WriteLine("Stars: " + stars);
            Console.WriteLine("Distance to center: " + distanceToCenter + distanceMeasurementUnit);
            Console.WriteLine("Opening date: " + openingDate);
            Console.WriteLine("Number of rooms: " + rooms.Length);

            Console.WriteLine();

            foreach (Room room in rooms)
            {
                room.DisplayInfo();
            }
            Console.WriteLine();
        }
    }
}
