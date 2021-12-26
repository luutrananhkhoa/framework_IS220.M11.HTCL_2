using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OTDStore.ApiIntegration;
using OTDStore.Utilities.Constants;
using OTDStore.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OTDStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        //private readonly ILogger<ProductController> _logger;
        //private readonly ISlideApiClient _slideApiClient;
        //private readonly IProductApiClient _productApiClient;

        //public ProductController(ILogger<ProductController> logger, ISlideApiClient slideApiClient,
        //    IProductApiClient productApiClient)
        //{
        //    _logger = logger;
        //    _slideApiClient = slideApiClient;
        //    _productApiClient = productApiClient;
        //}

        public IActionResult Detail(int id)
        {
            return View();
        }

        public IActionResult Category(int id)
        {
            return View();
        }


    }
}
