using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSJD.Services.StoreService.MemberCard;
using SSJD.ViewModel.StoreViewModel.MemberCard;

namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberCardController : ControllerBase
    {
        private readonly IMemberCardService _service;
        public MemberCardController(IMemberCardService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _service.GetAll();
            return Ok();
        }
        [HttpPost("CreatMemberCard")]
        public async Task<IActionResult> Create([FromBody] MemberCardRequestModel request)
        {
            await _service.Create(request);
            return Ok();
        }
        [HttpPut("EditMemberCard")]
        public async Task<IActionResult> Edit([FromBody] MemberCardRequestModel request)
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
