using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using Woo.Data;
using Woo.Models;

namespace Woo.Controllers
{
    [Authorize(Roles = "User")]
    public class InvoicesController : Controller
    {
        private readonly WooContext _context;


        public InvoicesController(WooContext context)
        {
            _context = context;
        }


        // GET: Invoices
        public ActionResult List()
        {

            return View();
        }

        // GET: Invoices
        public async Task<IActionResult> Index(bool data)
        {
            if (data)
                ViewBag.customer = true;
            else
                ViewBag.customer = false;

            int sourceid = Int32.Parse(Functions.GetData(HttpContext,_context,"sellerid"));

            ViewBag.customerlist = await _context.Customer.Where(x => x.SourceID == sourceid ).ToListAsync();
            ViewBag.itemlist = await _context.Item.Where(x => x.SourceID == sourceid && x.Enabled == true ).ToListAsync();

            return View();
        }

        [HttpPost]
        public ActionResult Index(IFormCollection collection)
        {
            return RedirectToAction("Home/Index");
            //return View("TheInvoice_01_01");
        }

        [HttpPost]
        public ActionResult ItemInfo(int id)
        {
            //string str = "";
            ViewBag.data = Functions.GetItenInfo(_context, id);

            return Json(Functions.GetItenInfo(_context, id));
        }

        [HttpGet]
        public IActionResult Create(string Total, IFormCollection collection)
        {
            //IFormCollection collection = (IFormCollection)o;

            string  i = Request.Form["Total"];

            int u=0;
            return RedirectToAction(nameof(List)); 
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
                    var invoiceh = new InvoiceH();

                    //invoiceh.InvoiceNum = Int16.Parse(collection["invoiceH.InvoiceNum"]);
                    //invoiceh.ID = 99;
                    invoiceh.CustomerId = Int16.Parse(collection["invoiceH.CustomerId"]);
                    invoiceh.InvoiceTime = DateTime.Parse(collection["invoiceH.InvoiceTime"]);
                    invoiceh.Total = float.Parse(collection["invoiceH.Total"]);
                    invoiceh.TotalTax = float.Parse(collection["invoiceH.TotalTax"]);
                    //invoiceh.TotalDisc = Int16.Parse(collection["invoiceH.TotalDisc"]);
                    invoiceh.CreatedId = Functions.GetData(HttpContext, _context, "userid");
                    invoiceh.SellerId = Int32.Parse(Functions.GetData(HttpContext, _context, "sellerid"));

                    _context.Add(invoiceh);
                    int isSaved = await _context.SaveChangesAsync();


                    if (isSaved > 0)
                    {

                        /*List<string> itemid_l = collection["itemid"].ToList();
                        List<string> itemnum_l = collection["itemnum"].ToList();
                        List<string> name_l = collection["name"].ToList();
                        List<string> price_l = collection["price"].ToList();
                        List<string> qty_l = collection["qty"].ToList();
                        string uuu = collection["qty"][0];*/

                        for (int i = 0; i < collection["itemid"].Count(); i++)
                        {
                            var invoicet = new InvoiceT();

                            invoicet.InvoiceId = invoiceh.ID;
                            invoicet.ItemId = Int16.Parse(collection["itemid"][i]);
                            invoicet.ItemNum = Int16.Parse(collection["itemnum"][i]);
                            //List<string> name_l = collection["name"].ToList();
                            invoicet.Price = float.Parse(collection["price"][i]);
                            invoicet.Qty = float.Parse(collection["qty"][i]);
                            invoicet.CreatedID = Functions.GetData(HttpContext, _context, "userid");
                            invoicet.SellerId = Int32.Parse(Functions.GetData(HttpContext, _context, "sellerid"));

                            _context.Add(invoicet);

                        }

                        await _context.SaveChangesAsync();
                    }


                    return RedirectToAction(nameof(List));
                }

                return RedirectToAction(nameof(List));
            }
            catch (Exception ex)
            {
                string f = ex.Message;
                return RedirectToAction(nameof(List));
            }
        }

        // GET: Invoices/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Invoices/Edit/5
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

        // GET: Invoices/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Invoices/Delete/5
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
    }
}