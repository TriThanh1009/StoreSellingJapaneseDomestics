using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Services.StoreService.Role
{
    public interface IRoleService
    {
        Task<List<string>> GetAllRole();
        Task CreateRole(string name);
        Task DeleteRole(string name);
        Task AddRoletoUser(string userId, string roleName);
        Task<string> CheckRoleUser(string UserID);
        Task<List<string>> FillUserByRole(string roleName);

    }
}
