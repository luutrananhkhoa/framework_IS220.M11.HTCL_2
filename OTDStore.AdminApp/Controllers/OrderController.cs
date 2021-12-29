using Microsoft.AspNetCore.Mvc;
using OTDStore.ViewModels.Sales;
using Microsoft.Extensions.Configuration;
using OTDStore.ApiIntegration;
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

        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetOrderPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _orderApiClient.GetOrdersPagings(request);
            ViewBag.Keyword = keyword;
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data.ResultObj);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var result = await _orderApiClient.GetById(id);
            return View(result.ResultObj);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            var result = await _orderApiClient.GetById(id);
            if (result.IsSuccessed)
            {
                var user = result.ResultObj;
                var updateRequest = new StatusUpdateRequest()
                {
                    Status = user.Status,
                    Id = id
                };
                return View(updateRequest);
            }
            return RedirectToAction("Error", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(StatusUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _orderApiClient.UpdateOrder(request.Id, request);
            if (result.IsSuccessed)
            {
                TempData["result"] = "Cập nhật hóa đơn thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);
            return View(request);
        }
    }
}
