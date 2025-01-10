using Microsoft.EntityFrameworkCore;
using SharpCompress.Common;
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
    public class OrderDetailService : IOrderDetailService
    {
        private readonly SSJDDbContext _context;
        public OrderDetailService(SSJDDbContext context)
        {
            _context = context;
        }
        public async Task Create(OrderDetailRequestModel request)
        {
            var entity = new Entities.StoreEntity.OrderDetail()
            {
                ID = request.ID,
                OrderID = request.OrderID,
                Quantity = request.Quantity,
                Subtotal = request.Subtotal,
                PromotionID = request.PromotionID,
            };
            _context.OrderDetail.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            var entity = await _context.OrderDetail.FindAsync(id);
            _context.OrderDetail.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(OrderDetailRequestModel request)
        {
            var data = await _context.OrderDetail.FindAsync(request.ID);
            if (data != null)
            {
                data.Quantity = request.Quantity;
                data.PromotionID = request.PromotionID;
                _context.OrderDetail.Update(data);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<OrderDetailViewModel>> GetAll()
        {
            var query = from o in _context.OrderDetail
                        join p in _context.Product on o.ProductID equals p.ID
                        join pr in _context.Promotion on o.PromotionID equals pr.ID
                        select new { p, o,pr };
            var data = await query.Select(x => new OrderDetailViewModel()
            {
                ID = x.o.ID,
                OrderID = x.o.OrderID,
                UnitProduct = x.p.Name,
                UnitPrice = x.p.Price,
                Quantity = x.o.Quantity,
                Subtotal = x.o.Subtotal,
                Promotion = x.pr.Name,
            }).ToListAsync();
            return data;
        }

        public async Task<OrderDetailViewModel?> GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderDetailRequestModel>> GetListByID(string id)
        {
            var query = from o in _context.OrderDetail
                        where o.ID == id
                        select o;
            var data = await query.Select(x => new OrderDetailRequestModel()
            {
                ID = x.ID,
                OrderID = x.OrderID,
                ProductID = x.ProductID,
                Quantity = x.Quantity,
                Subtotal = x.Subtotal,
                PromotionID = x.PromotionID
            }).ToListAsync();
            return data;

        }

        public Task<PagedResult<OrderDetailViewModel>> GetOrderDetailPaging(OrderDetailPagingRequest request)
        {
            throw new NotImplementedException();
        }     
    }
}
