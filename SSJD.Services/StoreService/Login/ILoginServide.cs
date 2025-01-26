using Microsoft.AspNetCore.Identity.Data;
using SSJD.ViewModel.StoreViewModel.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.Login
{
    public interface ILoginServide
    {
        Task<LoginRequestModel> Login(LoginModel loginModel);

        Task<List<LoginRequestModel>> GetAll();

        string GetMyName();

        string CreateToken(LoginRequestModel user);
    }
}
