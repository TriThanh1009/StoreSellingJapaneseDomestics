using Microsoft.EntityFrameworkCore;
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
    public class MemberCardService : IMemberCardService, IBaseService<SSJD.Entities.StoreEntity.MemberCard,MemberCardViewModel>
    {
        private readonly SSJDDbContext _context;
        public MemberCardService(SSJDDbContext context)
        {
            _context = context;
        }
        public async Task Create(Entities.StoreEntity.MemberCard entity)
        {
            _context.MemberCard.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Entities.StoreEntity.MemberCard entity)
        {
            _context.MemberCard.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Entities.StoreEntity.MemberCard entity)
        {
            var data = await _context.MemberCard.FindAsync(entity.ID);
            data.Point = entity.Point;
            data.MemberClass = entity.MemberClass;
            data.Discount = entity.Discount;
            _context.MemberCard.Update(data);
            await _context.SaveChangesAsync();
        }

        public async Task<List<MemberCardViewModel>> GetAll()
        {
            var query = from p in _context.MemberCard select p;
            var data = await query.Select(x => new MemberCardViewModel
            {
                ID = x.ID,
                Point = x.Point,
                MemberClass = x.MemberClass,
                Discount = x.Discount
            }).ToListAsync();
            return data;
        }

        public async Task<MemberCardViewModel> GetByID(string id)
        {
            var data = await _context.MemberCard.FindAsync(id);
            var getdata = new MemberCardViewModel()
            {
                ID = data.ID,
                Point = data.Point,
                MemberClass = data.MemberClass,
                Discount = data.Discount
            };
            return getdata;
        }

        public Task<PagedResult<MemberCardViewModel>> GetMemberCardPaging(MemberCardPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
