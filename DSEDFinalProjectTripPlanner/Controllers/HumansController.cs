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
    public class HumansController : Controller
    {
        private readonly Data.TripContext _context;

        public HumansController(Data.TripContext context)
        {
            _context = context;
        }

        public IActionResult NumberOfHumans()
        {
            return View();
        }

        // GET: Humans
        public async Task<IActionResult> Index()
        {
            return View(await _context.Travellers.ToListAsync());
        }

        // GET: Humans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var human = await _context.Travellers
                .SingleOrDefaultAsync(m => m.Id == id);
            if (human == null)
            {
                return NotFound();
            }

            return View(human);
        }

        // GET: Humans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Humans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fullname, FrequentFlyerNumber,TicketNumber,TripId,FlightId,LodgingId,OtherTransportationId,RestaurantId,CarRentalId,ActivityTaskId")] Human human)
        {
            if (ModelState.IsValid)
            {
                _context.Add(human);
                await _context.SaveChangesAsync();

                if (DatabaseManager.FlightId != 0)
                {
                    return RedirectToAction("Details", "Flights", new { Id = human.FlightId });
                }
                if (DatabaseManager.LodgingId != 0)
                {
                    return RedirectToAction("Details", "Lodgings", new { Id = human.LodgingId });
                }
                if (DatabaseManager.OtherTransportationId != 0)
                {
                    return RedirectToAction("Details", "OtherTransportations", new { Id = human.OtherTransportationId });
                }
                //if (DatabaseManager.RestaurantId != 0)
                //{
                //    return RedirectToAction("Details", "Restaurants", new { Id = human.RestaurantId });
                //}
                //if (DatabaseManager.CarRentalId != 0)
                //{
                //    return RedirectToAction("Details", "CarRentals", new { Id = human.CarRentalId });
                //}
                //if (DatabaseManager.ActivityTaskId != 0)
                //{
                //    return RedirectToAction("Details", "ActivityTasks", new { Id = human.ActivityTaskId });
                //}


            }
            return View(human);
        }

        // GET: Humans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var human = await _context.Travellers.SingleOrDefaultAsync(m => m.Id == id);
            if (human == null)
            {
                return NotFound();
            }
            return View(human);
        }

        // POST: Humans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fullname, FrequentFlyerNumber,TicketNumber,TripId,FlightId,LodgingId,OtherTransportationId,RestaurantId,CarRentalId,ActivityTaskId")] Human human)
        {
            if (id != human.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(human);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HumanExists(human.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                if (DatabaseManager.FlightId != 0)
                {
                    return RedirectToAction("Details", "Flights", new { Id = human.FlightId });
                }
                if (DatabaseManager.LodgingId != 0)
                {
                    return RedirectToAction("Details", "Lodgings", new { Id = human.LodgingId });
                }
                if (DatabaseManager.OtherTransportationId != 0)
                {
                    return RedirectToAction("Details", "OtherTransportations", new { Id = human.OtherTransportationId });
                }
                //if (DatabaseManager.RestaurantId != 0)
                //{
                //    return RedirectToAction("Details", "Restaurants", new { Id = human.RestaurantId });
                //}
                //if (DatabaseManager.CarRentalId != 0)
                //{
                //    return RedirectToAction("Details", "CarRentals", new { Id = human.CarRentalId });
                //}
                //if (DatabaseManager.ActivityTaskId != 0)
                //{
                //    return RedirectToAction("Details", "ActivityTasks", new { Id = human.ActivityTaskId });
                //}
            }
            return View(human);
        }

        // GET: Humans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var human = await _context.Travellers
                .SingleOrDefaultAsync(m => m.Id == id);
            if (human == null)
            {
                return NotFound();
            }

            return View(human);
        }

        // POST: Humans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var human = await _context.Travellers.SingleOrDefaultAsync(m => m.Id == id);
            _context.Travellers.Remove(human);
            await _context.SaveChangesAsync();


            if (DatabaseManager.FlightId != 0)
            {
                return RedirectToAction("Details", "Flights", new { Id = human.FlightId });
            }
            if (DatabaseManager.LodgingId != 0)
            {
                return RedirectToAction("Details", "Lodgings", new { Id = human.LodgingId });
            }
            if (DatabaseManager.OtherTransportationId != 0)
            {
                return RedirectToAction("Details", "OtherTransportations", new { Id = human.OtherTransportationId });
            }
            //if (DatabaseManager.RestaurantId != 0)
            //{
            //    return RedirectToAction("Details", "Restaurants", new { Id = human.RestaurantId });
            //}
            //if (DatabaseManager.CarRentalId != 0)
            //{
            //    return RedirectToAction("Details", "CarRentals", new { Id = human.CarRentalId });
            //}
            //if (DatabaseManager.ActivityTaskId != 0)
            //{
            //    return RedirectToAction("Details", "ActivityTasks", new { Id = human.ActivityTaskId });
            //}
            return RedirectToAction("Details", "Trips", new { Id = DatabaseManager.TripId });
        }

        private bool HumanExists(int id)
        {
            return _context.Travellers.Any(e => e.Id == id);
        }
    }
}
