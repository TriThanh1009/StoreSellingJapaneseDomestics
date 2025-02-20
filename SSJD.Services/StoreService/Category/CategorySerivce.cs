using Microsoft.EntityFrameworkCore;
using SharpCompress.Common;
using SSJD.DataAccess;
using SSJD.Entities.StoreEntity;
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
    public class CategorySerivce : ICategoryService
    {
        private readonly SSJDDbContext _context;
        public CategorySerivce(SSJDDbContext context)
        {
            _context = context;
        }
        public async Task<string> Create(CategoryRequestModel request)
        {
            var entity = new SSJD.Entities.StoreEntity.Category()
            {
                ID = Guid.NewGuid().ToString(),
                Name = request.Name,
            };
            _context.Category.Add(entity);
            await _context.SaveChangesAsync();
            return entity.ID;
        }

        public async Task Delete(string id)
        {
            var entity = await _context.Category.FindAsync(id);
            _context.Category.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(CategoryRequestModel request)
        {
            var data = await _context.Category.FindAsync(request.ID);
            if (data != null)
            {
                data.ID = request.ID;
                data.Name = request.Name;
                _context.Category.Update(data);
                await _context.SaveChangesAsync();
            }
            
        }

        public async Task<List<CategoryViewModel>> GetAll()
        {
            var query = from p in _context.Category select p;
            var data = await query.Select(x => new CategoryViewModel()
            {
                ID = x.ID,
                Name = x.Name
            }).ToListAsync();
            return data;
        }

        public async Task<CategoryViewModel?> GetByID(string id)
        {
            var data = await _context.Category.FindAsync(id);
            var getdata = new CategoryViewModel()
            {
                ID = data.ID,
                Name = data.Name,
            };
            return getdata;
        }

        public Task<PagedResult<CategoryViewModel>> GetCategoryPaging(CategoryPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryViewModel>> GetListByID(string id)
        {
            throw new NotImplementedException();
        }
    }
}
