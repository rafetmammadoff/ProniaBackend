using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pronia.DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Sliders.ToList());
        }

    }
}
