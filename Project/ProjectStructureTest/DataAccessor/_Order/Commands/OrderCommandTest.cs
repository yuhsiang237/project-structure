using System;

using Xunit;

using ProjectStructure.DataAccessor.Commands;
using ProjectStructure.Enums;
using ProjectStructure.Util;

namespace ProjectStructureTest.DataAccessor.Queries
{
    public class OrderCommandTest
    {
        private readonly IOrderCommand _command;

        public OrderCommandTest()
        {
            _command = new OrderCommand();
        }

        [Fact]
        public async void InsertAsync()
        {
            var now = DateTime.Now;
            var model = new OrderCommandModel
            {
                OrderNumber = new OrderHelper().GenerateOrderNumber(),
                OrderType = OrderType.Incoming,
                CreatedDate = now,
                Remark = "Test",
                ChangedOn = now,
                CreatedOn = now,
                IsValid = true,
            };
            await _command.InsertAsync(model);
        }

        [Fact]
        public async void UpdateAsync()
        {
            var now = DateTime.Now;
            var model = new OrderCommandModel
            {
                OrderNumber = "C202208260100",
                OrderType = OrderType.Incoming,
                Remark = "Test",
                ChangedOn = now,
            };
            await _command.UpdateAsync(model);
        }

        [Fact]
        public async void DeleteAsync()
        {
            var now = DateTime.Now;
            var model = new OrderCommandModel
            {
                OrderNumber = "C202208260999",
                OrderType = OrderType.Incoming,
                ChangedOn = now,
            };
            await _command.DeleteAsync(model);
        }
    }
}
