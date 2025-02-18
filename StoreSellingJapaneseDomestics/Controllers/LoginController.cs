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
        private readonly ILoginService _service;
        private IConfiguration _configuration;

        public LoginController(ILoginService service, IConfiguration configuration)
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
            var id = User.FindFirstValue(ClaimTypes.Actor);
            var role = User.FindFirstValue(ClaimTypes.Role);
            return Ok(new {id, role });
        }


    }
}
