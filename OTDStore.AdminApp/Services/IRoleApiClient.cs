using OTDStore.ViewModels.Common;
using OTDStore.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTDStore.AdminApp.Services
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVM>>> GetAll();
    }
}
