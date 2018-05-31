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
    public class RestaurantsController : Controller
    {
        private readonly TripContext _context;

        public RestaurantsController(TripContext context)
        {
            _context = context;
        }

        // GET: Restaurants
        public async Task<IActionResult> Index()
        {
            return View(await _context.Restaurants.ToListAsync());
        }

        // GET: Restaurants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurants
                .SingleOrDefaultAsync(m => m.Id == id);

            TripDTO _tfDto = new TripDTO();
            MyRestaurants _restaurant = new MyRestaurants();

            DatabaseManager.FlightId = 0;
            DatabaseManager.LodgingId = 0;
            DatabaseManager.OtherTransportationId = 0;
            DatabaseManager.RestaurantId = (int)id;
            DatabaseManager.CarRentalId = 0;
            DatabaseManager.ActivityTaskId = 0;

            _restaurant.Id = DatabaseManager.RestaurantId;
            _restaurant.RestaurantName = restaurant.RestaurantName;
            _restaurant.Address = restaurant.Address;
            _restaurant.Suburb = restaurant.Suburb;
            _restaurant.City = restaurant.City;
            _restaurant.Region = restaurant.Region;
            _restaurant.Postcode = restaurant.Postcode;
            _restaurant.Country = restaurant.Country;
            _restaurant.Description = restaurant.Description;
            _restaurant.Date = restaurant.Date;
            _restaurant.Time = restaurant.Time;
            _restaurant.Cuisine = restaurant.Cuisine;
            _restaurant.NumberInParty = restaurant.NumberInParty;
            _restaurant.ConfirmationNumber = restaurant.ConfirmationNumber;
            _restaurant.HoursOfOperation = restaurant.HoursOfOperation;
            _restaurant.DressCode = restaurant.DressCode;
            _restaurant.PriceRange = restaurant.PriceRange;
            _restaurant.TripId = restaurant.TripId;

            _tfDto.AllHumans = _context.Humans.ToList();

            if (restaurant == null)
            {
                return NotFound();
            }

            _tfDto.MyRestaurant = _restaurant;

            return View(_tfDto);
        }

        // GET: Restaurants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Restaurants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RestaurantName,Address,Suburb,City,Region,Postcode,Country,Description,Date,Time,Cuisine,NumberInParty,ConfirmationNumber,HoursOfOperation,DressCode,PriceRange,TripId")] Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(restaurant);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new { restaurant.Id });
            }
            return View(restaurant);
        }

        // GET: Restaurants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurants.SingleOrDefaultAsync(m => m.Id == id);
            if (restaurant == null)
            {
                return NotFound();
            }
            return View(restaurant);
        }

        // POST: Restaurants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RestaurantName,Address,Suburb,City,Region,Postcode,Country,Description,Date,Time,Cuisine,NumberInParty,ConfirmationNumber,HoursOfOperation,DressCode,PriceRange,TripId")] Restaurant restaurant)
        {
            if (id != restaurant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(restaurant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestaurantExists(restaurant.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { restaurant.Id });
            }
            return View(restaurant);
        }

        // GET: Restaurants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurants
                .SingleOrDefaultAsync(m => m.Id == id);
            if (restaurant == null)
            {
                return NotFound();
            }

            return View(restaurant);
        }

        // POST: Restaurants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var restaurant = await _context.Restaurants.SingleOrDefaultAsync(m => m.Id == id);
            _context.Restaurants.Remove(restaurant);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", new { Id = DatabaseManager.TripId });
        }

        private bool RestaurantExists(int id)
        {
            return _context.Restaurants.Any(e => e.Id == id);
        }
    }
}
