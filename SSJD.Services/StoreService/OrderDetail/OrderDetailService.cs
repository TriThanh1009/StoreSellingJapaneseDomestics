using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SharpCompress.Common;
using SSJD.DataAccess;
using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.Order;
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
        public async Task<string> Create(OrderDetailRequestModel request)
        {
            var entity = new Entities.StoreEntity.OrderDetail()
            {
                ID = Guid.NewGuid().ToString(),
                OrderID = request.OrderID,
                ProductID = request.ProductID,
                HeadType = request.HeadType,
                Quantity = request.Quantity,
                Subtotal = request.Subtotal,
                PromotionID = request.PromotionID,
            };
            _context.OrderDetail.Add(entity);
            await _context.SaveChangesAsync();
            return entity.ID;

        }

        public async Task<int> CreateList(List<OrderDetailRequestModel> request)
        {
            var OrderID = request.Select(request => request.OrderID).FirstOrDefault();
            var entity =  request.Select(x => new Entities.StoreEntity.OrderDetail()
            {
                ID = Guid.NewGuid().ToString(),
                OrderID = OrderID,
                ProductID = x.ProductID,
                HeadType = x.HeadType,
                Quantity = x.Quantity,
                Subtotal = x.Subtotal,
                PromotionID = x.PromotionID,
            }).ToList();
            _context.OrderDetail.AddRange(entity);
            await _context.SaveChangesAsync();
            return entity.Count;

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
                data.ProductID = request.ProductID;
                data.HeadType = request.HeadType;
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
                HeadType = x.o.HeadType,
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

        public async Task<List<OrderDetailViewModel>> GetListByID(string id)
        {
            var query = from o in _context.OrderDetail
                        where o.ID == id
                        select o;
            var data = await query.Select(x => new OrderDetailViewModel()
            {
                OrderID = x.OrderID,
                ProductID = x.ProductID,
                HeadType = x.HeadType,
                Quantity = x.Quantity,
                Subtotal = x.Subtotal,
                Promotion = x.PromotionID
            }).ToListAsync();
            return data;

        }

        public async Task<PagedResult<OrderDetailViewModel>> GetOrderDetailPaging(OrderDetailPagingRequest request)
        {
            var query = from p in _context.OrderDetail select new { p };
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.p.ID.Contains(request.Keyword) || x.p.OrderID.Contains(request.Keyword));
            }
            int totalRow = await query.CountAsync();
            var data = await query.OrderBy(x => Convert.ToInt32(x.p.ID)).Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new OrderDetailViewModel()
                {
                    ID = x.p.ID,
                    OrderID = x.p.OrderID,
                    ProductID = x.p.ProductID,
                    HeadType = x.p.HeadType,
                    Quantity = x.p.Quantity,
                    Subtotal = x.p.Subtotal,
                    Promotion = x.p.PromotionID
                }).ToListAsync();
            var pagedView = new PagedResult<OrderDetailViewModel>()
            {
                TotalRecords = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                Items = data
            };
            return pagedView;
        }

        public async Task<List<OrderDetailListViewModel>> ListByOrderID()
        {
            var query = from o in _context.OrderDetail
                        join p in _context.Product on o.ProductID equals p.ID
                        join pr in _context.Promotion on o.PromotionID equals pr.ID into promotionJoin
                        from pr in promotionJoin.DefaultIfEmpty()
                        select new
                        {
                            o.OrderID,
                            OrderDetail = new OrderDetailViewModel()
                            {
                                ID = o.ID,
                                OrderID = o.OrderID,
                                UnitProduct = p.Name,
                                HeadType = o.HeadType,
                                UnitPrice = p.Price,
                                Quantity = o.Quantity,
                                Subtotal = o.Subtotal,
                                Promotion = pr.Name
                            }
                        };

            var groupedData = await query
                .GroupBy(x => x.OrderID)
                .Select(g => new OrderDetailListViewModel
                {
                    OrderID = g.Key,
                    OrderDetails = g.Select(x => x.OrderDetail).ToList()
                })
                .ToListAsync();

            return groupedData;
        }

    }
}
