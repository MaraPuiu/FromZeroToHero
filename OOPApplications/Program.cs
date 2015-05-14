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

            Hotel hotel = new Hotel("HotelName", "HotelDesc", "HotelAddress", 5, 10.2, DateTime.Now, rooms);
            Hotel hotel2 = new Hotel("HotelName2", "HotelDesc2", "HotelAddress2", 5, 10, DateTime.Now, rooms);

            //Hotel.SetDistanceMeasurementUnit("KM");
            //Console.WriteLine(hotel.GetDistance("Miles"));

            //Hotel.SetDistanceMeasurementUnit("Miles");
            //Console.WriteLine(hotel.GetDistance("Miles"));
            //Console.WriteLine(hotel.GetDistance("KM"));
            //Console.WriteLine("Distance measurement unit: " + Hotel.GetDistanceMeasurementUnit() + "\n");

            hotel.DisplayInfo();
            //hotel2.DisplayInfo();
            
        }
    }
}
