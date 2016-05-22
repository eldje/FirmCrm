using System.Collections.Generic;

namespace FirmCrm.Database.Models
{
    class Product
    {
        public int ProductId { get; set; }
        public List<Category> categories { get; set; }
        public int ProductStatus { get; set; } = 1;
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
        public Supplier Supplier { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public double TaxRate { get; set; } = 0.21;
        public int Stock { get; set; }
    }
}