using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pronia.DAL;
using Pronia.Models;
using Pronia.ViewModels.Home;
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
            HomeVM vm = new HomeVM();
            vm.Sliders = _context.Sliders.OrderBy(x=>x.Order);
            vm.Services = _context.Services.Where(x => x.IsActive);
            vm.Featured = _context.Products.Take(8).Include(p => p.ProductImages);
            vm.BestSeller=_context.Products.OrderByDescending(x=>x.CostCount).Take(8).Include(p => p.ProductImages);
            vm.Lastest=_context.Products.OrderByDescending(x=>x.CreatedTime).Take(8).Include(p => p.ProductImages);
            vm.NewProduct=_context.Products.OrderByDescending(x=>x.CreatedTime).Take(4).Include(p => p.ProductImages);
            vm.Sponsors = _context.Sponsors;
            return View(vm);
        }

    }
}
