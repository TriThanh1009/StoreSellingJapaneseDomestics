using Microsoft.EntityFrameworkCore;
using SharpCompress.Common;
using SSJD.DataAccess;
using SSJD.Entities.StoreEntity;
using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.Order
{
    public class OrderService : IOrderService,IBaseService<SSJD.Entities.StoreEntity.Order, OrderViewModel>
    {
        private readonly SSJDDbContext _context;
        public OrderService(SSJDDbContext context)
        {
            _context = context;
        }
        public async Task Create(Entities.StoreEntity.Order entity)
        {
            _context.Order.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Entities.StoreEntity.Order entity)
        {
            _context.Order.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Entities.StoreEntity.Order entity)
        {
            var data = await _context.Order.FindAsync(entity.ID);
            data.OrderDate = entity.OrderDate;
            data.ShippingUnitID = entity.ShippingUnitID;
            data.ShippingDate = entity.ShippingDate;
            data.ShippingAddress = entity.ShippingAddress;
            data.OrderStatus = entity.OrderStatus;
            data.PaymentMethod = entity.PaymentMethod;
            data.PaymentStatus = entity.PaymentStatus;
            _context.Order.Update(data);
            await _context.SaveChangesAsync();
        }

        public async Task<List<OrderViewModel>> GetAll()
        {
            var query = from p in _context.Order select p;
            var data = await query.Select(x => new OrderViewModel
            {
                ID = x.ID,
                Customer = x.CustomerID,
                OrderDate = x.OrderDate,
                ShippingUnit = x.ShippingUnitID,
                ShippingDate = x.ShippingDate,
                ShippingAddress = x.ShippingAddress,
                OrderStatus = x.OrderStatus,
                PaymentMethod = x.PaymentMethod,
                PaymentStatus = x.PaymentStatus,
                
            }).ToListAsync();
            return data;
        }

        public async Task<OrderViewModel> GetByID(string id)
        {
            var data = await _context.Order.FindAsync(id);
            var getdata = new OrderViewModel()
            {
                ID = data.ID,
                Customer = data.CustomerID,
                OrderDate = data.OrderDate,
                ShippingUnit = data.ShippingUnitID,
                ShippingDate = data.ShippingDate,
                ShippingAddress = data.ShippingAddress,
                OrderStatus = data.OrderStatus,
                PaymentMethod = data.PaymentMethod,
                PaymentStatus = data.PaymentStatus,
            };
            return getdata;
        }

        public Task<PagedResult<OrderViewModel>> GetOrderPaging(OrderPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
