using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApplications
{
    public enum RoomTypes { Single = 0, Double = 1, Twin = 2, Duplex = 3, KingBedroom = 4 }

    class Room
    {
        public string description;
        public int places;
        public int number;
        public int floor;
        public RoomTypes type;
    }
}
