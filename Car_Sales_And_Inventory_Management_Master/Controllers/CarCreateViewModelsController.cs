using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Car_Sales_And_Inventory_Management_Master.Data;
using Car_Sales_And_Inventory_Management_Master.ViewModel;

namespace Car_Sales_And_Inventory_Management_Master.Controllers
{
    public class CarCreateViewModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarCreateViewModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CarCreateViewModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.CarCreateViewModel.ToListAsync());
        }

        // GET: CarCreateViewModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carCreateViewModel = await _context.CarCreateViewModel
                .FirstOrDefaultAsync(m => m.car_id == id);
            if (carCreateViewModel == null)
            {
                return NotFound();
            }

            return View(carCreateViewModel);
        }

        // GET: CarCreateViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarCreateViewModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("car_id,name,car_model,launch_date,no_of_images,rating,specification_id,type,average,max_speed,price,dimensionsId,no_of_seats,free_space,airbags,fuel_Consumption_Type,additional_description,engine_model,performance,efficiency")] CarCreateViewModel carCreateViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carCreateViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carCreateViewModel);
        }

        // GET: CarCreateViewModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carCreateViewModel = await _context.CarCreateViewModel.FindAsync(id);
            if (carCreateViewModel == null)
            {
                return NotFound();
            }
            return View(carCreateViewModel);
        }

        // POST: CarCreateViewModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("car_id,name,car_model,launch_date,no_of_images,rating,specification_id,type,average,max_speed,price,dimensionsId,no_of_seats,free_space,airbags,fuel_Consumption_Type,additional_description,engine_model,performance,efficiency")] CarCreateViewModel carCreateViewModel)
        {
            if (id != carCreateViewModel.car_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carCreateViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarCreateViewModelExists(carCreateViewModel.car_id))
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
            return View(carCreateViewModel);
        }

        // GET: CarCreateViewModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carCreateViewModel = await _context.CarCreateViewModel
                .FirstOrDefaultAsync(m => m.car_id == id);
            if (carCreateViewModel == null)
            {
                return NotFound();
            }

            return View(carCreateViewModel);
        }

        // POST: CarCreateViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var carCreateViewModel = await _context.CarCreateViewModel.FindAsync(id);
            _context.CarCreateViewModel.Remove(carCreateViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarCreateViewModelExists(string id)
        {
            return _context.CarCreateViewModel.Any(e => e.car_id == id);
        }
    }
}
