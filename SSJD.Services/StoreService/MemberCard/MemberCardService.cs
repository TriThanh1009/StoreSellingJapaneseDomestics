using Microsoft.EntityFrameworkCore;
using SharpCompress.Common;
using SSJD.DataAccess;
using SSJD.Entities.StoreEntity;
using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.MemberCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.MemberCard
{
    public class MemberCardService : IMemberCardService
    {
        private readonly SSJDDbContext _context;
        public MemberCardService(SSJDDbContext context)
        {
            _context = context;
        }
        public async Task<string> Create(MemberCardRequestModel request)
        {
            var entity = new Entities.StoreEntity.MemberCard()
            {
                ID = Guid.NewGuid().ToString(),
                Point = request.Point,
                MemberClass = request.MemberClass,
                Discount = request.Discount
            };
            _context.MemberCard.Add(entity);
            await _context.SaveChangesAsync();
            return entity.ID;
        }

        public async Task Delete(string id)
        {
            var entity = await _context.MemberCard.FindAsync(id);
            _context.MemberCard.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(MemberCardRequestModel request)
        {
            var data = await _context.MemberCard.FindAsync(request.ID);
            if (data != null)
            {
                data.Point = request.Point;
                data.MemberClass = request.MemberClass;
                data.Discount = request.Discount;
                _context.MemberCard.Update(data);
                await _context.SaveChangesAsync();
            }
           
        }

        public async Task<List<MemberCardViewModel>> GetAll()
        {
            var query = from p in _context.MemberCard select p;
            var data = await query.Select(x => new MemberCardViewModel()
            {
                ID = x.ID,
                Point = x.Point,
                MemberClass = x.MemberClass,
                Discount = x.Discount
            }).ToListAsync();
            return data;
        }

        public async Task<MemberCardViewModel?> GetByID(string id)
        {
            var data = await _context.MemberCard.FindAsync(id);
            var getdata = new MemberCardViewModel()
            {
                Point = data.Point,
                MemberClass = data.MemberClass,
                Discount = data.Discount
            };
            return getdata;
        }

        public Task<List<MemberCardViewModel>> GetListByID(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<MemberCardViewModel>> GetMemberCardPaging(MemberCardPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
