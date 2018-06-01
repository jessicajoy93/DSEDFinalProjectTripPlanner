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
    public class CarRentalsController : Controller
    {
        private readonly TripContext _context;

        public CarRentalsController(TripContext context)
        {
            _context = context;
        }

        // GET: CarRentals
        public async Task<IActionResult> Index()
        {
            return View(await _context.CarRentals.ToListAsync());
        }

        // GET: CarRentals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carRental = await _context.CarRentals
                .SingleOrDefaultAsync(m => m.Id == id);

            TripDTO _tDto = new TripDTO();
            MyCarRentals _cr = new MyCarRentals();

            DatabaseManager.FlightId = 0;
            DatabaseManager.LodgingId = 0;
            DatabaseManager.OtherTransportationId = 0;
            DatabaseManager.RestaurantId = 0;
            DatabaseManager.CarRentalId = (int)id;
            DatabaseManager.ActivityTaskId = 0;

            _cr.Id = DatabaseManager.CarRentalId;
            _cr.SuppplierName = carRental.SuppplierName;
            _cr.ConfirmationNumber = carRental.ConfirmationNumber;
            _cr.PickupName = carRental.PickupName;
            _cr.PickupAddress = carRental.PickupAddress;
            _cr.PickupSuburb = carRental.PickupSuburb;
            _cr.PickupCity = carRental.PickupCity;
            _cr.PickupRegion = carRental.PickupRegion;
            _cr.PickupPostcode = carRental.PickupPostcode;
            _cr.PickupCountry = carRental.PickupCountry;
            _cr.PickupDate = carRental.PickupDate;
            _cr.PickupTime = carRental.PickupTime;
            _cr.DropoffAddress = carRental.DropoffAddress;
            _cr.DropoffSuburb = carRental.DropoffSuburb;
            _cr.DropoffCity = carRental.DropoffCity;
            _cr.DropoffRegion = carRental.DropoffRegion;
            _cr.DropoffPostcode = carRental.DropoffPostcode;
            _cr.DropoffCountry = carRental.DropoffCountry;
            _cr.DropoffDate = carRental.DropoffDate;
            _cr.DropoffTime = carRental.DropoffTime;
            _cr.SupplierPhoneNumber = carRental.SupplierPhoneNumber;
            _cr.TripId = carRental.TripId;
            _cr.DropoffCheckbox = carRental.DropoffCheckbox;
            _cr.Door = carRental.Door;
            _cr.Seats = carRental.Seats;
            _cr.Transmission = carRental.Transmission;
            _cr.LargeBag = carRental.LargeBag;
            _cr.SmallBag = carRental.SmallBag;
            _cr.Litres = carRental.Litres;

            _tDto.AllHumans = _context.Humans.ToList();

            if (carRental == null)
            {
                return NotFound();
            }

            _tDto.MyCarRental = _cr;
            return View(_tDto);
        }

        // GET: CarRentals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarRentals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SuppplierName,ConfirmationNumber,PickupName,PickupAddress,PickupSuburb,PickupCity,PickupRegion,PickupPostcode,PickupCountry,DropoffAddress,DropoffSuburb,DropoffCity,DropoffRegion,DropoffPostcode,DropoffCountry,PickupDate,PickupTime,DropoffDate,DropoffTime,SupplierPhoneNumber,TripId,DropoffCheckbox,Door,Seats,Transmisson,LargeBag,SmallBag,Litres")] CarRental carRental)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carRental);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new { carRental.Id });
            }
            return View(carRental);
        }

        // GET: CarRentals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carRental = await _context.CarRentals.SingleOrDefaultAsync(m => m.Id == id);
            if (carRental == null)
            {
                return NotFound();
            }
            return View(carRental);
        }

        // POST: CarRentals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SuppplierName,ConfirmationNumber,PickupName,PickupAddress,PickupSuburb,PickupCity,PickupRegion,PickupPostcode,PickupCountry,DropoffAddress,DropoffSuburb,DropoffCity,DropoffRegion,DropoffPostcode,DropoffCountry,PickupDate,PickupTime,DropoffDate,DropoffTime,SupplierPhoneNumber,TripId,DropoffCheckbox,Door,Seats,Transmisson,LargeBag,SmallBag,Litres")] CarRental carRental)
        {
            if (id != carRental.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carRental);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarRentalExists(carRental.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { carRental.Id });
            }
            return View(carRental);
        }

        // GET: CarRentals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carRental = await _context.CarRentals
                .SingleOrDefaultAsync(m => m.Id == id);
            if (carRental == null)
            {
                return NotFound();
            }

            return View(carRental);
        }

        // POST: CarRentals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carRental = await _context.CarRentals.SingleOrDefaultAsync(m => m.Id == id);
            _context.CarRentals.Remove(carRental);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", new { Id = DatabaseManager.TripId });
        }

        private bool CarRentalExists(int id)
        {
            return _context.CarRentals.Any(e => e.Id == id);
        }
    }
}
