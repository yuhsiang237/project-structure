using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using ProjectStructure.Enums;

namespace ProjectStructure.DataAccessor.Queries
{
    public interface IOrderQuery
    {
        /// <summary>
        /// Find orders by option
        /// </summary>
        /// <param name="orderNumber">orderNumber</param>
        /// <param name="orderType">orderType</param>
        /// <param name="startDate">startDate</param>
        /// <param name="endDate">endDate</param>
        /// <returns>List<OrderQueryModel></returns>
        public Task<List<OrderQueryModel>> FindByOptionsAsync(
            string orderNumber,
            OrderType? orderType,
            DateTime? startDate,
            DateTime? endDate);
    }
}
