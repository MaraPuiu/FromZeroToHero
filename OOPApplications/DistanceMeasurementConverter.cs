using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApplications
{
    static class DistanceMeasurementConverter
    {
        public static double kmToMiles(double distance)
        {
            return distance * 1.609;
        }

        public static double milesToKM(double distance)
        {
            return distance / 1.609;
        }
    }
}
