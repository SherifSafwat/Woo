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
    public class RespsController : Controller
    {
        private readonly WooContext _context;

        public RespsController(WooContext context)
        {
            _context = context;
        }

        // GET: Resps
        public async Task<IActionResult> Index()
        {
            return View(await _context.Resp.ToListAsync());
        }

        // GET: Resps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resp = await _context.Resp
                .FirstOrDefaultAsync(m => m.ID == id);
            if (resp == null)
            {
                return NotFound();
            }

            return View(resp);
        }

        // GET: Resps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Resps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,RespNum,EName,AName,DataComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] Resp resp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(resp);
        }

        // GET: Resps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resp = await _context.Resp.FindAsync(id);
            if (resp == null)
            {
                return NotFound();
            }
            return View(resp);
        }

        // POST: Resps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,RespNum,EName,AName,DataComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] Resp resp)
        {
            if (id != resp.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RespExists(resp.ID))
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
            return View(resp);
        }

        // GET: Resps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resp = await _context.Resp
                .FirstOrDefaultAsync(m => m.ID == id);
            if (resp == null)
            {
                return NotFound();
            }

            return View(resp);
        }

        // POST: Resps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resp = await _context.Resp.FindAsync(id);
            _context.Resp.Remove(resp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RespExists(int id)
        {
            return _context.Resp.Any(e => e.ID == id);
        }
    }
}
