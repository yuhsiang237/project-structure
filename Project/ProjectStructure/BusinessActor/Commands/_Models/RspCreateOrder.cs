using ProjectStructure.Enums;

namespace ProjectStructure.BusinessActor.Commands
{
    public class RspCreateOrder
    {
        /// <summary>
        /// OrderNumber
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// OrderType
        /// </summary>
        public OrderType OrderType { get; set; }
    }
}
