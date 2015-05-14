using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApplications
{
    public enum RoomTypes { Single = 0, Double = 1, Twin = 2, Duplex = 3, KingBedroom = 4 }

    class Room
    {
        private string description;
        private int places;
        private int number;
        private int floor;
        private RoomTypes Type { get; set; }

        public Room(string description, int places, int number, int floor, RoomTypes type)
        {
            Description = description;
            Places = places;
            Number = number;
            Floor = floor;
            Type = type;
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

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value >= 0 && value <= 10000)
                {
                    number = value;
                }
                else number = 0;
            }
        }

        public int Places
        {
            get
            {
                return places;
            }
            set
            {
                if (value >= 0 && value <= 1 && Type == RoomTypes.Single)
                {
                    places = value;
                }
                else places = 0;
            }
        }

        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    floor = value;
                }
                else floor = 0;
            }
        }


        public void DisplayInfo()
        {
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Places: " + places);
            Console.WriteLine("Number: " + Number);
            Console.WriteLine("Floor: " + Floor);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine();
        }
    }
}
