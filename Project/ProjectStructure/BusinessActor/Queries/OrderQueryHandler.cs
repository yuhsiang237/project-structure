using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ProjectStructure.BusinessActor.Queries;
using ProjectStructure.DataAccessor.Queries;

namespace ProjectStructure.BusinessActor
{
    public partial class OrderQueryHandler : IOrderQueryHandler
    {
        private readonly IOrderQuery _orderQuery;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="orderQuery">IOrderQuery</param>
        public OrderQueryHandler(IOrderQuery orderQuery)
        {
            _orderQuery = orderQuery;
        }

        /// <inheritdoc/>
        public async Task<RspGetOrder> GetOrderAsync(ReqGetOrder req)
        {
            var data = (await _orderQuery.FindByOptionsAsync(
                req.OrderNumber,
                req.OrderType,
                null, null)).FirstOrDefault();
            return new RspGetOrder
            {
                CreatedDate = data.CreatedDate,
                OrderNumber = data.OrderNumber,
                OrderType = data.OrderType,
                Remark = data.Remark,
            };
        }

        /// <inheritdoc/>
        public async Task<List<RspGetOrderList>> GetOrderListAsync(ReqGetOrderList req)
        {
            var data = await _orderQuery.FindByOptionsAsync(
                req.OrderNumber,
                req.OrderType,
                string.IsNullOrEmpty(req.StartDate) ? null : (DateTime?)DateTime.Parse(req.StartDate),
                string.IsNullOrEmpty(req.EndDate) ? null : (DateTime?)DateTime.Parse(req.EndDate));
            var result = data
                .Select(ToRspGetOrderList)
                .ToList();
            return result;
        }
    }

    /// <summary>
    /// Private methods & varibles
    /// </summary>
    public partial class OrderQueryHandler : IOrderQueryHandler
    {
        /// <summary>
        /// ToRspGetOrderList
        /// </summary>
        /// <param name="m">OrderNumberQueryModel</param>
        /// <returns>RspGetOrderList</returns>
        public RspGetOrderList ToRspGetOrderList(OrderQueryModel m)
            => new RspGetOrderList
            {
                OrderNumber = m.OrderNumber,
                OrderType = m.OrderType,
                CreatedDate = m.CreatedDate,
                Remark = m.Remark,
            };
    }
}
