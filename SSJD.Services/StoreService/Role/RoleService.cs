using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SSJD.DataAccess;
using SSJD.Entities.StoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.Role
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SSJDDbContext _context;
        private readonly UserManager<SSJD.Entities.StoreEntity.User> _userManager;
        public RoleService(SSJDDbContext context,RoleManager<IdentityRole> roleManager, UserManager<SSJD.Entities.StoreEntity.User> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task AddRoletoUser(string userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var roleexists = await _roleManager.RoleExistsAsync(roleName);
            var result = await _userManager.AddToRoleAsync(user, roleName);
            await _context.SaveChangesAsync();
        }

        public async Task<string> CheckRoleUser(string UserID)
        {
            var user = await _userManager.FindByIdAsync(UserID);
            var roles = await _userManager.GetRolesAsync(user);
            return roles.FirstOrDefault();
        }

        public async Task CreateRole(string name)
        {
            var rolelreadyExists = await _roleManager.RoleExistsAsync(name);
            if (!rolelreadyExists)
            {
                await _roleManager.CreateAsync(new IdentityRole(name));
            }
        }
        public async Task DeleteRole(string name)
        {
            var role = await _roleManager.FindByNameAsync(name);
            if (role != null)
            {
                await _roleManager.DeleteAsync(role);
            }
        }

        public Task<List<string>> FillUserByRole(string roleName)
        {
            var users = _userManager.GetUsersInRoleAsync(roleName);
            return Task.FromResult(users.Result.Select(x => x.Id).ToList());
        }

        public async Task<List<string>> GetAllRole()
        {
            return await Task.FromResult(_roleManager.Roles.Select(x => x.Name).ToList());
        }

        public async Task<string> TakeRoleByAccount(string AccountID)
        {
            var query = from a in _context.Account
                        join u in _context.User on a.ID equals u.AccountID
                        join ur in _context.UserRoles on u.Id equals ur.UserId
                        join r in _context.Roles on ur.RoleId equals r.Id
                        where a.ID == AccountID
                        select r.Name;
            var data = await query.FirstOrDefaultAsync();
            return data;
        }
    }
}
