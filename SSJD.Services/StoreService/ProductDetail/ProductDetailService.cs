using Microsoft.EntityFrameworkCore;
using SharpCompress.Common;
using SSJD.DataAccess;
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
    public class ProductDetailService : IProductDetailService
    {
        private readonly SSJDDbContext _context;
        public ProductDetailService(SSJDDbContext context)
        {
            _context = context;
        }
        public async Task Create(ProductDetailRequestModel request)
        {
            var entity = new Entities.StoreEntity.ProductDetail()
            {
                ID = Guid.NewGuid().ToString(),
                ProductID = request.ProductID,
                Description = request.Description,
                Warranty = request.Warranty,
                Origin = request.Origin,
                AdditionalImage = request.AdditionalImage,
            };
            _context.ProductDetail.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            var entity = await _context.ProductDetail.FindAsync(id);
            _context.ProductDetail.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(ProductDetailRequestModel request)
        {
            var data = await _context.ProductDetail.FindAsync(request.ID);
            if (data != null)
            {
                data.ProductID = request.ProductID;
                data.Description = request.Description;
                data.Warranty = request.Warranty;
                data.Origin = request.Origin;
                data.AdditionalImage = request.AdditionalImage;
                _context.ProductDetail.Update(data);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<ProductDetailViewModel>> GetAll()
        {
            var query = from pd in _context.ProductDetail
                        join p in _context.Product on pd.ProductID equals p.ID
                        select new { pd, p };
            var data = await query.Select(x => new ProductDetailViewModel()
            {
                ID = x.pd.ID,
                Product = x.p.Name,
                Description = x.pd.Description,
                Warranty = x.pd.Warranty,
                Origin = x.pd.Origin,
                AdditionalImage = x.pd.AdditionalImage
            }).ToListAsync();
            return data;
        }

        public async Task<ProductDetailRequestModel?> GetByID(string id)
        {
            var data = await _context.ProductDetail.FindAsync(id);
            var getdata = new ProductDetailRequestModel()
            {
                ProductID = data.ProductID,
                Description = data.Description,
                Warranty = data.Warranty,
                Origin = data.Origin,
                AdditionalImage = data.AdditionalImage,
            };
            return getdata;
        }

        public Task<List<ProductDetailRequestModel>> GetListByID(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<ProductDetailViewModel>> GetProductDetailViewModel(ProductDetailPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
