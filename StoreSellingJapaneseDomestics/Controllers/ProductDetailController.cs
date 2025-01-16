﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSJD.Services.StoreService.ProductDetail;
using SSJD.ViewModel.StoreViewModel.ProductDetail;

namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailController : ControllerBase
    {
        private readonly IProductDetailService _service;
        public ProductDetailController(IProductDetailService service)
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
        public async Task<IActionResult> Create([FromBody] ProductDetailRequestModel request)
        {
            await _service.Create(request);
            return Ok();
        }
        [HttpPut("EditCategory")]
        public async Task<IActionResult> Edit([FromBody] ProductDetailRequestModel request)
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
