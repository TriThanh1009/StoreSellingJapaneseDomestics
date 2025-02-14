using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSJD.Services.StoreService.Role;

namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _service;
        public RoleController(IRoleService service)
        {
            _service = service;
        }
        [HttpPost("CreateRole")]
        public async Task<IActionResult> Create([FromBody] string name)
        {
            await _service.CreateRole(name);
            return Ok();
        }
        [HttpPost("AddRoletoUser")]
        public async Task<IActionResult> AddRoletoUser(string userId, string roleName)
        {
            await _service.AddRoletoUser(userId, roleName);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRole()
        {
            var data = await _service.GetAllRole();
            return Ok(data);
        }

        [HttpGet("CheckRoleUser")]
        public async Task<IActionResult> CheckRoleUser(string UserID)
        {
            var data = await _service.CheckRoleUser(UserID);
            return Ok(data);
        }

        [HttpGet("FillUserByRole")]
        public async Task<IActionResult> FillUserByRole(string roleName)
        {
            var data = await _service.FillUserByRole(roleName);
            return Ok(data);
        }

        [HttpDelete("DeleteRole")]
        public async Task<IActionResult> DeleteRole(string name)
        {
            await _service.DeleteRole(name);
            return Ok();
        }

    }
}
