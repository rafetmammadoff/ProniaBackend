using System;
using System.Collections;
using System.Collections.Generic;

namespace Pronia.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }= DateTime.Now;
        public DateTime UpdatedTime { get; set; }= DateTime.Now;
        public string Barcode { get; set; }
        public int Rating { get; set; }
        public bool IsDeleted { get; set; }= false;
        public decimal SellPrice { get; set; }
        public decimal CostPrice { get; set; }
        public int CostCount { get; set; }
        public ICollection<ProductImages> ProductImages { get; set; }
        public ICollection<ProductColors> ProductColors { get; set; }
        public ICollection<ProductCategories> ProductCategories { get; set; }

    }
}
