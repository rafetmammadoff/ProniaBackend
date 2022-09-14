﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.DAL;
using Pronia.Models;
using System.Linq;

namespace Pronia.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly Context _context;

        public ProductController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int? id)
        {
            if (id is null)
            {
                return NotFound();
            }
            Product prod = _context.Products.Where(p => p.Id == id).Include(p => p.ProductImages).FirstOrDefault();
            return View(prod);
        }
    }
}