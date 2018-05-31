using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSEDFinalProjectTripPlanner.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DSEDFinalProjectTripPlanner.Data;
using DSEDFinalProjectTripPlanner.Models;

namespace DSEDFinalProjectTripPlanner.Controllers
{
    public class LodgingsController : Controller
    {
        private readonly TripContext _context;

        public LodgingsController(TripContext context)
        {
            _context = context;
        }

        // GET: Lodgings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lodgings.ToListAsync());
        }

        // GET: Lodgings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lodging = await _context.Lodgings
                .SingleOrDefaultAsync(m => m.Id == id);

            DatabaseManager.FlightId = 0;
            DatabaseManager.LodgingId = (int)id;
            DatabaseManager.OtherTransportationId = 0;
            DatabaseManager.RestaurantId = 0;
            DatabaseManager.CarRentalId = 0;
            DatabaseManager.ActivityTaskId = 0;

            if (lodging == null)
            {
                return NotFound();
            }

            return View(lodging);
        }

        // GET: Lodgings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lodgings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ConfirmationNumber,LodgingName,Address,AddressSuburb,AddressCity,AddressRegion,AddressPostcode,AddressCountry,ArrivalDate,ArrivalTime,DepartureDate,DepartureTime,NumOfGuests,NumOfRooms,RoomDescription,TripId")] Lodging lodging)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lodging);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new { lodging.Id });
            }
            return View(lodging);
        }

        // GET: Lodgings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lodging = await _context.Lodgings.SingleOrDefaultAsync(m => m.Id == id);
            if (lodging == null)
            {
                return NotFound();
            }
            return View(lodging);
        }

        // POST: Lodgings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ConfirmationNumber,LodgingName,Address,AddressSuburb,AddressCity,AddressRegion,AddressPostcode,AddressCountry,ArrivalDate,ArrivalTime,DepartureDate,DepartureTime,NumOfGuests,NumOfRooms,RoomDescription,TripId")] Lodging lodging)
        {
            if (id != lodging.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lodging);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LodgingExists(lodging.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { lodging.Id });
            }
            return View(lodging);
        }

        // GET: Lodgings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lodging = await _context.Lodgings
                .SingleOrDefaultAsync(m => m.Id == id);
            if (lodging == null)
            {
                return NotFound();
            }

            return View(lodging);
        }

        // POST: Lodgings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lodging = await _context.Lodgings.SingleOrDefaultAsync(m => m.Id == id);
            _context.Lodgings.Remove(lodging);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Trips", new { Id = DatabaseManager.TripId });
        }

        private bool LodgingExists(int id)
        {
            return _context.Lodgings.Any(e => e.Id == id);
        }
    }
}
