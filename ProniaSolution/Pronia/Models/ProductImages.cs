namespace Pronia.Models
{
    public class ProductImages
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public bool? Status { get; set; }
        public int ProductId { get; set; }
        Product product = new Product();
    }
}
