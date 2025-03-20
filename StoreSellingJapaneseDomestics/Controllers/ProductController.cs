using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSJD.Services.GeneralService.Storage.CloudStorage;
using SSJD.Services.GeneralService.Storage.FileStorage;
using SSJD.Services.StoreService.Product;
using SSJD.ViewModel.StoreViewModel.Product;


namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        private readonly ICloudStorageService _cloudStorageService;
        public ProductController(IProductService service,ICloudStorageService cloudStorageService)
        {
            _service = service;
            _cloudStorageService = cloudStorageService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }
        [HttpGet("GetProductPaging")]
        public async Task<IActionResult> GetProductPaging([FromQuery] ProductPagingRequest request)
        {
            var data = await _service.GetProductPaging(request);
            return Ok(data);
        }
        [HttpPost("CreateProduct")]
        public async Task<IActionResult> Create([FromForm] ProductRequestModel request)
        {
            var data = await _service.Create(request);
            return Ok(data);
        }

        [HttpPut("EditProduct")]
        public async Task<IActionResult> Edit([FromBody] ProductRequestModel request)
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

        [HttpGet("GetProductByID")]
        public async Task<IActionResult> GetByID(string id)
        {
            var data = await _service.GetByID(id);
            return Ok(data);
        }
    }
}
