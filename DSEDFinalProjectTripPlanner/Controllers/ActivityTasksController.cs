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
    public class ActivityTasksController : Controller
    {
        private readonly TripContext _context;

        public ActivityTasksController(TripContext context)
        {
            _context = context;
        }

        // GET: ActivityTasks
        public async Task<IActionResult> Index()
        {
            return View(await _context.ActivityTasks.ToListAsync());
        }

        // GET: ActivityTasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activityTask = await _context.ActivityTasks
                .SingleOrDefaultAsync(m => m.Id == id);

            TripDTO _tfDto = new TripDTO();
            MyActivities _activity = new MyActivities();

            DatabaseManager.FlightId = 0;
            DatabaseManager.LodgingId = 0;
            DatabaseManager.OtherTransportationId = 0;
            DatabaseManager.RestaurantId = 0;
            DatabaseManager.CarRentalId = 0;
            DatabaseManager.ActivityTaskId = (int)id;

            _activity.Id = DatabaseManager.ActivityTaskId;
            _activity.TypeOfActivity = activityTask.TypeOfActivity;
            _activity.ConfirmationNumber = activityTask.ConfirmationNumber;
            _activity.SupplierName = activityTask.SupplierName;
            _activity.Description = activityTask.Description;
            _activity.StartDate = activityTask.StartDate;
            _activity.StartTime = activityTask.StartTime;
            _activity.EndDate = activityTask.EndDate;
            _activity.EndTime = activityTask.EndTime;
            _activity.Address = activityTask.Address;
            _activity.Suburb = activityTask.Suburb;
            _activity.City = activityTask.City;
            _activity.Region = activityTask.Region;
            _activity.Postcode = activityTask.Postcode;
            _activity.Country = activityTask.Country;
            _activity.NumOfPeopleAttending = activityTask.NumOfPeopleAttending;
            _activity.TripId = activityTask.TripId;

            _tfDto.AllHumans = _context.Humans.ToList();

            if (activityTask == null)
            {
                return NotFound();
            }

            _tfDto.MyActivity = _activity;

            return View(_tfDto);
        }

        // GET: ActivityTasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ActivityTasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TypeOfActivity,ConfirmationNumber,SupplierName,Description,StartDate,StartTime,EndDate,EndTime,Address,Suburb,City,Region,Postcode,Country,NumOfPeopleAttending,TripId")] ActivityTask activityTask)
        {
            if (ModelState.IsValid)
            {
                _context.Add(activityTask);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new { activityTask.Id });
            }
            return View(activityTask);
        }

        // GET: ActivityTasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activityTask = await _context.ActivityTasks.SingleOrDefaultAsync(m => m.Id == id);
            if (activityTask == null)
            {
                return NotFound();
            }
            return View(activityTask);
        }

        // POST: ActivityTasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TypeOfActivity,ConfirmationNumber,SupplierName,Description,StartDate,StartTime,EndDate,EndTime,Address,Suburb,City,Region,Postcode,Country,NumOfPeopleAttending,TripId")] ActivityTask activityTask)
        {
            if (id != activityTask.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(activityTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActivityTaskExists(activityTask.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { activityTask.Id });
            }
            return View(activityTask);
        }

        // GET: ActivityTasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activityTask = await _context.ActivityTasks
                .SingleOrDefaultAsync(m => m.Id == id);
            if (activityTask == null)
            {
                return NotFound();
            }

            return View(activityTask);
        }

        // POST: ActivityTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var activityTask = await _context.ActivityTasks.SingleOrDefaultAsync(m => m.Id == id);
            _context.ActivityTasks.Remove(activityTask);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Trips", new { Id = @DatabaseManager.TripId });
        }

        private bool ActivityTaskExists(int id)
        {
            return _context.ActivityTasks.Any(e => e.Id == id);
        }
    }
}
