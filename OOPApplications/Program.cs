using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("Room1Desc", 1, 2, 3, RoomTypes.Single);
            Room room2 = new Room("Room2Desc", 1, 2, 3, RoomTypes.Double);
            Room[] rooms = new Room[] { room1, room2 };

            Hotel hotel = new Hotel("HotelName", "HotelDesc", "HotelAddress", 5, 100.2, DateTime.Now, rooms);

            hotel.DisplayInfo();

        }
    }
}
