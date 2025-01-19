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
            await _service.GetAll();
            return Ok();
        }
        [HttpPost("CreateUnitShip")]
        public async Task<IActionResult> Create([FromBody] UnitShipRequestModel request)
        {
            await _service.Create(request);
            return Ok();
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
