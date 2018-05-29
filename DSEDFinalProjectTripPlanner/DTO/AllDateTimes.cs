using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class AllDateTimes
    {
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime FinishTime { get; set; }

        //Ids
        public int TripId { get; set; }
        public int FlightId { get; set; }
        public int LodgingId { get; set; }
        public int OtherTransportationId { get; set; }
        public int RestaurantId { get; set; }
        public int CarRentalId { get; set; }
        public int ActivityTaskId { get; set; }
    }
}
