﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmCrm.Database.Models
{
    class OrderRule
    {
        public OrderRule(Product product, int amount)
        {
            this.Product = product;
            this.Amount = amount;
        }
        public int OrderRuleId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
