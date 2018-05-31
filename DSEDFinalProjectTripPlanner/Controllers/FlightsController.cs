using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSEDFinalProjectTripPlanner.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DSEDFinalProjectTripPlanner.Data;
using DSEDFinalProjectTripPlanner.DTO;
using DSEDFinalProjectTripPlanner.Models;

namespace DSEDFinalProjectTripPlanner.Controllers
{
    public class FlightsController : Controller
    {
        private readonly Data.TripContext _context;

        public FlightsController(Data.TripContext context)
        {
            _context = context;
        }

        // GET: Flights
        public async Task<IActionResult> Index()
        {
            return View(await _context.Flights.ToListAsync());

            //return View(db.News.OrderByDescending(news => new.dateCreated).Take(10).ToList());
        }

        // GET: Flights/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = await _context.Flights
                .SingleOrDefaultAsync(m => m.Id == id);

            TripDTO _tfDto = new TripDTO();
            MyFlights _flights = new MyFlights();

            DatabaseManager.FlightId = (int)id;
            DatabaseManager.LodgingId = 0;
            DatabaseManager.OtherTransportationId = 0;
            DatabaseManager.RestaurantId = 0;
            DatabaseManager.CarRentalId = 0;
            DatabaseManager.ActivityTaskId = 0;

            _flights.Id = DatabaseManager.FlightId;
            _flights.ConfirmationNumber = flight.ConfirmationNumber;
            _flights.Airline = flight.Airline;
            _flights.FlightNumber = flight.FlightNumber;
            _flights.DepartureDate = flight.DepartureDate;
            _flights.DepartureTime = flight.DepartureTime;
            _flights.DepartureFrom = flight.DepartureFrom;
            _flights.DepartureTerminal = flight.DepartureTerminal;
            _flights.DepartureGate = flight.DepartureGate;
            _flights.ArrivalDate = flight.ArrivalDate;
            _flights.ArrivalTime = flight.ArrivalTime;
            _flights.ArrivalTo = flight.ArrivalTo;
            _flights.ArrivalTerminal = flight.ArrivalTerminal;
            _flights.ArrivalGate = flight.ArrivalGate;
            _flights.Seats = flight.Seats;
            _flights.TripId = flight.TripId;

            var allhumans = _context.Humans.ToList();
            _tfDto.AllHumans = allhumans;

            if (flight == null)
            {
                return NotFound();
            }

            _tfDto.MyFlight = _flights;
            return View(_tfDto);
        }

        // GET: Flights/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Flights/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ConfirmationNumber,Airline,FlightNumber,DepartureDate,DepartureTime,DepartureFrom,DepartureTerminal,DepartureGate,ArrivalDate,ArrivalTime,ArrivalTo,ArrivalTerminal,ArrivalGate,Seats,TripId")] Flight flight)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flight);
                await _context.SaveChangesAsync();
                int tripId = flight.TripId;
                return RedirectToAction("Details", new { flight.Id });
            }
            return View(flight);

        }



        // GET: Flights/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = await _context.Flights.SingleOrDefaultAsync(m => m.Id == id);
            if (flight == null)
            {
                return NotFound();
            }
            return View(flight);
        }

        // POST: Flights/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ConfirmationNumber,Airline,FlightNumber,DepartureDate,DepartureTime,DepartureFrom,DepartureTerminal,DepartureGate,ArrivalDate,ArrivalTime,ArrivalTo,ArrivalTerminal,ArrivalGate,Seats,TripId")] Flight flight)
        {
            if (id != flight.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flight);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightExists(flight.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { flight.Id });
            }
            return View(flight);
        }

        // GET: Flights/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = await _context.Flights
                .SingleOrDefaultAsync(m => m.Id == id);

            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }

        // POST: Flights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flight = await _context.Flights.SingleOrDefaultAsync(m => m.Id == id);
            _context.Flights.Remove(flight);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Trips", new { Id = DatabaseManager.TripId });
        }

        private bool FlightExists(int id)
        {
            return _context.Flights.Any(e => e.Id == id);
        }
    }
}
