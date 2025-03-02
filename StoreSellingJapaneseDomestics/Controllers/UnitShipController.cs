using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSJD.Services.StoreService.UnitShip;
using SSJD.ViewModel.StoreViewModel.UnitShip;


namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitShipController : ControllerBase
    {
        private readonly IUnitShipService _service;
        public UnitShipController(IUnitShipService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }
        [HttpGet("GetUnitShipPaging")]
        public async Task<IActionResult> GetUnitShipPaging([FromQuery] UnitShipPagingRequest request)
        {
            var data = await _service.GetUnitShipPaging(request);
            return Ok(data);
        }
        [HttpPost("CreateUnitShip")]
        public async Task<IActionResult> Create([FromBody] UnitShipRequestModel request)
        {
            var data = await _service.Create(request);
            return Ok(data);
        }
        [HttpPut("EditUnitShip")]
        public async Task<IActionResult> Edit([FromBody] UnitShipRequestModel request)
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
