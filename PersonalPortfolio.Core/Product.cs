using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalPortfolio.Core
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
