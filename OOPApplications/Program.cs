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
            Room room2 = new Room("Room2Desc", 2, 2, 3, RoomTypes.Double);
            Room[] rooms = new Room[] { room1, room2 };

            Property hotel = new Hotel("HotelName", "HotelDesc", "HotelAddress", 5, 10.2, DateTime.Now, rooms, 2300);
            Property guestHouse = new GuestHouse("GH2", "gh2", "HotelAddress2", 5, 10, DateTime.Now, rooms, 7);

            Property property = new Property() { Name = "Room12Desc", Description = "Room122Desc", 
                Address = "adress", DistanceToCenter = 23, Rooms = rooms, 
                OpeningDate= DateTime.Now, Stars = 3};

            guestHouse.DisplayInfo();
            Console.WriteLine();
            hotel.DisplayInfo();
            //hotel.ChangeAdress("new address");
            //hotel.DisplayInfo();

            //Console.WriteLine("Rating hotel: " + hotel.CalculateRating());
            //Console.WriteLine("Rating guestHouse: " + guestHouse.CalculateRating());
        }
    }
}
