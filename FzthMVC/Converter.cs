using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using FzthMVC.DataAccess;
using FzthMVC.Entities;
using Hotel = FZTH.MVC.DataAccess.Hotel;

namespace FzthMVC
{
    public class Converter
    {
        public static List<Hotel> FromEntityToModel(List<Entities.Hotel> hotelEntities)
        {
            List<Hotel> hotels = new List<Hotel>();

            foreach (var hotelEntity in hotelEntities)
            {
                var hotel = new Hotel
                {
                    Name =  hotelEntity.Name,
                    Id = hotelEntity.Id,
                    Description = "No Description",
                    Rating = 4,
                    City = new City{ Name = hotelEntity.Location.City, County = new County{ Name = hotelEntity.Location.County}}
                };

                hotels.Add(hotel);
            }

            return hotels;
        }

        public static Hotel FromEntityToModelOne(Entities.Hotel hotelEntity)
        {
            return new Hotel
            {
                Name = hotelEntity.Name,
                Id = hotelEntity.Id,
                Description = "No Description",
                Rating = 4,
                City = new City { Name = hotelEntity.Location.City, County = new County { Name = hotelEntity.Location.County } }
            };
        }

        public static List<Entities.Hotel> FromModelToEntity(List<Hotel> hotels)
        {
            List<Entities.Hotel> hotelEntities = new List<Entities.Hotel>();

            foreach (var hotel in hotels)
            {
                var hotelEntity = new Entities.Hotel
                {
                    Name = hotel.Name,
                    Id = hotel.Id,
                    Location = new Location{Id = hotel.City.Id, City = hotel.City.Name, County = hotel.City.County.Name }
                };

                hotelEntities.Add(hotelEntity);
            }

            return hotelEntities;
        }

        public static Entities.Hotel FromModelToEntityOne(Hotel hotel)
        {
            return new Entities.Hotel
            {
                Name = hotel.Name,
                Id = hotel.Id,
                Location = new Location { Id = hotel.City.Id, City = hotel.City.Name, County = hotel.City.County.Name }
            };
        }
    }
}