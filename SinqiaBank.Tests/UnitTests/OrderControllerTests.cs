using Microsoft.AspNetCore.Mvc;
using Moq;
using SinqiaBankHiringProccess.Application.Services;
using SinqiaBankHiringProccess.Controllers;
using SinqiaBankHiringProccess.Core.Entities;
using SinqiaBankHiringProccess.Core.Observers;

namespace SinqiaBankHiringProccess.Tests.UnitTests
{
    public class OrderControllerTests
    {
        private readonly Mock<IOrderService> _orderServiceMock;
        private readonly Mock<IObservable> _notifierMock;
        private readonly OrderController _orderController;

        public OrderControllerTests()
        {
            // Configura os mocks
            _orderServiceMock = new Mock<IOrderService>();
            _notifierMock = new Mock<IObservable>();

            // Cria uma instância do controller com os mocks
            _orderController = new OrderController(_orderServiceMock.Object, _notifierMock.Object);
        }

        [Fact]
        public void PlaceOrder_ShouldReturnOkResult_WhenOrderIsValid()
        {
            // Arrange: Configura um pedido válido
            var order = new Order("Pedro","Produto X");

            // Act: Chama o método PlaceOrder do controller
            var result = _orderController.PlaceOrder(order);

            // Assert: Verifica se o resultado é Ok (HTTP 200)
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Pedido criado com sucesso.", okResult.Value);
        }

        [Fact]
        public void PlaceOrder_ShouldCallOrderService_AndNotify()
        {
            // Arrange: Configura um pedido válido
            var order = new Order("Pedro", "Produto X");

            // Act: Chama o método PlaceOrder
            _orderController.PlaceOrder(order);

            // Assert: Verifica se o serviço de pedidos foi chamado
            _orderServiceMock.Verify(s => s.PlaceOrder(order.CustomerName, order.ProductName), Times.Once);

            // Assert: Verifica se o notificador foi chamado com a mensagem correta
            var expectedMessage = $"Pedido criado com sucesso! Cliente: {order.CustomerName}, Produto: {order.ProductName}, Data: {order.OrderDate}";
            _notifierMock.Verify(n => n.Notify(expectedMessage), Times.Once);
        }
    }
}
