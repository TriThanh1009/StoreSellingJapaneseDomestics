using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.Promotion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.Promotion
{
    public class PromotionService : IBaseService<SSJD.Entities.StoreEntity.Promotion,PromotionViewModel>,IPromotionService
    {
        public Task Create(Entities.StoreEntity.Promotion entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Entities.StoreEntity.Promotion entity)
        {
            throw new NotImplementedException();
        }

        public Task Edit(Entities.StoreEntity.Promotion entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<PromotionViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PromotionViewModel> GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<PromotionViewModel>> GetPromotionPaging(PromotionPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
