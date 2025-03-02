using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSJD.Services.StoreService.Order;
using SSJD.ViewModel.StoreViewModel.Order;

namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;
        public OrderController(IOrderService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }
        [HttpGet("GetByID/{id}")]
        public async Task<IActionResult> GetByID(string id)
        {
            var data = await _service.GetByID(id);
            return Ok(data);
        }
        [HttpGet("GetOrderPaging")]
        public async Task<IActionResult> GetOrderPaging([FromQuery] OrderPagingRequest request)
        {
            var data = await _service.GetOrderPaging(request);
            return Ok(data);
        }
        [HttpPost("CreateOrder")]
        public async Task<IActionResult> Create([FromBody] OrderRequestModel request)
        {
            var data = await _service.Create(request);
            return Ok(data);
        }
        [HttpPut("EditOrder")]
        public async Task<IActionResult> Edit([FromBody] OrderRequestModel request)
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
        [HttpPut("ChangePaymentStatus")]
        public async Task<IActionResult> ChangePaymentStatus(string OrderID)
        {
            await _service.ChangePaymentStatus(OrderID);
            return Ok();
        }
    }
}
