using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectStructure.BussinessActor.Queries
{
    public interface IOrderQueryHandler
    {
        /// <summary>
        /// Get orders
        /// </summary>
        /// <param name="req">ReqGetOrderList</param>
        /// <returns>RspGetOrderList</returns>
        Task<List<RspGetOrderList>> GetOrderListAsync(ReqGetOrderList req);

        /// <summary>
        /// Get order
        /// </summary>
        /// <param name="req">ReqGetOrder</param>
        /// <returns>RspGetOrder</returns>
        Task<RspGetOrder> GetOrderAsync(ReqGetOrder req);
    }
}
