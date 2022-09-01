using System.Collections.Generic;
using System;

using Xunit;
using FluentAssertions;
using Moq;

using ProjectStructure.BusinessActor;
using ProjectStructure.BusinessActor.Queries;
using ProjectStructure.DataAccessor.Queries;
using ProjectStructure.Enums;

namespace ProjectStructureTest.BusinessActor.Queries
{
    public class OrderNumberQueryHandlerTest
    {
        private readonly Mock<IOrderQuery> _orderNumberQueryMock;
        private readonly OrderQueryHandler _orderNumberQueryHandler;

        public OrderNumberQueryHandlerTest()
        {
            _orderNumberQueryMock = new Mock<IOrderQuery>();
            _orderNumberQueryHandler = new OrderQueryHandler(_orderNumberQueryMock.Object);
        }

        [Fact]
        public async void GetOrderListAsync()
        {
            var models = new List<OrderQueryModel>
            {
                new OrderQueryModel
                {
                    OrderNumber = "C202208260100",
                    CreatedDate = new DateTime(2022,01,01),
                    OrderType = OrderType.Incoming,
                }
            };

            _orderNumberQueryMock
                .Setup(r => r.FindByOptionsAsync(It.IsAny<string>(), It.IsAny<OrderType?>(), It.IsAny<DateTime?>(), It.IsAny<DateTime?>()))
                .ReturnsAsync(models);

            var rsp = await _orderNumberQueryHandler.GetOrderListAsync(new ReqGetOrderList { });
            rsp.Should().NotBeNull();

            _orderNumberQueryMock
                .Verify(r => r.FindByOptionsAsync(It.IsAny<string>(), It.IsAny<OrderType?>(), It.IsAny<DateTime?>(), It.IsAny<DateTime?>()), Times.Exactly(1));
        }


        [Fact]
        public async void GetOrderAsync()
        {
            var models = new List<OrderQueryModel>
            {
                new OrderQueryModel
                {
                    OrderNumber = "C202208260100",
                    OrderType = OrderType.Incoming,
                }
            };

            _orderNumberQueryMock
                .Setup(r => r.FindByOptionsAsync(It.IsAny<string>(), It.IsAny<OrderType?>(), It.IsAny<DateTime?>(), It.IsAny<DateTime?>()))
                .ReturnsAsync(models);

            var rsp = await _orderNumberQueryHandler.GetOrderAsync(new ReqGetOrder { });
            rsp.Should().NotBeNull();

            _orderNumberQueryMock
                .Verify(r => r.FindByOptionsAsync(It.IsAny<string>(), It.IsAny<OrderType?>(), It.IsAny<DateTime?>(), It.IsAny<DateTime?>()), Times.Exactly(1));
        }
    }
}
