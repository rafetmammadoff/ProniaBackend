using System.Collections.Generic;

namespace Pronia.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public ICollection<ProductCategories> ProductCategories { get; set; }
    }
}
