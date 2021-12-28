using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OTDStore.ApiIntegration;
using OTDStore.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTDStore.AdminApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderApiClient _orderApiClient;
        private readonly IConfiguration _configuration;
        public OrderController(IOrderApiClient orderApiClient, IConfiguration configuration)
        {
            _orderApiClient = orderApiClient;
            _configuration = configuration;
        }
        //public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        //{
        //    var request = new GetOrderPagingRequest()
        //    {
        //        Keyword = keyword,
        //        PageIndex = pageIndex,
        //        PageSize = pageSize
        //    };
        //    var data = await _orderApiClient.GetOrdersPagings(request);
        //    ViewBag.Keyword = keyword;
        //    if (TempData["result"] != null)
        //    {
        //        ViewBag.SuccessMsg = TempData["result"];
        //    }
        //    return View(data.ResultObj);
        //}
    }
}
