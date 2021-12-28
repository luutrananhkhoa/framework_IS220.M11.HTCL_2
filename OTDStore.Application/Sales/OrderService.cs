using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OTDStore.Data.EF;
using OTDStore.Data.Entities;
using OTDStore.Data.Enum;
using OTDStore.ViewModels.Common;
using OTDStore.ViewModels.Sales;
using OTDStore.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OTDStore.Application.System.Users
{
    public class OrderService : IOrderService
    {
        private readonly OTDDbContext _context;
        private readonly IConfiguration _config;
        public OrderService(IConfiguration config, OTDDbContext context)
        {
            _context = context;
            _config = config;
        }

        //public async Task<ApiResult<PagedResult<OrderVM>>> GetOrderPaging(GetUserPagingRequest request)
        //{
        //    var query = from o in _context.Orders
        //                join od in _context.OrderDetails on o.Id equals od.OrderId into ood
        //                from od in ood.DefaultIfEmpty()
        //                select new { o, od };

        //    int totalRow = await query.CountAsync();

        //    var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
        //        .Take(request.PageSize)
        //        .Select(x => new OrderVM()
        //        {
        //            ShipName = x.o.ShipName,
        //            ShipAddress = x.o.ShipAddress,
        //            ShipEmail = x.o.ShipEmail,
        //            ShipPhoneNumber = x.o.ShipPhoneNumber,
        //            Total = x.o.Total,
        //            PaymentMethod = x.o.PaymentMethod,
        //            Status = x.o.Status
        //        }).ToListAsync();

        //    //4. Select and projection
        //    var pagedResult = new PagedResult<OrderVM>()
        //    {
        //        TotalRecords = totalRow,
        //        PageIndex = request.PageIndex,
        //        PageSize = request.PageSize,
        //        Items = data
        //    };
        //    return new ApiSuccessResult<PagedResult<OrderVM>>(pagedResult);
        //}

        public async Task<int> Create(CheckoutRequest request)
        {
            var order = new Order()
            {
                OrderDate = DateTime.Now,
                UserId = request.UserId,
                ShipName = request.Name,
                ShipAddress = request.Address,
                ShipEmail = request.Email,
                ShipPhoneNumber = request.PhoneNumber,
                Total = request.Total,
                PaymentMethod = request.PaymentMethod,
                Status = (OrderStatus)1,               
            };

            _context.Orders.Add(order);

            //foreach (var item in request.OrderDetails)
            //{
            //    var orderDetail = new OrderDetail()
            //    {
            //        OrderId = order.Id,
            //        ProductId = item.ProductId,
            //        Quantity = item.Quantity,
            //        Price = item.Price
            //    };
            //    _context.OrderDetails.Add(orderDetail);
            //}           
            await _context.SaveChangesAsync();
            return order.Id;
        }

        public async Task<bool> CreateDetail(CheckoutRequest request, int id)
        {
            foreach (var item in request.OrderDetails)
            {
                var orderDetail = new OrderDetail()
                {
                    OrderId = id,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Price = item.Price
                };
                _context.OrderDetails.Add(orderDetail);
            }
            await _context.SaveChangesAsync();
            return true;
        }

        //public async Task<ApiResult<bool>> Delete(Guid id)
        //{
        //    var user = await _userManager.FindByIdAsync(id.ToString());
        //    if (user == null)
        //    {
        //        return new ApiErrorResult<bool>("User không tồn tại");
        //    }
        //    var reult = await _userManager.DeleteAsync(user);
        //    if (reult.Succeeded)
        //        return new ApiSuccessResult<bool>();

        //    return new ApiErrorResult<bool>("Xóa không thành công");
        //}

    }
}