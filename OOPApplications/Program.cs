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
            Hotel hotel = new Hotel();
            Room room1 = new Room();
            Room room2 = new Room();

            hotel.name = "HotelName";
            hotel.description = "HotelDesc";
            hotel.address = "HotelAddress";
            hotel.stars = 5;
            hotel.distanceToCenter = 100.2;
            hotel.openingDate = DateTime.Now;

            room1.description = "Room1Desc";
            room1.floor = 3;
            room1.places = 3;
            room1.number = 4;
            room1.type = RoomTypes.Single;

            room2.description = "Room2Desc";
            room2.floor = 3;
            room2.places = 3;
            room2.number = 4;
            room2.type = RoomTypes.Double;

            hotel.rooms = new Room[] { room1, room2 };

            Console.WriteLine("name: " + hotel.name + " adress: " + hotel.address + " opening year: " + hotel.openingDate.Year + " number of rooms: " + hotel.rooms.Length);

        }
    }
}
