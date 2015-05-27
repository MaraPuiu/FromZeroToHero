using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using FzthMVC.DataAccess;
using FZTH.MVC.DataAccess;

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
                    City = new City{ Name = "Iasi", County = new County{ Name = "Iasi"}}
                };

                hotels.Add(hotel);
            }

            return hotels;
        }
    }
}