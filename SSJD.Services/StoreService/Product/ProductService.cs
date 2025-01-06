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
    public class ProductService : IBaseService<SSJD.Entities.StoreEntity.Product, ProductViewModel>,IProductService
    {
        public Task Create(Entities.StoreEntity.Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Entities.StoreEntity.Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Edit(Entities.StoreEntity.Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductViewModel> GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<ProductViewModel>> GetProductPaging(ProductPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
