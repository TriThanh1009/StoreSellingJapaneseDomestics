using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SSJD.DataAccess;
using SSJD.ViewModel.StoreViewModel.Login;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.Login
{
    public class LoginSerivce : ILoginService
    {
        private readonly SSJDDbContext _context;
        private IConfiguration _configuration;

        public LoginSerivce(SSJDDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public string CreateToken(LoginRequestModel user)
        { 
            List<Claim> claims = new List<Claim> {
                new Claim(ClaimTypes.Sid, user.ID),
                new Claim(ClaimTypes.Actor, user.UserID),
                new Claim(ClaimTypes.Role, user.Role),
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                _configuration.GetSection("JwtBearer:Token").Value!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        public async Task<List<LoginRequestModel>> GetAll()
        {
            var query = from a in _context.Account
                        join u in _context.User on a.ID equals u.AccountID
                        join ur in _context.UserRoles on u.Id equals ur.UserId
                        join r in _context.Roles on ur.RoleId equals r.Id
                        select new { u, a,r };
            var data = await query.Select(x=> new LoginRequestModel()
            {
                ID = x.a.ID,
                UserID = x.u.Id,
                Account = x.a.UserName,
                Password = x.a.Password,
                Role = x.r.Name
            }).ToListAsync();
            return data;
        }


        public async Task<LoginRequestModel> Login(LoginModel model)
        {
            List<LoginRequestModel> li = await GetAll();
            var login = li.Find(x => x.Account == model.username && x.Password == model.password);
            if (login != null)
            {
                login.accessToken = CreateToken(login);
                return login;
            }
            return null;
        }
    }
}
