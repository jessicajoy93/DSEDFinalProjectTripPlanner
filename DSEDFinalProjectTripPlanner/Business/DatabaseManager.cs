using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSEDFinalProjectTripPlanner.Models;

namespace DSEDFinalProjectTripPlanner.Business
{
    public static class DatabaseManager
    {
        //Ids
        public static int TripId { get; set; } = 0;
        public static int FlightId { get; set; } = 0;
        public static int LodgingId { get; set; } = 0;
        public static int OtherTransportationId { get; set; } = 0;
        public static int RestaurantId { get; set; } = 0;
        public static int CarRentalId { get; set; } = 0;
        public static int ActivityTaskId { get; set; } = 0;

        public static int TotalNumDays { get; set; }
        public static int TotalDaysToGo { get; set; }
        public static int TotalHoursToGo { get; set; }
        public static string Shortdate { get; set; }
        public static string Departure { get; set; }
        public static string Arrival { get; set; }
        public static string Duration { get; set; }
        public static DateTime TripStartDate { get; set; }
        public static int NumOfHumans { get; set; } = 0;

        public static int NumOfDays(DateTime fd, DateTime sd)
        {
            TotalNumDays = (int)(fd - sd).TotalDays;
            return TotalNumDays;
        }

        public static int NumOfDaysToGo(DateTime sd, DateTime now)
        {
            TotalDaysToGo = (int)(sd - now).TotalDays;
            return TotalDaysToGo;
        }

        public static int NumOfHoursToGo(DateTime sd, DateTime now)
        {
            TotalHoursToGo = (int)(sd - now).TotalHours;
            return TotalHoursToGo;
        }

        public static object ShortStartDate(DateTime sd)
        {
            Shortdate = sd.ToString("ddd, dd MMM yyyy");
            return Shortdate;
        }

        public static object ShortFinishDate(DateTime fd)
        {
            Shortdate = fd.ToString("ddd, dd MMM yyyy");
            return Shortdate;
        }

        public static object StartDate(DateTime sd)
        {
            Departure = sd.ToString("dd MMM yyyy");
            return Departure;
        }
        public static object FinishDate(DateTime fd)
        {
            Arrival = fd.ToString("dd MMM yyyy");
            return Arrival;
        }

        public static object DepartureDate(DateTime dd)
        {
            Departure = dd.ToString("dd MMM yyyy");
            return Departure;
        }
        public static object ArrivalDate(DateTime ad)
        {
            Arrival = ad.ToString("dd MMM yyyy");
            return Arrival;
        }

        public static object DepartureTime(DateTime dd)
        {
            Departure = dd.ToShortTimeString();
            return Departure;
        }
        public static object ArrivalTime(DateTime ad)
        {
            Arrival = ad.ToShortTimeString();
            return Arrival;
        }

        public static object FlightDuration(DateTime at, DateTime dt)
        {
            Duration = (at - dt).ToString();

            return Duration;
        }
    }
}
