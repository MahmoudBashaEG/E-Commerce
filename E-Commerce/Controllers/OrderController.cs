using E_Commerce.Core.API;
using E_Commerce.Core.DTOs.OrderDTO;
using E_Commerce.Core.Entities.OrderEntity;
using E_Commerce.Core.Enums.ErrorCodes;
using E_Commerce.Core.Services.OrderServ;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerProcess
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("AddNewOrder")]
        [ProducesResponseType(typeof(Order), (int)HttpCodes.Succeded)]
        [ProducesResponseType(typeof(Order), (int)HttpCodes.NotFound)]
        [ProducesResponseType(typeof(Order), (int)HttpCodes.ServerError)]
        public async Task<IActionResult> MakeNewOrder(AddNewOrderModel newOrder)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var res = await _orderService.MakeNewOrder(newOrder);
            return this.ProccessResult(res);
        }

        [HttpPost("GetAllOrders")]
        [ProducesResponseType(typeof(IEnumerable<Order>), (int)HttpCodes.Succeded)]
        [ProducesResponseType(typeof(IEnumerable<Order>), (int)HttpCodes.NotFound)]
        [ProducesResponseType(typeof(IEnumerable<Order>), (int)HttpCodes.ServerError)]
        public async Task<IActionResult> GetAllOrders()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var res = await _orderService.GetAllOrders();
            return this.ProccessResult(res);
        }
    }
}
