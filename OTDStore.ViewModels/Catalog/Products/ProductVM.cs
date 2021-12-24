using System;
using System.Collections.Generic;

namespace OTDStore.ViewModels.Catalog.Products
{
    public class ProductVM
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string YearRelease { set; get; }
        public string Color { set; get; }
        public string Memory { set; get; }
        public string RAM { set; get; }
        public string Camera { set; get; }
        public string Bluetooth { get; set; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public List<string> Categories { get; set; } = new List<string>();
    }
}