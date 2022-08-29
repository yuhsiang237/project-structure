using System;

using ProjectStructure.Enums;

namespace ProjectStructure.DataAccessor.Commands
{
    public class OrderCommandModel
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
        /// Created Date
        /// </summary>
        public DateTime CreatedDate { get; set; }


        /// <summary>
        /// Created On
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Changed On
        /// </summary>
        public DateTime ChangedOn { get; set; }

        /// <summary>
        /// IsValid
        /// </summary>
        public bool IsValid { get; set; }
    }
}
