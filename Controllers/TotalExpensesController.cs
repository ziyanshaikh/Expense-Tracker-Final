using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Models;

namespace ExpenseTracker.Controllers
{
    public class TotalExpensesController : Controller
    {
        private readonly AppDbContext _context;

        public TotalExpensesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: TotalExpenses
        public async Task<IActionResult> Index()
        {
              return View(await _context.TotalExpense.ToListAsync());
        }

        // GET: TotalExpenses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TotalExpense == null)
            {
                return NotFound();
            }

            var totalExpense = await _context.TotalExpense
                .FirstOrDefaultAsync(m => m.TotalExpenseId == id);
            if (totalExpense == null)
            {
                return NotFound();
            }

            return View(totalExpense);
        }

        // GET: TotalExpenses/Create
        public IActionResult Create()
        {
            var totalExpense = _context.TotalExpense.Count() > 0 ? 1 : 0;
            if(totalExpense >= 1)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // POST: TotalExpenses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TotalExpenseId,TotalExpenseLimit")] TotalExpense totalExpense)
        {
            if (ModelState.IsValid)
            {
                _context.Add(totalExpense);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(totalExpense);
        }

        // GET: TotalExpenses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TotalExpense == null)
            {
                return NotFound();
            }

            var totalExpense = await _context.TotalExpense.FindAsync(id);
            if (totalExpense == null)
            {
                return NotFound();
            }
            return View(totalExpense);
        }

        // POST: TotalExpenses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TotalExpenseId,TotalExpenseLimit")] TotalExpense totalExpense)
        {
            if (id != totalExpense.TotalExpenseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(totalExpense);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TotalExpenseExists(totalExpense.TotalExpenseId))
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
            return View(totalExpense);
        }

        // GET: TotalExpenses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TotalExpense == null)
            {
                return NotFound();
            }

            var totalExpense = await _context.TotalExpense
                .FirstOrDefaultAsync(m => m.TotalExpenseId == id);
            if (totalExpense == null)
            {
                return NotFound();
            }

            return View(totalExpense);
        }

        // POST: TotalExpenses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TotalExpense == null)
            {
                return Problem("Entity set 'AppDbContext.TotalExpense'  is null.");
            }
            var totalExpense = await _context.TotalExpense.FindAsync(id);
            if (totalExpense != null)
            {
                _context.TotalExpense.Remove(totalExpense);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TotalExpenseExists(int id)
        {
          return _context.TotalExpense.Any(e => e.TotalExpenseId == id);
        }
    }
}
