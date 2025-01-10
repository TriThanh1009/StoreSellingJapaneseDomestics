using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.Category
{
    public interface ICategoryService : IBaseService<CategoryRequestModel, CategoryViewModel>
    { 
        Task<PagedResult<CategoryViewModel>> GetCategoryPaging(CategoryPagingRequest request);
    }
}
