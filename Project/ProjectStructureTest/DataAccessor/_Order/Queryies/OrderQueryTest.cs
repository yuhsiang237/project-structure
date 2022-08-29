using System;

using Xunit;
using FluentAssertions;

using ProjectStructure.DataAccessor.Queries;
using ProjectStructure.Enums;

namespace ProjectStructureTest.DataAccessor.Queries
{
    public class OrderQueryTest
    {
        private readonly IOrderQuery _query;

        public OrderQueryTest()
        {
            _query = new OrderQuery();
        }

        [Theory]
        [InlineData("C202208260100", OrderType.Incoming, null, null)]
        [InlineData(null, null, null, null)]
        [InlineData(null, null, "2022/01/01", "2022/01/02")]
        public async void FindByOptionsAsync(
            string orderNumber,
            OrderType? orderType,
            string startDate,
            string endDate)
        {
            var rsp = await _query.FindByOptionsAsync(
                orderNumber,
                orderType,
                string.IsNullOrEmpty(startDate) ? null : (DateTime?)DateTime.Parse(startDate),
                string.IsNullOrEmpty(endDate) ? null : (DateTime?)DateTime.Parse(endDate));
            rsp.Should().NotBeNull();
        }
    }
}
