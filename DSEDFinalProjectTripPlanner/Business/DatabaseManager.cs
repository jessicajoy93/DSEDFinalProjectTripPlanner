using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSEDFinalProjectTripPlanner.Models;

namespace DSEDFinalProjectTripPlanner.Business
{
    public static class DatabaseManager
    {
        static Trip _myTrip = new Trip();
        public static int TotalNumDays { get; set; }
        public static int TotalDaysToGo { get; set; }

        public static int NumOfDaysAway(DateTime fd, DateTime sd)
        {
            TotalNumDays = (int)(fd - sd).TotalDays;
            return TotalNumDays;
        }

        public static int NumOfDaysToGo(DateTime sd, DateTime now)
        {
            TotalDaysToGo = (int)(sd - now).TotalDays;
            return TotalDaysToGo;
        }

        public static void Months()
        {

        }
    }
}
