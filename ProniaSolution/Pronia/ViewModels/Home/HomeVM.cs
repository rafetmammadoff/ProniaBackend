using Pronia.Models;
using System.Collections;
using System.Collections.Generic;

namespace Pronia.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Product> Featured { get; set; }
        public IEnumerable<Product> BestSeller { get; set; }
        public IEnumerable<Product> Lastest { get; set; }
        public IEnumerable<Product> NewProduct { get; set; }
        public IEnumerable<Sponsor> Sponsors { get; set; }
    }
}
