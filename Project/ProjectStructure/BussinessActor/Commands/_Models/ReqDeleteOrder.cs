using ProjectStructure.Enums;

namespace ProjectStructure.BussinessActor.Commands
{
    public class ReqDeleteOrder
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
