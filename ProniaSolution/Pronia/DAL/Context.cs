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
    }
}
