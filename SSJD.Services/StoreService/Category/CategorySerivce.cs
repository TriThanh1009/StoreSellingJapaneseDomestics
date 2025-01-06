using Microsoft.EntityFrameworkCore;
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
    public class CategorySerivce : IBaseService<Entities.StoreEntity.Category,CategoryViewModel>,ICategoryService
    {
        private readonly SSJDDbContext _context;
        public CategorySerivce(SSJDDbContext context)
        {
            _context = context;
        }
        public async Task Create(Entities.StoreEntity.Category entity)
        {
            _context.Category.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Entities.StoreEntity.Category entity)
        {
            _context.Category.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Entities.StoreEntity.Category entity)
        {
            var data = await _context.Category.FindAsync(entity.ID);
            data.ID = entity.ID;
            data.Name = entity.Name;
            _context.Category.Update(data);
            await _context.SaveChangesAsync();
        }

        public async Task<List<CategoryViewModel>> GetAll()
        {
            var query = from p in _context.Category select  p;
            var data = await query.Select(x => new CategoryViewModel
            {
                ID = x.ID,
                Name = x.Name
            }).ToListAsync();
            return data;
        }

        public async Task<CategoryViewModel> GetByID(string id)
        {
            var data = await _context.Category.FindAsync(id);
            var getdata = new CategoryViewModel()
            {
                Name = data.Name
            };
            return getdata;
        }

        public Task<PagedResult<CategoryViewModel>> GetCategoryPaging(CategoryPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
