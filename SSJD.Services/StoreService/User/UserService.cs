using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.User
{
    public class UserService : IBaseService<SSJD.Entities.StoreEntity.User,UserViewModel>,IUserService
    {
        public Task Create(Entities.StoreEntity.User entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Entities.StoreEntity.User entity)
        {
            throw new NotImplementedException();
        }

        public Task Edit(Entities.StoreEntity.User entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserViewModel> GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<UserViewModel>> GetUserPaging(UserPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
