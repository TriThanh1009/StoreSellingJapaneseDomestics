using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.Product
{
    public interface IProductService
    {
        Task<PagedResult<ProductViewModel>> GetProductPaging(ProductPagingRequest request);
    }
}
