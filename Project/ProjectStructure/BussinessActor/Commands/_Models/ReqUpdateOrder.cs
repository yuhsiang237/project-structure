using ProjectStructure.Enums;

namespace ProjectStructure.BussinessActor.Commands
{
    public class ReqUpdateOrder
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
    }
}
