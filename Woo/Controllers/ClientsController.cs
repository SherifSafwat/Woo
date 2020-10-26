using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Woo.Data;
using Woo.Models;

namespace Woo.Controllers
{
    [AllowAnonymous]
    public class ClientsController : OuterController
    {
        public ClientsController(WooContext context) : base(context)
        {
        }

        //private readonly WooContext _context;

        //public ClientsController()
        //{
        //    //_context = context;
        //}

        //public ClientsController(WooContext context)
        //{
        //    //_context = context;
        //}

        // GET: Clients
        public ActionResult Index(int _sellerid)
        {
            //int _sellerid = Int32.Parse(Functions.GetData(HttpContext, _context, "sellerid"));

            ViewData["client"] = "client";
            ViewData["connectionid"] = _context.Login.Where(x1 => x1.SellerId == _sellerid).Select(x => x.ConnectionId).ToList();

            var list = _context.Warehouse.ToList();
            var Warelist = new List<Tuple<int, string>>();
            Warelist.Add(Tuple.Create(1, "Andy"));
            ViewData["Warelist"] = Warelist;

            return View();
        }

        // GET: Clients
        public ActionResult Monitor()
        {
            return View();
        }
        

        // GET: Clients
        //public ActionResult Action(string name)
        //{
        //    ViewData["client"] = "client";

        //    if (name == "order")
        //        return Redirect("Order");

        //    return View(nameof(Index));
        //}


        // GET: Clients/Details/5
        public async Task<IActionResult> Order(int? id)
        {
            //int sourceid = Int32.Parse(Functions.GetData(HttpContext, _context, "sellerid"));
            //ViewBag.customerlist = await _context.Customer.Where(x => x.SourceID == sourceid).ToListAsync();
            
            if(id != null)
                ViewBag.itemlist = await _context.Item.Where(x => x.SourceID == id ).ToListAsync();
            else
                ViewBag.itemlist = await _context.Item.ToListAsync();


            bool data = false;

            ViewData["client"] = "client";

            if (data)
                ViewBag.customer = true;
            else
                ViewBag.customer = false;

            ViewBag.customerlist = await _context.Customer.ToListAsync();
            //ViewBag.itemlist = await _context.Item.Where(x => x.Enabled == true).ToListAsync();
            

            return View();
        }

        public ActionResult SelectSeller()
        {

            return View(_context.Seller.ToList());    

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Select(int? id)
        {
            ViewBag.customer = false;
            ViewData["client"] = "client";

            //ViewBag.itemlist = _context.Item.Include(i => i.ItemPrices).Select(y => y.ItemPrices.).Where(x => x.Enabled == true && x.ItemPrices.se.SourceID == id).ToListAsync();
            ViewBag.itemlist = _context.Item.Where(x => x.Enabled == true && x.SourceID == id).ToListAsync();
            return Redirect ("Order");

        }
        // GET: Clients/Details/5
        public async Task<IActionResult> SellerOrder()
        {
            bool data = true;

            ViewData["client"] = "client";

            if (data)
                ViewBag.customer = true;
            else
                ViewBag.customer = false;

            //int sourceid = Int32.Parse(Functions.GetData(HttpContext, _context, "sellerid"));
            //ViewBag.customerlist = await _context.Customer.Where(x => x.SourceID == sourceid).ToListAsync();
            //ViewBag.itemlist = await _context.Item.Where(x => x.SourceID == sourceid && x.Enabled == true).ToListAsync();


            ViewBag.customerlist = await _context.Customer.ToListAsync();
            //ViewBag.itemlist = await _context.Item.Where(x => x.Enabled == true).ToListAsync();
            ViewBag.itemlist = await _context.Item.ToListAsync();

            return View();
        }
        

                
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult ItemInfo(int id)
        {
            //string str = "";
            ViewBag.data = Functions.GetItenInfo(_context, id);

            return Json(Functions.GetItenInfo(_context, id));
        }


        // POST: Invoices/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var OrderHeadObj = new OrderHead();

                    //invoiceh.InvoiceNum = Int16.Parse(collection["invoiceH.InvoiceNum"]);
                    //invoiceh.ID = 99;
                    OrderHeadObj.CustomerId = Int16.Parse(collection["OrderHeadObj.CustomerId"]);
                    OrderHeadObj.OrderTime = DateTime.Parse(collection["OrderHeadObj.OrderTime"]);
                    OrderHeadObj.Total = float.Parse(collection["OrderHeadObj.Total"]);
                    OrderHeadObj.TotalTax = float.Parse(collection["OrderHeadObj.TotalTax"]);
                    //invoiceh.TotalDisc = Int16.Parse(collection["invoiceH.TotalDisc"]);
                    //OrderHeadObj.CreatedId = Functions.GetData(HttpContext, _context, "userid");
                    //OrderHeadObj.SellerId = Int32.Parse(Functions.GetData(HttpContext, _context, "sellerid"));

                    _context.Add(OrderHeadObj);
                    int isSaved = await _context.SaveChangesAsync();


                    if (isSaved > 0)
                    {

                        /*List<string> itemid_l = collection["itemid"].ToList();
                        List<string> itemnum_l = collection["itemnum"].ToList();
                        List<string> name_l = collection["name"].ToList();
                        List<string> price_l = collection["price"].ToList();
                        List<string> qty_l = collection["qty"].ToList();
                        string uuu = collection["qty"][0];*/

                        for (int i = 0; i < collection["itemid"].Count()-1; i++)
                        {
                            var OrderTailObj = new OrderTail();

                            OrderTailObj.OrderHeadId = OrderHeadObj.OrderHeadId;
                            OrderTailObj.ItemId = Int16.Parse(collection["itemid"][i]);
                            OrderTailObj.ItemNum = Int16.Parse(collection["itemnum"][i]);
                            //List<string> name_l = collection["name"].ToList();
                            OrderTailObj.Price = float.Parse(collection["price"][i]);
                            OrderTailObj.Qty = float.Parse(collection["qty"][i]);
                            OrderTailObj.CreatedID = Functions.GetData(HttpContext, _context, "userid");
                            //OrderTailObj.SellerId = Int32.Parse(Functions.GetData(HttpContext, _context, "sellerid"));

                            _context.Add(OrderTailObj);

                        }

                        await _context.SaveChangesAsync();
                    }

                    SendNotify(OrderHeadObj.OrderHeadId);

                    return RedirectToAction("Index", new { str = OrderHeadObj.CustomerId });
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                string f = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: Clients/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            return View();
        }



        // GET: Clients/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clients/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clients/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult SendNotify(int id)
        {



            return Ok();
        }
    }
}