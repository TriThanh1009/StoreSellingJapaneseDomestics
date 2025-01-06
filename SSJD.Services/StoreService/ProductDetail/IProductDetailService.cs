using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.ProductDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.ProductDetail
{
    public interface IProductDetailService
    {
        Task<PagedResult<ProductDetailViewModel>> GetProductDetailViewModel (ProductDetailPagingRequest request);
    }
}
