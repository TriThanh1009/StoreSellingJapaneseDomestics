using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SSJD.Services.StoreService.Role;
using SSJD.Services.StoreService.User;
using SSJD.ViewModel.StoreViewModel.User;


namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        private readonly IRoleService _roleService;
        
        public UserController(IUserService service, IRoleService roleService)
        {
            _service = service;
            _roleService = roleService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }
        [HttpPost("CreateUser")]
        public async Task<IActionResult> Create([FromBody] UserRequestModel request)
        {
            var userid = await _service.Create(request);
            await _roleService.AddRoletoUser(userid, "Customer");
            return Ok(userid);
        }
        [HttpPost("CreateUserByAdmin/{RoleName}")]
        public async Task<IActionResult> CreateByAdmin([FromBody] UserRequestModel request,string RoleName)
        {
            var userid = await _service.Create(request);
            await _roleService.AddRoletoUser(userid, RoleName);
            return Ok();
        }

        [HttpPut("EditUser")]
        public async Task<IActionResult> Edit([FromBody] UserRequestModel request)
        {
            await _service.Edit(request);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}
