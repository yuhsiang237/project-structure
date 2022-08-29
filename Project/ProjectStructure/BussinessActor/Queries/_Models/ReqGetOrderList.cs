using ProjectStructure.Enums;

namespace ProjectStructure.BussinessActor.Queries
{
    public class ReqGetOrderList
    {
        public string OrderNumber { get; set; }
        public OrderType? OrderType { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
