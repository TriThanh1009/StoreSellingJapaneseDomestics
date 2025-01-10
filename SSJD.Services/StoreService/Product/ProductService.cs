using Microsoft.EntityFrameworkCore;
using SharpCompress.Common;
using SSJD.DataAccess;
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
    public class ProductService : IProductService
    {
        private readonly SSJDDbContext _context;
        public ProductService(SSJDDbContext context)
        {
            _context = context;
        }
        public async Task Create(ProductRequestModel request)
        {
            var entity = new Entities.StoreEntity.Product()
            {
                ID = request.ID,
                Name = request.Name,
                Brand = request.Brand,
                CategoryID = request.CategoryID,
                Price = request.Price,
                Stock = request.Stock,
                isActive = request.isActive,
                Image = request.Image,
            };
            _context.Product.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            var entity = await _context.Product.FindAsync(id);
            _context.Product.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(ProductRequestModel request)
        {
            var data = await _context.Product.FindAsync(request.ID);
            if (data != null)
            {
                data.Name = request.Name;
                data.Brand = request.Brand;
                data.CategoryID = request.CategoryID;
                data.Price = request.Price;
                data.Stock = request.Stock;
                data.isActive = request.isActive;
                data.Image = request.Image;
                _context.Product.Update(data);
                await _context.SaveChangesAsync();
            }
        }

        public Task<List<ProductViewModel>> GetAll()
        {
            var query = from p in _context.Product
                        join c in _context.Category on p.CategoryID equals c.ID
                        select new { p, c };
            var data = query.Select(x => new ProductViewModel()
            {
                ID = x.p.ID,
                Name = x.p.Name,
                Brand = x.p.Brand,
                Category = x.c.Name,
                Price = x.p.Price,
                Stock = x.p.Stock,
                isActive = x.p.isActive,
                Image = x.p.Image,
            }).ToListAsync();
            return data;
        }

        public async Task<ProductRequestModel?> GetByID(string id)
        {
            var data = await _context.Product.FindAsync(id);
            var getdata = new ProductRequestModel()
            {
                ID = data.ID,
                Name = data.Name,
                Brand = data.Brand,
                CategoryID = data.CategoryID,
                Price = data.Price,
                Stock = data.Stock,
                isActive = data.isActive,
                Image = data.Image,
            };
            return getdata;
        }

        public Task<List<ProductRequestModel>> GetListByID(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<ProductViewModel>> GetProductPaging(ProductPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
