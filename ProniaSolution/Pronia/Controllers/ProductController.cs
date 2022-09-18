using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.DAL;
using Pronia.Models;
using Pronia.ViewModels.ProductsFilter;
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
            var products = _context.Products.Include(p => p.ProductImages).Include(p => p.ProductColors).ThenInclude(pc => pc.Color).AsQueryable();
            int count = products.Count();
            FilterVM filterVM = new FilterVM();
            filterVM.Categories = _context.Categories.Include(c => c.ProductCategories).ToList();
            filterVM.Colors = _context.Colors.Include(c => c.ProductColors).ToList();
            filterVM.ProductCount = count;
            filterVM.Products = products;
            return View(filterVM);
        }
        public IActionResult Detail(int? id)
        {
            if (id is null)
            {
                return NotFound();
            }
            Product prod = _context.Products.Where(p => p.Id == id).Include(p => p.ProductImages).Include(p=>p.ProductColors).ThenInclude(p=>p.Color).FirstOrDefault();
            return View(prod);
        }
        public IActionResult GetDataById(int? id)
        {
            if (id is null)
            {
                return NotFound();
            }
            Product product = _context.Products.Include(p=>p.ProductImages).Include(p=>p.ProductColors).ThenInclude(pc=>pc.Color).Where(p => p.Id == id).FirstOrDefault();
            if (product is null)
            {
                return NotFound();
            }
            return PartialView("_ProductQuickPartialView", product);
        }

        [HttpPost]
        public IActionResult ProductFilter(PriceFilterVm priceFilter)
        {
            if (priceFilter.MinPrice == null) priceFilter.MinPrice = 0;
            if (priceFilter.MaxPrice == null) priceFilter.MaxPrice = int.MaxValue;
            var products = _context.Products.Include(p => p.ProductImages)
                .Where(p => p.SellPrice > priceFilter.MinPrice && p.SellPrice < priceFilter.MaxPrice)
                .Include(p => p.ProductColors).ThenInclude(pc => pc.Color).ToList();
            return PartialView("_ProductFilterPartialView", products);
        }

        public IActionResult FilteredProduct(int? categoryId, int? colorId )
        {
            var products = _context.Products.Include(p => p.ProductImages).Include(p => p.ProductColors).ThenInclude(pc => pc.Color).AsQueryable();

            if (categoryId != null)
            {
                products = products.Where(p => p.ProductCategories.Any(pc => pc.CategoriesId == categoryId));
            }
            if (colorId != null)
            {
                products = products.Where(p => p.ProductColors.Any(pc => pc.ColorId == colorId));
            }
            
            return PartialView("FilterPartialView", products);
        }
    }
}
