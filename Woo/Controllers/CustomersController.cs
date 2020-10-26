using System;
using System.Collections.Generic;
using System.Globalization;
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
    public class CustomersController : GlobalController
    {
        private readonly WooContext _context;

        public CustomersController(WooContext context)
        {
            _context = context;

            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            string str = HttpContext.Session.GetString("sellerid");

            if (str == null)
            {
                return RedirectToAction("Logout", "Account");
            }

            //return View(await _context.Price.Include(x => x.ItemObj).Where(x => x.SellerId == Int32.Parse(str)).ToListAsync());
            return View(await _context.Customer.Where(x => x.SourceID == Int32.Parse(str)).ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,CustomerNum,EName,AName,DataComment,Address1,Address2,Address3,Address4,Address5,Contact1,Contact2,Contact3,Contact4,Contact5,Comment1,Comment2,Comment3,Comment4,Comment5,SourceID,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] Customer customer)
        {

            if (!CreateData(customer))
            {
                return RedirectToAction("Logout", "Account");
            }

            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,CustomerNum,EName,AName,DataComment,Address1,Address2,Address3,Address4,Address5,Contact1,Contact2,Contact3,Contact4,Contact5,Comment1,Comment2,Comment3,Comment4,Comment5,SourceID,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
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
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.CustomerId == id);
        }

        public bool CreateData(Customer i)
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
