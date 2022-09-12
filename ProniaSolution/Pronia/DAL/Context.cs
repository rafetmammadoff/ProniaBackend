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
    }
}
