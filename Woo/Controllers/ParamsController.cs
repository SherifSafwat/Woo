using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Woo.Data;
using Woo.Models;

namespace Woo.Controllers
{
    [Authorize(Roles = "Admin,User")]
    public class ParamsController : Controller
    {
        private readonly WooContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ParamsController(WooContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Params
        public async Task<IActionResult> Index()
        {
            return View(await _context.Param.ToListAsync());
        }


        

        // GET: Params/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @param = await _context.Param
                .FirstOrDefaultAsync(m => m.ParamId == id);
            if (@param == null)
            {
                return NotFound();
            }

            return View(@param);
        }

        // GET: Params/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Params/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ParamId,UserId,Param1,Param2,Param3,Param4,Param5,Param6,Param7,Param8,Param9,Param10,Param11,Param12,Param13,Param14,Param15")] Param @param)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@param);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@param);
        }

        // GET: Params/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (user == null)
            {
                return NotFound();
            }

            //var @param = await _context.Param.FindAsync(id);
            var @param = await _context.Param.Where(x => x.ParamId == user.ParamId).FirstAsync();

            ViewBag.Langs = new List<SelectListItem>
            {
                new SelectListItem {Text = "English", Value = "En"},
                new SelectListItem {Text = "Arabic", Value = "Ar"}
            };

            
            if (@param == null)
            {
                //return new NotFoundViewResult("ProductNotFound");
                return NotFound();
            }
            return View(@param);
        }

        // POST: Params/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ParamId,Param1,Param2,Param3,Param4,Param5,Param6,Param7,Param8,Param9,Param10,Param11,Param12,Param13,Param14,Param15")] Param @param)
        {
            //if (id != @param.ParamId)
            //{
            //    return NotFound();
            //}

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@param);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParamExists(@param.ParamId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                HttpContext.Session.SetString("lang", param.Param1);

                return RedirectToAction("index", "home");
            }
            return View(@param);
        }

        // GET: Params/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @param = await _context.Param
                .FirstOrDefaultAsync(m => m.ParamId == id);
            if (@param == null)
            {
                return NotFound();
            }

            return View(@param);
        }

        // POST: Params/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @param = await _context.Param.FindAsync(id);
            _context.Param.Remove(@param);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParamExists(int id)
        {
            return _context.Param.Any(e => e.ParamId == id);
        }


    }
}
