using Microsoft.EntityFrameworkCore;
using Pronia.Models;

namespace Pronia.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions opt):base(opt)
        {

        }
        public DbSet<Slider>Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ProductColors> ProductColors { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }
    }
}
