using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pronia.DAL;
using Pronia.Models;
using Pronia.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pronia.Controllers
{
    public class ViewCartController : Controller
    {
        private readonly Context _context;

        public ViewCartController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            string a= HttpContext.Request.Cookies["basket"];
            List<BasketItem> b= JsonConvert.DeserializeObject<List<BasketItem>>(a);
            List<int> ids= new List<int>();
            foreach (var item in b)
            {
                ids.Add(item.ProductId);
            }
            

            List<Product> products1=_context.Products.Include(p=>p.ProductImages).ToList();
            List<Product> products= new List<Product>();

            foreach (var item in ids)
            {
                Product product = products1.Find(p => p.Id == item);
                if (product != null)
                {
                    products.Add(product);
                }
            }

            return View(products);
        }
    }
}
