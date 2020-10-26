using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Woo.Data;
using Woo.Models;

namespace Woo.Controllers
{
    public class ReceivesController : GlobalController
    {
        private readonly WooContext _context;
        SignInManager<ApplicationUser> _signInManager;

        public ReceivesController(WooContext context, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
        }

        // GET: Receives
        public async Task<IActionResult> Index()
        {
            string str = HttpContext.Session.GetString("sellerid");

            if (str == null)
            {
                return RedirectToAction("Logout", "Account");
            }

            //return View(await _context.Price.Include(x => x.ItemObj).Where(x => x.SellerId == Int32.Parse(str)).ToListAsync());
            return View(await _context.Receive.Include(x1 => x1.ItemObj).Include(x2 => x2.WarehouseObj).Include(x3 => x3.UserObj).Where(x => x.SellerId == Int32.Parse(str)).ToListAsync());
        }

        // GET: Receives/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receive = await _context.Receive
                .FirstOrDefaultAsync(m => m.ReceiveId == id);
            if (receive == null)
            {
                return NotFound();
            }

            return View(receive);
        }

        // GET: Receives/Create
        public async Task<IActionResult> Create()
        {
            string str = HttpContext.Session.GetString("sellerid");

            if (str == null)
            {
                return RedirectToAction("Logout", "Account");
            }

            ViewBag.itemlist = await _context.Item.Where(x => x.SourceID == Int32.Parse(str) && x.Enabled == true).ToListAsync();
            ViewBag.wharehouselist = await _context.Warehouse.Where(x => x.SellerId == Int32.Parse(str)).ToListAsync();
            return View();
        }

        // POST: Receives/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReceiveId,ReceiptId,UserId,WarehouseId,ItemId,Qty,EnteringDate,ReceiptNum,DataComment,Info1,Info2,Info3,Info4,Info5,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] Receive receive)
        {
            if (!CreateData(receive))
            {
                return RedirectToAction("Logout", "Account");
            }

            if (ModelState.IsValid)
            {
                _context.Add(receive);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(receive);
        }

        // GET: Receives/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receive = await _context.Receive.FindAsync(id);
            if (receive == null)
            {
                return NotFound();
            }
            return View(receive);
        }

        // POST: Receives/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReceiveId,ReceiptId,UserId,WarehouseId,ItemId,Qty,EnteringDate,ReceiptNum,DataComment,Info1,Info2,Info3,Info4,Info5,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] Receive receive)
        {
            if (id != receive.ReceiveId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(receive);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReceiveExists(receive.ReceiveId))
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
            return View(receive);
        }

        // GET: Receives/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receive = await _context.Receive
                .FirstOrDefaultAsync(m => m.ReceiveId == id);
            if (receive == null)
            {
                return NotFound();
            }

            return View(receive);
        }

        // POST: Receives/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var receive = await _context.Receive.FindAsync(id);
            _context.Receive.Remove(receive);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReceiveExists(int id)
        {
            return _context.Receive.Any(e => e.ReceiveId == id);
        }

        public bool CreateData(Receive i)
        {

            string str = HttpContext.Session.GetString("userid");

            if (str != null)
            {
                i.CreatedId = str; // Functions.GetData(HttpContext, _context, "userid");
                i.SellerId = Int32.Parse(Functions.GetData(HttpContext, _context, "sellerid"));
                //i.WarehouseId = Functions.GetWareHouse(HttpContext, _context, i.UserId);
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
