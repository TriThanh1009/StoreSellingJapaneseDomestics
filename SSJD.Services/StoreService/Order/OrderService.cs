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
    public class OrderService : IOrderService
    {
        private readonly SSJDDbContext _context;
        public OrderService(SSJDDbContext context)
        {
            _context = context;
        }
        public async Task Create(OrderRequestModel request)
        {
            var entity = new Entities.StoreEntity.Order()
            {
                ID = request.ID,
                OrderDate = request.OrderDate,
                ShippingUnitID = request.ShippingUnitID,
                ShippingDate = request.ShippingDate,
                ShippingAddress = request.ShippingAddress,
                OrderStatus = request.OrderStatus,
                PaymentMethod = request.PaymentMethod,
                PaymentStatus = request.PaymentStatus
            };
            _context.Order.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            var entity = await _context.Order.FindAsync(id);
            _context.Order.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(OrderRequestModel request)
        {
            var data = await _context.Order.FindAsync(request.ID);
            if (data != null)
            {
                data.OrderDate = request.OrderDate;
                data.ShippingUnitID = request.ShippingUnitID;
                data.ShippingDate = request.ShippingDate;
                data.ShippingAddress = request.ShippingAddress;
                data.OrderStatus = request.OrderStatus;
                data.PaymentMethod = request.PaymentMethod;
                data.PaymentStatus = request.PaymentStatus;
                _context.Order.Update(data);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<OrderViewModel>> GetAll()
        {
            var query = from p in _context.Order select p;
            var data = await query.Select(x => new OrderViewModel()
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

        public async Task<OrderRequestModel?> GetByID(string id)
        {
            var data = await _context.Order.FindAsync(id);
            var getdata = new OrderRequestModel()
            {
                ID = data.ID,
                CustomerID = data.CustomerID,
                OrderDate = data.OrderDate,
                ShippingUnitID = data.ShippingUnitID,
                ShippingDate = data.ShippingDate,
                ShippingAddress = data.ShippingAddress,
                OrderStatus = data.OrderStatus,
                PaymentMethod = data.PaymentMethod,
                PaymentStatus = data.PaymentStatus,
            };
            return getdata;
        }

        public Task<List<OrderRequestModel>> GetListByID(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<OrderViewModel>> GetOrderPaging(OrderPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
