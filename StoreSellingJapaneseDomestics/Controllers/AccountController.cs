using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSJD.Entities.GeneralEntity;
using SSJD.Services.GeneralService;
using SSJD.Services.GeneralService.Account;
using SSJD.Services.GeneralService.Base;
using SSJD.ViewModel.GeneralViewModel.Account;

namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _service;
        public AccountController(IAccountService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }
        [HttpPost("CreateAccount")]
        public async Task<IActionResult> Create([FromBody] Account request)
        {
            await _service.Create(request);
            return Ok();
        }
    }
}
