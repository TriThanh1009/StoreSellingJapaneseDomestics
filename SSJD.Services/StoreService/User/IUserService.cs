using SSJD.Entities.StoreEntity;
using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.Customer;
using SSJD.ViewModel.StoreViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.User
{
    public interface IUserService : IBaseService<UserRequestModel, UserViewModel>
    {
        Task<PagedResult<UserViewModel>> GetUserPaging(UserPagingRequest request);

        Task<UserOrderProfile> GetUserProfileById(string id);
    }
}
