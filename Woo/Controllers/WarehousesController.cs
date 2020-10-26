using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Woo.Data;
using Woo.Models;

namespace Woo.Controllers
{
    public class WarehousesController : Controller
    {
        private readonly WooContext _context;

        public WarehousesController(WooContext context)
        {
            _context = context;
        }

        // GET: Warehouses
        public async Task<IActionResult> Index(int? id)
        {
            if(id == null)
            {
                return View(await _context.Warehouse.Include(x => x.SellerObj).ToListAsync());
            }
            else
            {
                string str = HttpContext.Session.GetString("sellerid");
                return View(await _context.Warehouse.Include(x => x.SellerObj).Where(x => x.SellerId == Int32.Parse(str)).ToListAsync());
            }

            
        }

        public async Task<IActionResult> SetLoction(int? id)
        {

            //string str = HttpContext.Session.GetString("userid");
            //int WarehouseId = Functions.GetWareHouse(HttpContext, _context, str);

            var warehouse = await _context.Warehouse.FindAsync(id);

            if (warehouse == null)
            {
                return NotFound();
            }
            return View(warehouse);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SetLoction(int id, [Bind("WareHouseId,Longitude,Latitude,WarehouseNum,EName,AName,DataComment,SellerId,Info1,Info2,Info3,Info4,Info5,SourceId,Enabled,GrantBy,GrantFromDate,GrantToDate,GrantComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] Warehouse warehouse)
        {
            if (id != warehouse.WareHouseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var warehouse1 = await _context.Warehouse.FindAsync(id);
                    warehouse1.Latitude = warehouse.Latitude;
                    warehouse1.Longitude = warehouse.Longitude;

                    _context.Update(warehouse1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarehouseExists(warehouse.WareHouseId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("index", "home");
            }
            return View(warehouse);
        }

        // GET: Warehouses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouse = await _context.Warehouse
                .FirstOrDefaultAsync(m => m.WareHouseId == id);
            if (warehouse == null)
            {
                return NotFound();
            }

            return View(warehouse);
        }

        // GET: Warehouses/Create
        public IActionResult Create()
        {                           
            ViewBag.sellerlist =  _context.Seller.ToList();
            return View();
        }

        // POST: Warehouses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WareHouseId,WarehouseNum,EName,AName,DataComment,SellerId,Info1,Info2,Info3,Info4,Info5,SourceId,BranchId,Enabled,GrantBy,GrantFromDate,GrantToDate,GrantComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] Warehouse warehouse)
        {
            if (!CreateData(warehouse))
            {
                return RedirectToAction("Logout", "Account");
            }

            if (ModelState.IsValid)
            {
                _context.Add(warehouse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(warehouse);
        }

        // GET: Warehouses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouse = await _context.Warehouse.FindAsync(id);
            ViewBag.sellerlist = _context.Seller.ToList();
            if (warehouse == null)
            {
                return NotFound();
            }
            return View(warehouse);
        }

        // POST: Warehouses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WareHouseId,WarehouseNum,EName,AName,DataComment,SellerId,Info1,Info2,Info3,Info4,Info5,SourceId,Enabled,GrantBy,GrantFromDate,GrantToDate,GrantComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] Warehouse warehouse)
        {
            if (id != warehouse.WareHouseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warehouse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarehouseExists(warehouse.WareHouseId))
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
            return View(warehouse);
        }

        // GET: Warehouses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouse = await _context.Warehouse
                .FirstOrDefaultAsync(m => m.WareHouseId == id);
            if (warehouse == null)
            {
                return NotFound();
            }

            return View(warehouse);
        }

        // POST: Warehouses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var warehouse = await _context.Warehouse.FindAsync(id);
            _context.Warehouse.Remove(warehouse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarehouseExists(int id)
        {
            return _context.Warehouse.Any(e => e.WareHouseId == id);
        }

        public bool CreateData(Warehouse i)
        {

            string str = HttpContext.Session.GetString("userid");

            if (str != null)
            {
                i.CreatedID = str; // Functions.GetData(HttpContext, _context, "userid");
                //i.SellerId = Int32.Parse(Functions.GetData(HttpContext, _context, "sellerid"));
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
