using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Woo.Data;
using Woo.Models;

namespace Woo.Controllers
{
    [Authorize(Roles = "User")]
    public class PricesController : GlobalController
    {
        private readonly WooContext _context;

        public PricesController(WooContext context)
        {
            _context = context;
        }

        // GET: Prices
        public async Task<IActionResult> Index()
        {
            string str = HttpContext.Session.GetString("sellerid");

            if (str == null)
            {
                return RedirectToAction("Logout", "Account");
            }

            return View(await _context.Price.Include(x => x.ItemObj).Where(x => x.SellerId == Int32.Parse(str)).ToListAsync());
            //return View(await _context.Price.Include(x => x.ItemObj).ToListAsync());
        }

        // GET: Prices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prices = await _context.Price
                .FirstOrDefaultAsync(m => m.PriceId == id);
            if (prices == null)
            {
                return NotFound();
            }

            return View(prices);
        }

        // GET: Prices/Create
        public async Task<IActionResult> Create()
        {
            string str = HttpContext.Session.GetString("sellerid");

            if (str == null)
            {
                return RedirectToAction("Logout", "Account");
            }

            //return View(await _context.Price.Include(x => x.ItemObj).Where(x => x.SellerId == Int32.Parse(str)).ToListAsync());
            ViewBag.itemlist = await _context.Item.Where(x => x.SourceID == Int32.Parse(str)).ToListAsync();
            return View();
        }

        // POST: Prices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PriceId,PriceNum,ItemId,ItemPrice,SellerId,SourceId,Comment1,Comment2,Comment3,Comment4,Comment5,Enabled,GrantBy,GrantFromDate,GrantToDate,GrantComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] Price prices)
        {
            if (!CreateData(prices))
            {
                return RedirectToAction("Logout", "Account");
            }

            if (ModelState.IsValid)
            {
                _context.Add(prices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prices);
        }

        // GET: Prices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prices = await _context.Price.FindAsync(id);
            ViewBag.itemlist = await _context.Item.ToListAsync();
            if (prices == null)
            {
                return NotFound();
            }
            return View(prices);
        }

        // POST: Prices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PriceId,PriceNum,ItemId,ItemPrice,SellerId,SourceId,Comment1,Comment2,Comment3,Comment4,Comment5,Enabled,GrantBy,GrantFromDate,GrantToDate,GrantComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] Price prices)
        {
            if (id != prices.PriceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PricesExists(prices.PriceId))
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
            return View(prices);
        }

        // GET: Prices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prices = await _context.Price
                .FirstOrDefaultAsync(m => m.PriceId == id);
            if (prices == null)
            {
                return NotFound();
            }

            return View(prices);
        }

        // POST: Prices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prices = await _context.Price.FindAsync(id);
            _context.Price.Remove(prices);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PricesExists(int id)
        {
            return _context.Price.Any(e => e.PriceId == id);
        }

        public bool CreateData(Price i)
        {

            string str = HttpContext.Session.GetString("userid");

            if (str != null)
            {
                i.CreatedId = str; // Functions.GetData(HttpContext, _context, "userid");
                i.SellerId = Int32.Parse(Functions.GetData(HttpContext, _context, "sellerid"));
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
