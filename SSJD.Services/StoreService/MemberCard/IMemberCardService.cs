using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.MemberCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.MemberCard
{
    public interface IMemberCardService : IBaseService<MemberCardRequestModel, MemberCardViewModel>
    {
        Task<PagedResult<MemberCardViewModel>> GetMemberCardPaging(MemberCardPagingRequest request);
    }
}
