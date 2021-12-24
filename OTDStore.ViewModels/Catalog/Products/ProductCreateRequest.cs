using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace OTDStore.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        public string Name { set; get; }
        public string Description { set; get; }
        public string YearRelease { set; get; }
        public string Color { set; get; }
        public string Memory { set; get; }
        public string RAM { set; get; }
        public string Camera { set; get; }
        public string Bluetooth { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public IFormFile ThumbnailImage { set; get; }
    }
}
