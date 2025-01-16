using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSJD.Services.StoreService.OrderDetail;
using SSJD.ViewModel.StoreViewModel.OrderDetail;

namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailService _service;
        public OrderDetailController(IOrderDetailService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _service.GetAll();
            return Ok();
        }
        [HttpPost("CreateCategory")]
        public async Task<IActionResult> Create([FromBody] OrderDetailRequestModel request)
        {
            await _service.Create(request);
            return Ok();
        }
        [HttpPut("EditCategory")]
        public async Task<IActionResult> Edit([FromBody] OrderDetailRequestModel request)
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
