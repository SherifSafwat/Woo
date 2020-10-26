using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Woo.Data;
using Woo.Models;

namespace Woo.Controllers
{
    public class InvoiceHsController : Controller
    {
        private readonly WooContext _context;

        public InvoiceHsController(WooContext context)
        {
            _context = context;
        }

        // GET: InvoiceHs
        public async Task<IActionResult> Index()
        {
            return View(await _context.InvoiceH.ToListAsync());
        }

        // GET: InvoiceHs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoiceH = await _context.InvoiceH
                .FirstOrDefaultAsync(m => m.ID == id);
            if (invoiceH == null)
            {
                return NotFound();
            }

            return View(invoiceH);
        }

        // GET: InvoiceHs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InvoiceHs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,InvoiceNum,UserId,DeviceId,CustomerId,InvoiceTime,Total,TotalTax,TotalDisc,DataComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] InvoiceH invoiceH)
        {
            if (ModelState.IsValid)
            {
                _context.Add(invoiceH);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(invoiceH);
        }

        // GET: InvoiceHs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoiceH = await _context.InvoiceH.FindAsync(id);
            if (invoiceH == null)
            {
                return NotFound();
            }
            return View(invoiceH);
        }

        // POST: InvoiceHs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,InvoiceNum,UserId,DeviceId,CustomerId,InvoiceTime,Total,TotalTax,TotalDisc,DataComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] InvoiceH invoiceH)
        {
            if (id != invoiceH.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invoiceH);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvoiceHExists(invoiceH.ID))
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
            return View(invoiceH);
        }

        // GET: InvoiceHs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoiceH = await _context.InvoiceH
                .FirstOrDefaultAsync(m => m.ID == id);
            if (invoiceH == null)
            {
                return NotFound();
            }

            return View(invoiceH);
        }

        // POST: InvoiceHs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invoiceH = await _context.InvoiceH.FindAsync(id);
            _context.InvoiceH.Remove(invoiceH);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvoiceHExists(int id)
        {
            return _context.InvoiceH.Any(e => e.ID == id);
        }

    }
}
