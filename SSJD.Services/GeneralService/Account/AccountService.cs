using Azure.Core;
using FirebaseAdmin.Auth;
using Microsoft.EntityFrameworkCore;
using SharpCompress.Common;
using SSJD.DataAccess;
using SSJD.Entities.GeneralEntity;
using SSJD.Services.GeneralService.Base;
using SSJD.Services.GeneralService.Role;
using SSJD.ViewModel.GeneralViewModel.Account;
using SSJD.ViewModel.GeneralViewModel.PageResult;
using SSJD.ViewModel.GeneralViewModel.PageResultBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.GeneralService.Account
{
    public class AccountService : IAccountService
    {
        private readonly SSJDDbContext _context;
        private readonly FirebaseAuth _firebaseAuth;
        public AccountService(SSJDDbContext context, FirebaseAuth firebase)
        {
            _context = context;
            _firebaseAuth = firebase;
        }
        public async Task<string> Create(AccountRequestModel request)
        {
            var entity = new SSJD.Entities.GeneralEntity.Account()
            {
                ID = Guid.NewGuid().ToString(),
                UserName = request.UserName,
                Password = request.Password,
                PasswordCheck = request.PasswordCheck,
                Email = request.Email,
            };
            _context.Account.Add(entity);
            await _context.SaveChangesAsync();
            return entity.ID;
        }



        public async Task Delete(string id)
        {
            var entity = await _context.Account.FindAsync(id);
            _context.Account.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(AccountRequestModel request)
        {
            var data = await _context.Account.FindAsync(request.ID);
            if (data != null)
            {
                data.UserName = request.UserName;
                data.Password = request.Password;
                data.PasswordCheck = request.PasswordCheck;
                data.Email = request.Email;
                _context.Account.Update(data);
                await _context.SaveChangesAsync();
            }
        }

        public async Task ForgotPassword(ForgotPasswordRequest request)
        {
            var actionCodeSettings = new ActionCodeSettings
            {
                Url = "http://localhost:5255/reset-password", // URL frontend để xử lý reset
                HandleCodeInApp = false
            };

            var link = await _firebaseAuth.GeneratePasswordResetLinkAsync(request.Email, actionCodeSettings);
            await SendCustomEmail(request.Email, link); // Gửi email tùy chỉnh (nếu cần)
        }
        public async Task SendCustomEmail(string email, string resetLink)
        {
            // Sử dụng SMTP hoặc dịch vụ khác để gửi email tùy chỉnh
            var emailContent = resetLink;
        }

        public async Task<PagedResult<AccountViewModel>> GetAccountPaging(AccountPagingRequest request)
        {
            var query = from p in _context.Account select p;
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.UserName.Contains(request.Keyword) || x.Email.Contains(request.Keyword));
            }
            var totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex- 1) * request.PageSize)
                                  .Take(request.PageSize)
                                  .Select(x => new AccountViewModel()
                                    {
                                        UserName = x.UserName,
                                        Password = x.Password,
                                        PasswordCheck = x.PasswordCheck,
                                        Email = x.Email,
                                    }).ToListAsync();
            var pagedView = new PagedResult<AccountViewModel>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedView;
        }

        public async Task<List<AccountViewModel>> GetAll()
        {
            var query = from p in _context.Account select p;
            var data = await query.Select(x => new AccountViewModel()
            {
                ID = x.ID,
                UserName = x.UserName,
                Password = x.Password,
                PasswordCheck = x.PasswordCheck,
                Email = x.Email,
            }).ToListAsync();
            return data;
        }

        public async Task<AccountViewModel?> GetByID(string id)
        {
            var data = await _context.Account.FindAsync(id);
            var getdata = new AccountViewModel()
            {
                ID = data.ID,
                UserName = data.UserName,
                Password = data.Password,
                PasswordCheck = data.PasswordCheck,
                Email = data.Email,
            };
            return getdata;
        }

        public Task<List<AccountViewModel>> GetListByID(string id)
        {
            throw new NotImplementedException();
        }
    }
}
