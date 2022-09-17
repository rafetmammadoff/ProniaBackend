namespace Pronia.Models
{
    public class ProductCategories
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CategoriesId { get; set; }
        public Product Product { get; set; }
        public Categories Categories { get; set; }
    }
}
