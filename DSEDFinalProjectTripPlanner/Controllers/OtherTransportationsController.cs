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
    public class OtherTransportationsController : Controller
    {
        private readonly TripContext _context;

        public OtherTransportationsController(TripContext context)
        {
            _context = context;
        }

        // GET: OtherTransportations
        public async Task<IActionResult> Index()
        {
            return View(await _context.OtherTransportations.ToListAsync());
        }

        // GET: OtherTransportations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otherTransportation = await _context.OtherTransportations
                .SingleOrDefaultAsync(m => m.Id == id);

            TripDTO _tfDto = new TripDTO();
            MyOtherTransportations _ot = new MyOtherTransportations();

            DatabaseManager.FlightId = 0;
            DatabaseManager.LodgingId = 0;
            DatabaseManager.OtherTransportationId = (int)id;
            DatabaseManager.RestaurantId = 0;
            DatabaseManager.CarRentalId = 0;
            DatabaseManager.ActivityTaskId = 0;

            _ot.Id = DatabaseManager.OtherTransportationId;
            _ot.TypeOfTransport = otherTransportation.TypeOfTransport;
            _ot.CarrierName = otherTransportation.CarrierName;
            _ot.DepartureAddress = otherTransportation.DepartureAddress;
            _ot.DepartureSuburb = otherTransportation.DepartureSuburb;
            _ot.DepartureCity = otherTransportation.DepartureCity;
            _ot.DepartureRegion = otherTransportation.DepartureRegion;
            _ot.DeparturePostcode = otherTransportation.DeparturePostcode;
            _ot.DepartureCountry = otherTransportation.DepartureCountry;
            _ot.DepartureDate = otherTransportation.DepartureDate;
            _ot.DepartureTime = otherTransportation.DepartureTime;
            _ot.ArrivalAddress = otherTransportation.ArrivalAddress;
            _ot.ArrivalSuburb = otherTransportation.ArrivalSuburb;
            _ot.ArrivalCity = otherTransportation.ArrivalCity;
            _ot.ArrivalRegion = otherTransportation.ArrivalRegion;
            _ot.ArrivalPostcode = otherTransportation.ArrivalPostcode;
            _ot.ArrivalCountry = otherTransportation.ArrivalCountry;
            _ot.ArrivalDate = otherTransportation.ArrivalDate;
            _ot.ArrivalTime = otherTransportation.ArrivalTime;
            _ot.TripId = otherTransportation.TripId;

            _tfDto.AllHumans = _context.Humans.ToList();


            if (otherTransportation == null)
            {
                return NotFound();
            }

            _tfDto.MyOtherTransportation = _ot;
            return View(_tfDto);
        }

        // GET: OtherTransportations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OtherTransportations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TypeOfTransport,CarrierName,ConfirmationNumber,DepartureAddress,DepartureSuburb,DepartureCity,DepartureRegion,DeparturePostcode,DepartureCountry,DepartureDate,DepartureTime,ArrivalDate,ArrivalTime,ArrivalAddress,ArrivalSuburb,ArrivalCity,ArrivalRegion,ArrivalPostcode,ArrivalCountry,TripId")] OtherTransportation otherTransportation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(otherTransportation);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new { otherTransportation.Id });
            }
            return View(otherTransportation);
        }

        // GET: OtherTransportations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otherTransportation = await _context.OtherTransportations.SingleOrDefaultAsync(m => m.Id == id);
            if (otherTransportation == null)
            {
                return NotFound();
            }
            return View(otherTransportation);
        }

        // POST: OtherTransportations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TypeOfTransport,CarrierName,ConfirmationNumber,DepartureAddress,DepartureSuburb,DepartureCity,DepartureRegion,DeparturePostcode,DepartureCountry,DepartureDate,DepartureTime,ArrivalDate,ArrivalTime,ArrivalAddress,ArrivalSuburb,ArrivalCity,ArrivalRegion,ArrivalPostcode,ArrivalCountry,TripId")] OtherTransportation otherTransportation)
        {
            if (id != otherTransportation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(otherTransportation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OtherTransportationExists(otherTransportation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { otherTransportation.Id });
            }
            return View(otherTransportation);
        }

        // GET: OtherTransportations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otherTransportation = await _context.OtherTransportations
                .SingleOrDefaultAsync(m => m.Id == id);
            if (otherTransportation == null)
            {
                return NotFound();
            }

            return View(otherTransportation);
        }

        // POST: OtherTransportations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var otherTransportation = await _context.OtherTransportations.SingleOrDefaultAsync(m => m.Id == id);
            _context.OtherTransportations.Remove(otherTransportation);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Trips", new { Id = DatabaseManager.TripId });
        }

        private bool OtherTransportationExists(int id)
        {
            return _context.OtherTransportations.Any(e => e.Id == id);
        }
    }
}
