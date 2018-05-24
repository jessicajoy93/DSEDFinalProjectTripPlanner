using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSEDFinalProjectTripPlanner.Business;
using DSEDFinalProjectTripPlanner.Models;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class TripFlightDTO
    {
        private readonly Trips _trips = new Trips();
        public int Id { get; set; }

        //public List<Trips> AllTrips { get; set; }
        public Trips AllTrips { get; set; }
        public List<Flight> AllFlights { get; set; }
        public List<Human> AllHumans { get; set; }
        public List<Human> GetHumans { get; set; }



    }
}
