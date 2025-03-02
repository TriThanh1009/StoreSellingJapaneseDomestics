using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSJD.Services.StoreService.Category;
using SSJD.ViewModel.StoreViewModel.Category;

namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }
        [HttpGet("GetCategoryPaging")]
        public async Task<IActionResult> GetCategoryPaging([FromQuery] CategoryPagingRequest request)
        {
            var data = await _service.GetCategoryPaging(request);
            return Ok(data);
        }
        [HttpPost("CreateCategory")]
        public async Task<IActionResult> Create([FromBody] CategoryRequestModel request)
        {
            var data = await _service.Create(request);
            return Ok(data);
        }
        [HttpPut("EditCategory")]
        public async Task<IActionResult> Edit([FromBody] CategoryRequestModel request)
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
