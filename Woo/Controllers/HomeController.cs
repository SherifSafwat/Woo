using System.Diagnostics;
using System.Globalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Woo.Models;
using Woo.Resources;

namespace Woo.Controllers
{
    public class HomeController : GlobalController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<SharedResources> _sharedLocalizer;
        ///private readonly IStringLocalizer _localizer1;
        //private readonly IStringLocalizer _localizer2;
        //private readonly IHtmlLocalizer _localizer2;

        const string language = "lang";
        bool login = false;


        public HomeController() //(IStringLocalizerFactory factory, IStringLocalizer<SharedResources> sharedLocalizer, IHtmlLocalizerFactory factory2)
        {
            //LoadData();

            //if (LoadData())
            //{
            //    RedirectToAction("Logout", "Account");
            //    return;
            //}
                

            //_logger = logger;
            //_sharedLocalizer = sharedLocalizer;

            //var type = typeof(SharedResources);
            //var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            //_localizer1 = factory.Create(type);
            //_localizer2 = factory.Create("SharedResources", assemblyName.Name);
            //_localizer2 = factory2.Create("SharedResources", assemblyName.Name);


        }

        public IActionResult Index()
        {

           // if (LoadData())
           // {
           //     return RedirectToAction("Logout", "Account");
                
           // }
           //if (!login)
           //     return RedirectToAction("Logout", "Account");
                

            ///ViewBag.toto1 = _sharedLocalizer["head"];
            //ViewBag.toto2 = _localizer1["head"] ;
            //ViewBag.toto3 = _localizer2["head"];

            //string h2 = _sharedLocalizer.GetString("head");
            //string h22 = _localizer1.GetString("head");
            //string h1 = _localizer2.GetString("head");
            //List<LocalizedString> hh2 = _sharedLocalizer.GetAllStrings().ToList();
            //List<LocalizedString> hh11 = _localizer1.GetAllStrings().ToList();
            //List<LocalizedString> hh22 = _localizer2.GetAllStrings().ToList();

            //ViewData["toto"] = _sharedLocalizer["head"];// + _localizer1["head"];// + _localizer2["head"];


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public bool LoadData()
        {
            try
            { 
                System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(HttpContext.Session.GetString("lang"));
                login = true;
                return false;
            }
            catch
            {
                login = false;
                return true;
            }

            return false;

        }




    }
}
