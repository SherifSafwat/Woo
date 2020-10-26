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
    public class UserRespsController : Controller
    {
        private readonly WooContext _context;

        public UserRespsController(WooContext context)
        {
            _context = context;
        }

        // GET: UserResps
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserResp.ToListAsync());
        }

        // GET: UserResps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userResp = await _context.UserResp
                .FirstOrDefaultAsync(m => m.ID == id);
            if (userResp == null)
            {
                return NotFound();
            }

            return View(userResp);
        }

        // GET: UserResps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserResps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserRespNum,UserId,RespId,DataComment,Enabled,GrantBy,GrantFromDate,GrantToDate,GrantComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] UserResp userResp)
        {
            ModelState.Remove("GrantToDate");

            if (ModelState.IsValid)
            {

                

                _context.Add(userResp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userResp);
        }

        // GET: UserResps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userResp = await _context.UserResp.FindAsync(id);
            if (userResp == null)
            {
                return NotFound();
            }
            return View(userResp);
        }

        // POST: UserResps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserRespNum,UserId,RespId,DataComment,Enabled,GrantBy,GrantFromDate,GrantToDate,GrantComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] UserResp userResp)
        {
            if (id != userResp.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userResp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserRespExists(userResp.ID))
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
            return View(userResp);
        }

        // GET: UserResps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userResp = await _context.UserResp
                .FirstOrDefaultAsync(m => m.ID == id);
            if (userResp == null)
            {
                return NotFound();
            }

            return View(userResp);
        }

        // POST: UserResps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userResp = await _context.UserResp.FindAsync(id);
            _context.UserResp.Remove(userResp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserRespExists(int id)
        {
            return _context.UserResp.Any(e => e.ID == id);
        }
    }
}
