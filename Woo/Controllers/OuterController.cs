using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Woo.Data;

namespace Woo.Controllers
{
    public class OuterController : Controller
    {
        public WooContext _context;

        //public OuterController()
        //{
        //    //_context = context;
        //}

        public OuterController(WooContext context)
        {
            _context = context;
        }
    }
}