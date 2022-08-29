using System;

using ProjectStructure.Enums;

namespace ProjectStructure.BussinessActor.Queries
{
    public class RspGetOrder
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
        /// Remark
        /// </summary>
        public string Remark { get; set; }


        /// <summary>
        /// CreatedDate
        /// </summary>
        public DateTime CreatedDate { get; set; }
    }
}
