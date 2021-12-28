using System;
using System.Collections.Generic;
using System.Text;

namespace OTDStore.ViewModels.Sales
{
    public class OrderDetailVM
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
