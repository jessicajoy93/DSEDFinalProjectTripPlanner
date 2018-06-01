using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSEDFinalProjectTripPlanner.Business;
using DSEDFinalProjectTripPlanner.Models;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class TripDTO
    {
        private readonly Trips _trips = new Trips();
        public int Id { get; set; }

        public List<Flight> AllFlights { get; set; }
        public List<Human> AllHumans { get; set; }
        public List<DateTime> GetDates { get; set; }
        public List<Lodging> AllLodgings { get; set; }
        public List<OtherTransportation> AllOtherTransportations { get; set; }
        public List<Restaurant> AllRestaurants { get; set; }
        public List<ActivityTask> AllActivities { get; set; }
        public List<CarRental> AllCarRentals { get; set; }


        public Trips AllTrips { get; set; }
        public MyFlights MyFlight { get; set; }
        public MyOtherTransportations MyOtherTransportation { get; set; }
        public MyRestaurants MyRestaurant { get; set; }
        public MyActivities MyActivity { get; set; }
        public MyCarRentals MyCarRental { get; set; }



    }
}
