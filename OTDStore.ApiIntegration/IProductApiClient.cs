using OTDStore.ViewModels.Catalog.Products;
using OTDStore.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTDStore.ApiIntegration
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductVM>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<ProductVM> GetById(int id);

        Task<List<ProductVM>> GetLatestProducts(int take);
    }
}
