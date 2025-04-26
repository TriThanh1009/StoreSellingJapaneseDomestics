using Microsoft.EntityFrameworkCore;
using SharpCompress.Common;
using SSJD.DataAccess;
using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.Account;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.UnitShip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.UnitShip
{
    public class UnitShipService : IUnitShipService
    {
        private readonly SSJDDbContext _context;
        public UnitShipService(SSJDDbContext context)
        {
            _context = context;
        }
        public async Task<string> Create(UnitShipRequestModel request)
        {
            var entity = new Entities.StoreEntity.UnitShip()
            {
                ID = Guid.NewGuid().ToString(),
                Name = request.Name
            };
            _context.UnitShip.Add(entity);
            await _context.SaveChangesAsync();
            return entity.ID;
        }

        public async Task Delete(string id)
        {
            var entity = await _context.UnitShip.FindAsync(id);
            _context.UnitShip.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(UnitShipRequestModel request)
        {
            var data = await _context.UnitShip.FindAsync(request.ID);
            if (data != null)
            {
                data.Name = request.Name;
                _context.UnitShip.Update(data);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<UnitShipViewModel>> GetAll()
        {
            var query = from u in _context.UnitShip select u;
            var data = await query.Select(x => new UnitShipViewModel()
            {
                ID = x.ID,
                Name = x.Name,
            }).ToListAsync();
            return data;
        }

        public async Task<UnitShipViewModel?> GetByID(string id)
        {
            var data = await _context.UnitShip.FindAsync(id);
            var getdata = new UnitShipViewModel()
            {
                Name = data.Name,
            };
            return getdata;
        }

        public Task<List<UnitShipViewModel>> GetListByID(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResult<UnitShipViewModel>> GetUnitShipPaging(UnitShipPagingRequest request)
        {
            var query = from p in _context.UnitShip select p;
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.Name.Contains(request.Keyword));
            }
            var totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                                  .Take(request.PageSize)
                                  .Select(x => new UnitShipViewModel()
                                  {
                                      Name = x.Name
                                  }).ToListAsync();
            var pagedView = new PagedResult<UnitShipViewModel>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedView;
        }
    }
}
