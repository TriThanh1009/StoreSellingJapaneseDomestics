using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSJD.Services.GeneralService.Account;
using SSJD.ViewModel.GeneralViewModel.Account;

namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IAccountService _service;
        public AccountController(IAccountService service, IConfiguration configuration)
        {
            _service = service;
            _configuration = configuration;
        }

        [HttpGet("check-connection-string")]
        public IActionResult GetConnectionString()
        {
            var connectionString = _configuration.GetConnectionString("SSJDdb");
            return Ok(new { ConnectionString = connectionString });
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }
        [HttpGet("getttt")]
        public async Task<IActionResult> Gett()
        {
            return Ok("asdsad");
        }
        [HttpPost("CreateAccount")]
        public async Task<IActionResult> Create([FromBody] AccountRequestModel request)
        {
            await _service.Create(request);
            return Ok();
        }
        [HttpPut("EditAccount")]
        public async Task<IActionResult> Edit([FromBody] AccountRequestModel request)
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
