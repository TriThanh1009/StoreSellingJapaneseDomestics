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
            var data = await _service.GetAll();
            return Ok(data);
        }
        [HttpGet("GetMemberCardPaging")]
        public async Task<IActionResult> GetMemberCardPaging([FromQuery] MemberCardPagingRequest request)
        {
            var data = await _service.GetMemberCardPaging(request);
            return Ok(data);
        }
        [HttpPost("CreateMemberCard")]
        public async Task<IActionResult> Create([FromBody] MemberCardRequestModel request)
        {
            var data = await _service.Create(request);
            return Ok(data);
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
