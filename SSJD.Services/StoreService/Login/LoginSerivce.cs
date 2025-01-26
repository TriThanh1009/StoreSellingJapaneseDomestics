using Microsoft.AspNetCore.Http;
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
    public class LoginSerivce : ILoginServide
    {
        private readonly SSJDDbContext _context;
        private IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginSerivce(SSJDDbContext context, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }
        public string CreateToken(LoginRequestModel user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Actor, user.ID),
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
                        select new { u, a };
            var data = await query.Select(x=> new LoginRequestModel()
            {
                ID = x.a.ID,
                UserName = x.u.UserName,
                Account = x.a.UserName,
                Password = x.a.Password,
            }).ToListAsync();
            return data;
        }

        public string GetMyName()
        {
            throw new NotImplementedException();
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
