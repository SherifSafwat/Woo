using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Woo.Data;
using Woo.Models;

namespace Woo.Controllers
{
    public class InvoiceTsController : Controller
    {
        private readonly WooContext _context;

        public InvoiceTsController(WooContext context)
        {
            _context = context;
        }

        // GET: InvoiceTs
        public async Task<IActionResult> Index()
        {
            ViewBag.itemlist = await _context.Item.ToListAsync();

            return View("Invoices\\TheInvoice_01_01");

            //return View(await _context.InvoiceT.ToListAsync());
        }

        [HttpPost]
        public object ItemInfo(int id)
        {
            //string str = "";



            return Functions.GetItenInfo(_context, id);
        }

        // POST: InvoiceTs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(IFormCollection collection)
        {
            if (ModelState.IsValid)
            {
                
                //_context.Add(invoiceT);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View();
        }

        [HttpPost]
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        // GET: InvoiceTs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoiceT = await _context.InvoiceT
                .FirstOrDefaultAsync(m => m.ID == id);
            if (invoiceT == null)
            {
                return NotFound();
            }

            return View(invoiceT);
        }

        // GET: InvoiceTs/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.itemlist = await _context.Item.ToListAsync();
            return View();
        }

        // POST: InvoiceTs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,InvoiceId,LineId,ItemId,PriceId,Price,Qty,LineDisc,TotalLine,DataComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] InvoiceT invoiceT)
        {
            if (ModelState.IsValid)
            {
                _context.Add(invoiceT);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(invoiceT);
        }

        // GET: InvoiceTs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoiceT = await _context.InvoiceT.FindAsync(id);
            if (invoiceT == null)
            {
                return NotFound();
            }
            return View(invoiceT);
        }

        // POST: InvoiceTs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,InvoiceId,LineId,ItemId,PriceId,Price,Qty,LineDisc,TotalLine,DataComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] InvoiceT invoiceT)
        {
            if (id != invoiceT.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invoiceT);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvoiceTExists(invoiceT.ID))
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
            return View(invoiceT);
        }

        // GET: InvoiceTs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoiceT = await _context.InvoiceT
                .FirstOrDefaultAsync(m => m.ID == id);
            if (invoiceT == null)
            {
                return NotFound();
            }

            return View(invoiceT);
        }

        // POST: InvoiceTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invoiceT = await _context.InvoiceT.FindAsync(id);
            _context.InvoiceT.Remove(invoiceT);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvoiceTExists(int id)
        {
            return _context.InvoiceT.Any(e => e.ID == id);
        }
    }
}
