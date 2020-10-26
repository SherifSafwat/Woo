using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Woo.Data;
using Woo.Resources;

namespace Woo.Controllers
{
    public class GlobalController : Controller
    {
        private readonly WooContext _context;
        private readonly HttpContext _httpcontext;

        public GlobalController()
        {
            //string ss = HttpContext.Session.GetString("lang");
        }


        public GlobalController(WooContext context)
        {
            //string ss = HttpContext.Session.GetString("lang");
        }

        public GlobalController(ILogger<HomeController> logger, IStringLocalizerFactory factory, IStringLocalizer<SharedResources> sharedLocalizer, IHtmlLocalizerFactory factory2)
        //public GlobalController(HttpContext httpcontext, WooContext context)
        {
            //_context = context;
            //_httpcontext = httpcontext;

            //string ss = HttpContext.Session.GetString("lang");
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string str = HttpContext.Session.GetString("lang");
            if(str == null)
            {
                filterContext.Result = new RedirectToActionResult("Logout", "Account", null); // RedirectResult("url"); // RedirectToAction("Logout", "Account");
            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(str);
            }

            return;
        }


        [HttpPost]
        public ActionResult GetData(Controller  con, HttpContext hhcon, string p_key)
        {
            

            string ret = "";

            try
            {

                if (p_key == "userid")
                {
                    ret = _httpcontext.Session.GetString("userid");

                    if (ret == null)
                    {
                        _httpcontext.SignOutAsync();
                        _httpcontext.Response.StatusCode = 302;

                        con.HttpContext.Abort();
                        con.RedirectPermanent("https://www.c-sharpcorner.com");
                        con.LocalRedirectPermanent("Account");


                        return con.RedirectPermanent("https://www.c-sharpcorner.com");
                        return con.RedirectPermanent("Account\\Logout");
                        _httpcontext.Response.Redirect("Account\\Logout");
                        con.RedirectToAction("Logout", "Account");

                        throw new Exception();

                        return Content(ret);
                    }
                    else
                    {
                        return Content(ret);
                    }
                }

            } catch(Exception e)
            {

                _httpcontext.Response.Redirect("Account\\Logout");
                con.RedirectToAction("Logout", "Account");

                return Content(ret);

            }




            string str = Functions.GetData(HttpContext, _context, "userid");
            if (str != null)
                //item.CreatedID = str;
            
                



            if (p_key == "sellerid")
            {
                ret = hhcon.Session.GetString("sellerid");
            }

            return Json(ret);
        }

        // GET: Global
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: Global/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Global/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Global/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Global/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Global/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Global/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Global/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}