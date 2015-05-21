using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FzthMVC.DataAccess;

namespace FZTH.MVC.DataAccess
{
    public static class Data
    {
        private static List<Hotel> hotels = new List<Hotel>()
                {
                    new Hotel
                    {
                        Id = 1,
                        Name = "Hotel International",
                        Description = "DFescriere hotel International",
                        Rating = 4,
                        City = 
                            new City{ Name = "Iasi", County = new County{ Name = "Iasi"}}
                    },
                    new Hotel
                    {
                        Id = 2,
                        Name = "Hotel Unique",
                        Description = "Un hotel unic in Bucuresti",
                        Rating = 4,
                        City = 
                            new City{ Name = "Bucuresti", County = new County{ Name = "Bucuresti"}}
                    },
                    new Hotel
                    {
                        Id = 3,
                        Name = "Hotel Mariko Inn",
                        Description = "Descriere a la Mariko",
                        Rating = 3,
                        City = 
                            new City{ Name = "Roman", County = new County{ Name = "Neamt"}}
                    }
                };

        public static List<Hotel> Hotels
        {
            get
            {
                return hotels;
            }
            set 
            {
                hotels = value;
            }
        }

        public static void Remove(int id)
        {
            var firstMatch = Hotels.First(s => s.Id == id);
            Hotels.Remove(firstMatch);
        }

        public static void Add(Hotel hotel)
        {
            Hotels.Add(hotel);
        }

        public static int MaxId()
        {
            int max = 0;
            foreach (Hotel hotel in Hotels)
                if (max < hotel.Id) max = hotel.Id; 
            return max;
        }

        public static Hotel FindHotel(int id)
        {
            foreach (Hotel hotel in Hotels)
                if (id == hotel.Id) return hotel;
            return null;
        }
    }
}