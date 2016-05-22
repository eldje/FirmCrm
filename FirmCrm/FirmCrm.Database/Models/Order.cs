using System.Collections.Generic;

namespace FirmCrm.Database.Models
{
    class Order
    {
        public Order(Customer customer)
        {
            this.Customer = customer;
            List<OrderRule> orderRules = new List<OrderRule>();
        }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public decimal TotalPriceExTax { get; set; }
        public decimal TotalPriceIncTax { get; set; }
    }
}
