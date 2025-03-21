﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SSJD.Services.StoreService.OrderDetail;
using SSJD.Services.StoreService.Product;
using SSJD.ViewModel.StoreViewModel.OrderDetail;
using StoreSellingJapaneseDomestics.Services;

namespace StoreSellingJapaneseDomestics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailService _service;
        private readonly IProductService _productservice;
        private readonly IHubContext<OrderHub> _hubContext;
        public OrderDetailController(IOrderDetailService service,IProductService productService,IHubContext<OrderHub> hubContext)
        {
            _service = service;
            _productservice = productService;
            _hubContext = hubContext;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }
        [HttpGet("ListByOrder/{id}")]
        public async Task<IActionResult> ListByOrder(string id)
        {
            var data = await _service.ListByOrderID(id);
            return Ok(data);
        }
        [HttpPost("CreateOrderDetail")]
        public async Task<IActionResult> Create([FromBody] OrderDetailRequestModel request)
        {

            var data = await _service.Create(request);
            var product = await _productservice.GetByID(request.ProductID);
            await _hubContext.Clients.All.SendAsync("ReceiveOrder", $"Khách hàng đã đặt: {product.Name} - {request.Quantity} cái.");
            return Ok(data);
        }
        [HttpPost("CreateListOrderDetail")]
        public async Task<IActionResult> CreateList([FromBody] List<OrderDetailRequestModel> request)
        {
            var productid = request.Select(x => x.ProductID).FirstOrDefault();
            var quantity = request.Select(x=>x.Quantity).FirstOrDefault();
            var data = await _service.CreateList(request);
            var product = await _productservice.GetByID(productid);
            await _hubContext.Clients.All.SendAsync("ReceiveOrder", $"Khách hàng đã đặt: {product.Name} - {quantity} cái.");
            return Ok(data);
        }
        [HttpPut("EditOrderDetail")]
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
