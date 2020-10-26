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
    public class ItemsController : GlobalController
    {
        private readonly WooContext _context;

        public ItemsController(WooContext context)
        {
            _context = context;

            //HttpContext.Session.GetString("lang");
        }

        // GET: Items
        public async Task<IActionResult> Index()
        {
            string str = HttpContext.Session.GetString("sellerid");

            if (str == null)
            {
                return RedirectToAction("Logout", "Account");
            }

            return View(await _context.Item.Where(x => x.SourceID == Int32.Parse(str)).ToListAsync());
        }

        // GET: Items/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: Items/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemId,EName,AName,Desc,SourceID,CreationDate,CreatedID,UpdatingDate,UpdatedID,Comment")] Item item)
        {

            if (! CreateData(item))
            {
                return RedirectToAction("Logout", "Account");
            }

            if (ModelState.IsValid == false)
            {
                return View(item);
            }
          
            _context.Add(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        // GET: Items/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemId,EName,AName,Desc,SourceID,CreationDate,CreatedID,UpdatingDate,UpdatedID,Comment")] Item item)
        {
            if (id != item.ItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.ItemId))
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
            return View(item);
        }

        // GET: Items/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Item.FindAsync(id);
            _context.Item.Remove(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemExists(int id)
        {
            return _context.Item.Any(e => e.ItemId == id);
        }

        public bool CreateData(Item i)
        {

            string str = HttpContext.Session.GetString("userid");

            if (str != null)
            {
                i.CreatedID = str; // Functions.GetData(HttpContext, _context, "userid");
                i.SourceID = Int32.Parse(Functions.GetData(HttpContext, _context, "sellerid"));
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
