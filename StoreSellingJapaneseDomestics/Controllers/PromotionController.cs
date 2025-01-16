﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSJD.Services.StoreService.Promotion;
using SSJD.ViewModel.StoreViewModel.Promotion;


namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        private readonly IPromotionService _service;
        public PromotionController(IPromotionService service)
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
        public async Task<IActionResult> Create([FromBody] PromotionRequestModel request)
        {
            await _service.Create(request);
            return Ok();
        }
        [HttpPut("EditCategory")]
        public async Task<IActionResult> Edit([FromBody] PromotionRequestModel request)
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
