using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApplications
{
    sealed class Hotel : Property
    {
        public int Likes { get; set; }

        public Hotel(string name, string description, string address, int stars, double distanceToCenter,
                DateTime openingDate, Room[] rooms, int likes)
            : base(name, description, address, stars, distanceToCenter,
                openingDate, rooms)
        {
            Likes = likes;
        }

        public void ChangeAdress(string address)
        {
            this.address = address;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Number of likes: " + Likes);
        }

        public override double CalculateRating()
        {
            double roundedLikes = Likes;
            if (Likes > 10000) roundedLikes = 10000;
            return roundedLikes/1000 * 0.3 + 2 * Stars * 0.7;
        }
    }
}
