using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.Product
{
    public interface IProductService : IBaseService<ProductRequestModel, ProductViewModel>
    {
        Task<PagedResult<ProductViewModel>> GetProductPaging(ProductPagingRequest request);
    }
}
