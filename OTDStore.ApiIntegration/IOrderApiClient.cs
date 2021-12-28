using OTDStore.ViewModels.Common;
using OTDStore.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OTDStore.ApiIntegration
{
    public interface IOrderApiClient
    {
        Task<ApiResult<bool>> CreateOrder(CheckoutRequest request);
        //Task<ApiResult<PagedResult<OrderVM>>> GetOrdersPagings(GetOrderPagingRequest request);
    }
}
