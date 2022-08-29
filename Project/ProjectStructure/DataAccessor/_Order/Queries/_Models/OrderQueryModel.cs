using System;

using ProjectStructure.Enums;

namespace ProjectStructure.DataAccessor.Queries
{
    public class OrderQueryModel
    {
        /// <summary>
        /// OrderNumber
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// OrderType
        /// </summary>
        public OrderType OrderType { get; set; }

        /// <summary>
        /// OrderNumber Created Date
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Remark
        /// </summary>
        public string Remark { get; set; }

    }
}
