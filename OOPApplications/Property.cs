using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApplications
{
    class Property
    {
        private string name;
        private string description;
        protected string address;
        private int stars;
        private double distanceToCenter;
        private DateTime openingDate;
        public Room[] Rooms { get; set; }
        private static string distanceMeasurementUnit;
        public bool HasWiFi { get; set; }
        public bool HasIndoorPool { get; set; }

        static Property()
        {
            distanceMeasurementUnit = "Miles";
        }

        public Property()
        {

        }

        public Property(string name, string description, string address, int stars, double distanceToCenter,
                DateTime openingDate, Room[] rooms)
        {
            Name = name;
            Description = description;
            Address = address;
            Stars = stars;
            DistanceToCenter = distanceToCenter;
            OpeningDate = openingDate;
            Rooms = rooms;
        }

        #region fields
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 50)
                {
                    name = value;
                }
                else name = "";
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value.Length < 500)
                {
                    description = value;
                }
                else description = "";
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                if (value.Length < 100)
                {
                    address = value;
                }
                else address = "";
            }
        }

        public int Stars
        {
            get
            {
                return stars;
            }
            set
            {
                if (value >= 0 && value <= 5)
                {
                    stars = value;
                }
                else stars = 0;
            }
        }

        public double DistanceToCenter
        {
            get
            {
                return distanceToCenter;
            }
            set
            {
                if (value >= 0 && value < 100)
                {
                    distanceToCenter = value;
                }
                else distanceToCenter = 0;
            }
        }

        public DateTime OpeningDate
        {
            get
            {
                return openingDate;
            }
            set
            {
                if (DateTime.Compare(value, new DateTime(1800, 1, 1, 0, 0, 0)) > 0 && value < DateTime.Now)
                {
                    openingDate = value;
                }
                else openingDate = DateTime.Now;
            }
        }

        public static void SetDistanceMeasurementUnit(string distanceMeasurementUnit)
        {
            Property.distanceMeasurementUnit = distanceMeasurementUnit;
        }

        public static string GetDistanceMeasurementUnit()
        {
            return Property.distanceMeasurementUnit;
        }

        public double GetDistance(string unit)
        {
            if (unit.Equals(distanceMeasurementUnit)) return DistanceToCenter;
            if (unit.Equals("KM")) return DistanceMeasurementConverter.milesToKM(DistanceToCenter);
            if (unit.Equals("Miles")) return DistanceMeasurementConverter.kmToMiles(DistanceToCenter);
            return 0;
        }
        #endregion

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Adress: " + Address);
            Console.WriteLine("Stars: " + Stars);
            Console.WriteLine("Distance to center: " + DistanceToCenter + distanceMeasurementUnit);
            Console.WriteLine("Opening date: " + OpeningDate);
            Console.WriteLine("Number of rooms: " + Rooms.Length);

            Console.WriteLine();

            foreach (Room room in Rooms)
            {
                room.DisplayInfo();
            }
            Console.WriteLine();
        }

        public virtual double CalculateRating()
        {
            return 2 * Stars;
        }
    }
}
