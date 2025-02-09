using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.Brand
{
    public interface IBrandService : IBaseService<BrandRequestModel, BrandViewModel>
    {
        Task<PagedResult<BrandViewModel>> GetBrandPaging(BrandPagingRequest request);
    }
}
