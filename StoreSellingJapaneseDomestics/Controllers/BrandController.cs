using Microsoft.AspNetCore.Mvc;
using SSJD.Services.StoreService.Brand;
using SSJD.Services.StoreService.Category;
using SSJD.ViewModel.StoreViewModel.Brand;
using SSJD.ViewModel.StoreViewModel.Category;

namespace StoreSellingJapaneseDomestics.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _service;
        public BrandController(IBrandService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }
        [HttpGet("get")]
        public async Task<IActionResult> Gett()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        [HttpPost("CreateBrand")]
        public async Task<IActionResult> Create([FromBody] BrandRequestModel request)
        {
            await _service.Create(request);
            return Ok();
        }
        [HttpPut("EdiBrand")]
        public async Task<IActionResult> Edit([FromBody] BrandRequestModel request)
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
