using Azure.Core;
using Microsoft.EntityFrameworkCore;
using SharpCompress.Common;
using SSJD.DataAccess;
using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.Promotion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SSJD.Services.StoreService.Promotion
{
    public class PromotionService : IPromotionService
    {
        private readonly SSJDDbContext _context;
        public PromotionService(SSJDDbContext context)
        {
            _context = context;
        }
        public async Task<string> Create(PromotionRequestModel request)
        {
            var entity = new Entities.StoreEntity.Promotion()
            {
                ID = request.ID,
                Name = request.Name,
                CreateDate = request.CreateDate,
                EndDate = request.EndDate,
                PercentDiscount = request.PercentDiscount,
            };
            _context.Promotion.Add(entity);
            await _context.SaveChangesAsync();
            return entity.ID;
        }

        public async Task Delete(string id)
        {
            var entity = await _context.Promotion.FindAsync(id);
            _context.Promotion.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(PromotionRequestModel request)
        {
            var data = await _context.Promotion.FindAsync(request.ID);
            if (data != null)
            {
                data.Name = request.Name;
                data.CreateDate = request.CreateDate;
                data.EndDate = request.EndDate;
                data.PercentDiscount = request.PercentDiscount;
                _context.Promotion.Update(data);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<PromotionViewModel>> GetAll()
        {
            var query = from p in _context.Promotion select p;
            var data = await query.Select(x => new PromotionViewModel()
            {
                ID = x.ID,
                Name = x.Name,
                CreateDate = x.CreateDate,
                EndDate = x.EndDate,
                PercentDiscount = x.PercentDiscount
            }).ToListAsync();
            return data;
        }

        public async Task<PromotionViewModel?> GetByID(string id)
        {
            var data = await _context.Promotion.FindAsync(id);
            var getdata = new PromotionViewModel()
            {
                Name = data.Name,
                CreateDate = data.CreateDate,
                EndDate = data.EndDate,
                PercentDiscount = data.PercentDiscount
            };
            return getdata;
        }

        public Task<List<PromotionViewModel>> GetListByID(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<PromotionViewModel>> GetPromotionPaging(PromotionPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
