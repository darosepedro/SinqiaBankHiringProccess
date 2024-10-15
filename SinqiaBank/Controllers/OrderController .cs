using Microsoft.AspNetCore.Mvc;
using SinqiaBankHiringProccess.Application.Services;
using SinqiaBankHiringProccess.Core.Entities;
using SinqiaBankHiringProccess.Core.Observers;

namespace SinqiaBankHiringProccess.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase //, IObserver
    {
        private readonly IOrderService _orderService;
        private readonly IObservable _notifier;

        public OrderController(IOrderService orderService, IObservable notifier)
        {
            _orderService = orderService;
            _notifier = notifier;
        }

        [HttpPost("create")]
        public IActionResult PlaceOrder([FromBody] Order order)
        {
            _orderService.PlaceOrder(order.CustomerName, order.ProductName);
            _notifier.Notify($"Pedido criado com sucesso! Cliente: {order.CustomerName}, Produto: {order.ProductName}, Data: {order.OrderDate}");

            return Ok("Pedido criado com sucesso.");
        }
    }

}