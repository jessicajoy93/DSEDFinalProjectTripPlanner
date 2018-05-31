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
    public class TripsController : Controller
    {
        private readonly TripContext _context;
        Trip _myTrip = new Trip();

        public TripsController(TripContext context)
        {

            _context = context;
        }

        // GET: Trips
        public async Task<IActionResult> Index()
        {
            return View(await _context.Trips.ToListAsync());
        }

        // GET: Trips/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trip = await _context.Trips
                .SingleOrDefaultAsync(m => m.Id == id);

            TripDTO _tfDto = new TripDTO();
            Trips _trips = new Trips();

            DatabaseManager.TripId = (int)id;
            DatabaseManager.TripStartDate = trip.StartDate;

            _trips.Id = DatabaseManager.TripId;
            _trips.Name = trip.Name;
            _trips.DestinationCity = trip.DestinationCity;
            _trips.DestinationCountry = trip.DestinationCountry;
            _trips.StartDate = trip.StartDate;
            _trips.FinishDate = trip.FinishDate;
            _trips.Description = trip.Description;
            //return _trips;

            _tfDto.AllFlights = _context.Flights.ToList();
            _tfDto.AllLodgings = _context.Lodgings.ToList();
            _tfDto.AllHumans = _context.Humans.ToList();
            _tfDto.AllOtherTransportations = _context.OtherTransportations.ToList();
            _tfDto.AllRestaurants = _context.Restaurants.ToList();

            var start = trip.StartDate;
            var end = trip.FinishDate;
            var tripdates = new List<DateTime>();
            for (var dt = start; dt <= end; dt = dt.AddDays(1))
            {
                tripdates.Add(dt);
            }
            _tfDto.GetDates = tripdates;

            if (trip == null)
            {
                return NotFound();
            }
            _tfDto.AllTrips = _trips;
            return View(_tfDto);
        }



        // GET: Trips/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trips/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,DestinationCity,DestinationCountry,StartDate,FinishDate,Description")] Trip trip)
        {

            if (ModelState.IsValid)
            {
                _context.Add(trip);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trip);
        }

        // GET: Trips/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trip = await _context.Trips.SingleOrDefaultAsync(m => m.Id == id);
            if (trip == null)
            {
                return NotFound();
            }
            return View(trip);
        }

        // POST: Trips/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,DestinationCity,DestinationCountry,StartDate,FinishDate,Description,TripId")] Trip trip)
        {
            if (id != trip.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trip);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TripExists(trip.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(trip);
        }

        // GET: Trips/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trip = await _context.Trips
                .SingleOrDefaultAsync(m => m.Id == id);
            if (trip == null)
            {
                return NotFound();
            }

            return View(trip);
        }

        // POST: Trips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trip = await _context.Trips.SingleOrDefaultAsync(m => m.Id == id);
            _context.Trips.Remove(trip);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TripExists(int id)
        {
            return _context.Trips.Any(e => e.Id == id);
        }
    }
}
