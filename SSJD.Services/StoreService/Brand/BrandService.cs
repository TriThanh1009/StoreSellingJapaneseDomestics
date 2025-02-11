using Microsoft.EntityFrameworkCore;
using SSJD.DataAccess;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.Brand;
using SSJD.ViewModel.StoreViewModel.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.Brand
{
    public class BrandService : IBrandService
    {
        private readonly SSJDDbContext _context;
        public BrandService(SSJDDbContext context)
        {
            _context = context;
        }
        public async Task Create(BrandRequestModel request)
        {
            var entity = new SSJD.Entities.StoreEntity.Brand()
            {
                ID = Guid.NewGuid().ToString(),
                Name = request.Name,
            };
            _context.Brand.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            var entity = await _context.Brand.FindAsync(id);
            _context.Brand.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(BrandRequestModel request)
        {
            var data = await _context.Brand.FindAsync(request.ID);
            if (data != null)
            {
                data.ID = request.ID;
                data.Name = request.Name;
                _context.Brand.Update(data);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<BrandViewModel>> GetAll()
        {
            var query = from p in _context.Brand select p;
            var data = await query.Select(x => new BrandViewModel()
            {
                ID = x.ID,
                Name = x.Name
            }).ToListAsync();
            return data;
        }

        public Task<PagedResult<BrandViewModel>> GetBrandPaging(BrandPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<BrandViewModel?> GetByID(string id)
        {
            var data = await _context.Brand.FindAsync(id);
            var getdata = new BrandViewModel()
            {
                ID = data.ID,
                Name = data.Name,
            };
            return getdata;
        }

        public Task<List<BrandViewModel>> GetListByID(string id)
        {
            throw new NotImplementedException();
        }
    }
}
