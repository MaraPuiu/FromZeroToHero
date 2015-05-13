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

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Description: " + description);
            Console.WriteLine("Adress: " + address);
            Console.WriteLine("Stars: " + stars);
            Console.WriteLine("Opening date: " + openingDate);
            Console.WriteLine("Number of rooms: " + rooms.Length);

            foreach (Room room in rooms)
            {
                room.DisplayInfo();
            }
        }
    }
}
