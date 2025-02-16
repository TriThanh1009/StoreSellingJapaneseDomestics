using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSJD.Services.GeneralService.Account;
using SSJD.Services.StoreService.Role;
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
        public async Task<IActionResult> Create([FromBody] AccountRequestModel request)
        {
            var data = await _service.Create(request);
            return Ok(data);
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
