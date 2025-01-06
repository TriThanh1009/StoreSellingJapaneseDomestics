using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.Promotion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.Promotion
{
    public interface IPromotionService
    {
        Task<PagedResult<PromotionViewModel>> GetPromotionPaging(PromotionPagingRequest request);
    }
}
