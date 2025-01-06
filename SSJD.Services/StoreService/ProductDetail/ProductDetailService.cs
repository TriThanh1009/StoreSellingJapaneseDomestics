using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.ProductDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.ProductDetail
{
    public class ProductDetailService : IBaseService<SSJD.Entities.StoreEntity.ProductDetail,ProductDetailViewModel>,IProductDetailService
    {
        public Task Create(SSJD.Entities.StoreEntity.ProductDetail entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(SSJD.Entities.StoreEntity.ProductDetail entity)
        {
            throw new NotImplementedException();
        }

        public Task Edit(SSJD.Entities.StoreEntity.ProductDetail entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDetailViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDetailViewModel> GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<ProductDetailViewModel>> GetProductDetailViewModel(ProductDetailPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
