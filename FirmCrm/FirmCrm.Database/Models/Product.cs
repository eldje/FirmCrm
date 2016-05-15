using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmCrm.Database.Models
{
    class Product
    {
        public int ProductId { get; set; }
        public int CatId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
        public Supplier Supplier { get; set; }
        public decimal Price { get; set; }
        public double TaxRate { get; set; } = 0.21;
        public int Stock { get; set; }
    }
}
