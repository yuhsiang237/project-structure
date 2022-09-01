using ProjectStructure.Enums;

namespace ProjectStructure.BusinessActor.Queries
{
    public class ReqGetOrder
    {
        public string OrderNumber { get; set; }
        public OrderType OrderType { get; set; }
    }
}
