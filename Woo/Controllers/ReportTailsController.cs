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
    public class ReportTailsController : Controller
    {
        private readonly WooContext _context;

        public ReportTailsController(WooContext context)
        {
            _context = context;
        }

        // GET: ReportTails
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReportTail.ToListAsync());
        }

        // GET: ReportTails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportTail = await _context.ReportTail
                .FirstOrDefaultAsync(m => m.ReportTailId == id);
            if (reportTail == null)
            {
                return NotFound();
            }

            return View(reportTail);
        }

        // GET: ReportTails/Create
        //[HttpGet("{id}")]
        public IActionResult Create(int id)
        {
            ReportTail mod = new ReportTail() { ReportHeadId = id };
            return View(mod);
        }

        // POST: ReportTails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReportTailId,ReportHeadId,Header0,Header1,Header2,Header3,Header4,Header5,Header6,Header7,Header8,Header9,Header10,Header11,Header12,Header13,Header14,Header15,Header16,Header17,Header18,Header19,Info1,Info2,Info3,Info4,Info5,Enabled,GrantBy,GrantFromDate,GrantToDate,GrantComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] ReportTail reportTail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportTail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reportTail);
        }

        // GET: ReportTails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportTail = await _context.ReportTail.FindAsync(id);
            if (reportTail == null)
            {
                return NotFound();
            }
            return View(reportTail);
        }

        // POST: ReportTails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReportTailId,ReportHeadId,Header0,Header1,Header2,Header3,Header4,Header5,Header6,Header7,Header8,Header9,Header10,Header11,Header12,Header13,Header14,Header15,Header16,Header17,Header18,Header19,Info1,Info2,Info3,Info4,Info5,Enabled,GrantBy,GrantFromDate,GrantToDate,GrantComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] ReportTail reportTail)
        {
            if (id != reportTail.ReportTailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportTail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportTailExists(reportTail.ReportTailId))
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
            return View(reportTail);
        }

        // GET: ReportTails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportTail = await _context.ReportTail
                .FirstOrDefaultAsync(m => m.ReportTailId == id);
            if (reportTail == null)
            {
                return NotFound();
            }

            return View(reportTail);
        }

        // POST: ReportTails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reportTail = await _context.ReportTail.FindAsync(id);
            _context.ReportTail.Remove(reportTail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportTailExists(int id)
        {
            return _context.ReportTail.Any(e => e.ReportTailId == id);
        }
    }
}
