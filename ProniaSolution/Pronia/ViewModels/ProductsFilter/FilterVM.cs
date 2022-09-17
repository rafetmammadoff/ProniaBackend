using Pronia.Models;
using System.Collections;
using System.Collections.Generic;

namespace Pronia.ViewModels.ProductsFilter
{
    public class FilterVM
    {
        public IEnumerable<Categories> Categories { get; set; }
        public IEnumerable<Color> Colors { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public int ProductCount { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
    }
}
