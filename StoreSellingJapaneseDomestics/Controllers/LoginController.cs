using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSJD.Services.StoreService.Login;
using SSJD.ViewModel.StoreViewModel.Login;
using System.Security.Claims;

namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginServide _service;
        private IConfiguration _configuration;

        public LoginController(ILoginServide service, IConfiguration configuration)
        {
            _service = service;
            _configuration = configuration;
        }

        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            var model = await _service.GetAll();
            return Ok(model);
        }

        [HttpPost()]
        [AllowAnonymous]
        public async Task<IActionResult> Author([FromBody] LoginModel loginModel)
        {
            var model = await _service.Login(loginModel);
            return Ok(model);
        }

        [HttpGet, Authorize]
        public ActionResult<string> GetName()
        {
            var userName = User.FindFirstValue(ClaimTypes.Name);
            var role = User.FindFirstValue(ClaimTypes.Role);
            var id = User.FindFirstValue(ClaimTypes.Actor);
            return Ok(new { userName, role, id });
        }
    }
}
