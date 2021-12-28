using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OTDStore.Application.System.Users;
using OTDStore.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTDStore.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CheckoutRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _orderService.Create(request);
            if (result == 0)
            {
                return BadRequest();
            }

            var order = await _orderService.CreateDetail(request, result);
            if (!order)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
