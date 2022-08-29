using ProjectStructure.Enums;

namespace ProjectStructure.BussinessActor.Queries
{
    public class ReqGetOrder
    {
        public string OrderNumber { get; set; }
        public OrderType OrderType { get; set; }
    }
}
