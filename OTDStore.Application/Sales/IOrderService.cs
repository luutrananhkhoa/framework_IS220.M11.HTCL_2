using OTDStore.ViewModels.Common;
using OTDStore.ViewModels.Sales;
using System.Threading.Tasks;

namespace OTDStore.Application.System.Users
{
    public interface IOrderService
    {
        Task<int> Create(CheckoutRequest request);

        Task<bool> CreateDetail(CheckoutRequest request, int id);

        //Task<ApiResult<PagedResult<OrderVM>>> GetOrderPaging(OrderCreateRequest request);
    }
}