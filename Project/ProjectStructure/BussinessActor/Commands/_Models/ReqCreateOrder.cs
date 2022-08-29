using System;

using ProjectStructure.Enums;

namespace ProjectStructure.BussinessActor.Commands
{
    public class ReqCreateOrder
    {
        /// <summary>
        /// OrderType
        /// </summary>

        public OrderType OrderType { get; set; }


        /// <summary>
        /// OrderType
        /// </summary>

        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Remark
        /// </summary>
        public string Remark { get; set; }
    }
}
