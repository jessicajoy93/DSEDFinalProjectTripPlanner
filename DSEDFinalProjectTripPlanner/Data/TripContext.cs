using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSEDFinalProjectTripPlanner.DTO;
using DSEDFinalProjectTripPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace DSEDFinalProjectTripPlanner.Data
{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext> options) : base(options)
        {
        }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Human> Travellers { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<OtherTransportation> OtherTransportations { get; set; }
        public DbSet<CarRental> CarRentals { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<ActivityTask> ActivityTasks { get; set; }
        //public DbSet<TripFlightDTO> TripFlightDtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }


}
