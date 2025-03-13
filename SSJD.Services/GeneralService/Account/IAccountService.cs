using SSJD.Entities.GeneralEntity;
using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.Account;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.GeneralViewModel.PageResultBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.GeneralService.Account
{
    public interface IAccountService : IBaseService<AccountRequestModel,AccountViewModel>
    {
        Task<PagedResult<AccountViewModel>> GetAccountPaging(AccountPagingRequest request);

    }
}
