using Microsoft.EntityFrameworkCore;
using SharpCompress.Common;
using SSJD.DataAccess;
using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.StoreViewModel.Customer;
using SSJD.ViewModel.StoreViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SSJD.Services.StoreService.User
{
    public class UserService : IUserService
    {
        private readonly SSJDDbContext _context;
        public UserService(SSJDDbContext context)
        {
            _context = context; 
        }
        public async Task Create(UserRequestModel request)
        {
            var entity = new Entities.StoreEntity.User()
            {
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
                Address = request.Address,
                IdentityCard = request.IdentityCard,
                Email = request.Email,
                AccountID = request.AccountID,
                MemberCardID = request.MemberCardID,
                Image = request.Image
            };
            _context.User.Add(entity);
            await _context.SaveChangesAsync();
        }


        public async Task Delete(string id)
        {
            var entity = await _context.User.FindAsync(id);
            _context.User.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(UserRequestModel request)
        {
            var data = await _context.User.FindAsync(request.Id);
            if (data != null)
            {
                data.UserName = request.UserName;
                data.PhoneNumber = request.PhoneNumber;
                data.Address = request.Address;
                data.IdentityCard = request.IdentityCard;
                data.Email = request.Email;
                data.AccountID = request.AccountID;
                data.MemberCardID = request.MemberCardID;
                data.Image = request.Image;
                _context.User.Update(data);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<List<UserViewModel>> GetAll()
        {
            var query = from u in _context.User
                        join a in _context.Account on u.AccountID equals a.ID
                        join m in _context.MemberCard on u.MemberCardID equals m.ID
                        select new { u, a,m };
            var data = await query.Select(x => new UserViewModel()
            {
                Id = x.u.Id,
                UserName = x.u.UserName,
                PhoneNumber = x.u.PhoneNumber ?? "",
                Address = x.u.Address,
                IdentityCard = x.u.IdentityCard,
                Email = x.u.Email ?? "",
                Account = x.a.UserName,
                MemberCard = x.m.MemberClass,
                Image = x.u.Image
            }).ToListAsync();
            return data;
        }

        public async Task<UserViewModel?> GetByID(string id)
        {
            var data = await _context.User.FindAsync(id);
            var getdata = new UserViewModel()
            {
                UserName = data.UserName,
                PhoneNumber = data.PhoneNumber ?? "",
                Address = data.Address,
                IdentityCard = data.IdentityCard,
                Email = data.Email ?? "",
                Account = data.AccountID,
                MemberCard = data.MemberCardID,
                Image = data.Image
            };
            return getdata;
        }

        public Task<List<UserViewModel>> GetListByID(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<UserViewModel>> GetUserPaging(UserPagingRequest request)
        {
            throw new NotImplementedException();
        }

    }
}
