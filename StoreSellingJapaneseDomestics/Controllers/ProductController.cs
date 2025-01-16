﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSJD.Services.StoreService.Product;
using SSJD.ViewModel.StoreViewModel.Product;


namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
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
        public async Task<IActionResult> Create([FromBody] ProductRequestModel request)
        {
            await _service.Create(request);
            return Ok();
        }
        [HttpPut("EditCategory")]
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
    }
}
