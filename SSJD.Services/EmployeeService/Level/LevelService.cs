using Microsoft.EntityFrameworkCore;
using SSJD.DataAccess;
using SSJD.Entities.EmployeeEntity;
using SSJD.ViewModel.EmployeeViewModel.Level;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.EmployeeService.Level
{
    public class LevelService : ILevelService
    {
        private readonly SSJDDbContext _context;
        public LevelService(SSJDDbContext context)
        {
            _context = context;
        }
        public async Task Create(LevelCreateViewModel request)
        {
            var entity = new SSJD.Entities.EmployeeEntity.Level
            {
                ID = request.ID,
                Name = request.Name,
            };
            _context.Level.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int ID)
        {
            var find = await _context.Level.FindAsync(ID);
            _context.Level.Remove(find);
            await _context.SaveChangesAsync();
        }

        public Task Edit(LevelEditViewModel request)
        {
            throw new NotImplementedException();
        }

        public async Task<List<LevelViewModel>> GetAll()
        {
            var query = from p in _context.Level select p;
            var data = await query.Select(x => new LevelViewModel()
            {
                ID = x.ID,
                Name = x.Name
            }).ToListAsync();
            return data;
        }

        public Task<PagedResult<LevelViewModel>> GetAllPage(LevelPagingRequest paging)
        {
            throw new NotImplementedException();
        }
    }
}
