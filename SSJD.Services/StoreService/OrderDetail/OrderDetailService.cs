using SSJD.DataAccess;
using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.OrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.OrderDetail
{
    public class OrderDetailService : IBaseService<SSJD.Entities.StoreEntity.OrderDetail,OrderDetailViewModel>,IOrderDetailService
    {
        private readonly SSJDDbContext _context;
        public OrderDetailService(SSJDDbContext context)
        {
            _context = context;
        }
        public async Task Create(Entities.StoreEntity.OrderDetail entity)
        {
            _context.OrderDetail.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Entities.StoreEntity.OrderDetail entity)
        {
            _context.OrderDetail.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Entities.StoreEntity.OrderDetail entity)
        {
            var data = await _context.OrderDetail.FindAsync(entity.ID);
            
        }

        public Task<List<OrderDetailViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetailViewModel> GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<OrderDetailViewModel>> GetOrderDetailPaging(OrderDetailPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
