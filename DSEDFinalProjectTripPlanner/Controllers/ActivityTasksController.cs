using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DSEDFinalProjectTripPlanner.Data;
using DSEDFinalProjectTripPlanner.Models;
using DSEDFinalProjectTripPlanner.Business;

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
            if (activityTask == null)
            {
                return NotFound();
            }

            return View(activityTask);
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
