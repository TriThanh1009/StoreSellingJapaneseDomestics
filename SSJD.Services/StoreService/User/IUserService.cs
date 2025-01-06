using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.User
{
    public interface IUserService
    {
        Task<PagedResult<UserViewModel>> GetUserPaging(UserPagingRequest request);
    }
}
