using System;

using Xunit;
using Moq;

using ProjectStructure.DataAccessor.Commands;
using ProjectStructure.BusinessActor.Commands;

namespace ProjectStructureTest.BusinessActor.Commands
{
    public class OrderCommandHandlerTest
    {
        private readonly Mock<IOrderCommand> _orderCommandMock;
        private readonly OrderCommandHandler _orderCommandHandler;

        public OrderCommandHandlerTest()
        {
            _orderCommandMock = new Mock<IOrderCommand>();
            _orderCommandHandler = new OrderCommandHandler(_orderCommandMock.Object);
        }

        [Fact]
        public async void DeleteOrder()
        {
            _orderCommandMock
                .Setup(r => r.DeleteAsync(It.IsAny<OrderCommandModel>()));

            await _orderCommandHandler.HandleAsync(new ReqDeleteOrder
            {
                OrderNumber = "C202208260133",
                OrderType = ProjectStructure.Enums.OrderType.Incoming,
            });

            _orderCommandMock
                .Verify(r => r.DeleteAsync(It.IsAny<OrderCommandModel>()), Times.Exactly(1));
        }

        [Fact]
        public async void UpdateOrder()
        {
            _orderCommandMock
                .Setup(r => r.UpdateAsync(It.IsAny<OrderCommandModel>()));

            await _orderCommandHandler.HandleAsync(new ReqUpdateOrder
            {
                Remark = "test",
                OrderNumber = "C202208260133",
                OrderType = ProjectStructure.Enums.OrderType.Incoming,
            });

            _orderCommandMock
                .Verify(r => r.UpdateAsync(It.IsAny<OrderCommandModel>()), Times.Exactly(1));
        }
        [Fact]
        public async void CreateOrder()
        {
            _orderCommandMock
                .Setup(r => r.InsertAsync(It.IsAny<OrderCommandModel>()));

            await _orderCommandHandler.HandleAsync(new ReqCreateOrder
            {
                CreatedDate = DateTime.Now,
                Remark = "test",
                OrderType = ProjectStructure.Enums.OrderType.Incoming,
            });

            _orderCommandMock
                .Verify(r => r.InsertAsync(It.IsAny<OrderCommandModel>()), Times.Exactly(1));
        }
    }
}
