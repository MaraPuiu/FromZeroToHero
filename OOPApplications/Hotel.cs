using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApplications
{
    class Hotel : Property
    {
        public int Likes { get; set; }

        public Hotel(string name, string description, string address, int stars, double distanceToCenter,
                DateTime openingDate, Room[] rooms, int likes)
            : base(name, description, address, stars, distanceToCenter,
                openingDate, rooms)
        {
            Likes = likes;
        }

    }
}
