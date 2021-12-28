using System;
using System.Collections.Generic;
using System.Text;

namespace OTDStore.ApiIntegration
{
    public interface IOrderApiClient
    {
        Task<ApiResult<bool>> CreateOrder(OrderCreateRequest register);
    }
}
