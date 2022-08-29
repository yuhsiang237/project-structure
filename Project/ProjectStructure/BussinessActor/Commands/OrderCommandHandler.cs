using System;
using System.Threading.Tasks;

using ProjectStructure.DataAccessor.Commands;
using ProjectStructure.Util;

namespace ProjectStructure.BussinessActor.Commands
{
    /// <summary>
    /// OrderCommandHandler
    /// </summary>
    public partial class OrderCommandHandler :
        ICommandHandler<ReqCreateOrder, RspCreateOrder>,
        ICommandHandler<ReqUpdateOrder>,
        ICommandHandler<ReqDeleteOrder>

    {
        private readonly IOrderCommand _command;

        public OrderCommandHandler(IOrderCommand command)
        {
            _command = command;
        }

        /// <summary>
        /// Create Order
        /// </summary>
        /// <param name="req">ReqCreateOrder</param>
        /// <returns>Task</returns>
        public async Task<RspCreateOrder> HandleAsync(ReqCreateOrder req)
        {
            var now = DateTime.Now;
            var orderNumber = new OrderHelper().GenerateOrderNumber();
            await _command.InsertAsync(new OrderCommandModel
            {
                OrderNumber = orderNumber,
                OrderType = req.OrderType,
                Remark = req.Remark,
                CreatedDate = req.CreatedDate,
                ChangedOn = now,
                CreatedOn = now,
                IsValid = true,
            });

            return new RspCreateOrder
            {
                OrderNumber = orderNumber,
                OrderType = req.OrderType,
            };
        }

        /// <summary>
        /// Update Order
        /// </summary>
        /// <param name="req">ReqUpdateOrder</param>
        /// <returns>Task</returns>
        public async Task HandleAsync(ReqUpdateOrder req)
        {
            var now = DateTime.Now;
            await _command.UpdateAsync(new OrderCommandModel
            {
                OrderNumber = req.OrderNumber,
                OrderType = req.OrderType,
                Remark = req.Remark,
                ChangedOn = now,
            });
        }

        /// <summary>
        /// Delete Order
        /// </summary>
        /// <param name="req">ReqDeleteOrder</param>
        /// <returns>Task</returns>
        public async Task HandleAsync(ReqDeleteOrder req)
        {
            var now = DateTime.Now;
            await _command.DeleteAsync(new OrderCommandModel
            {
                OrderNumber = req.OrderNumber,
                OrderType = req.OrderType,
                ChangedOn = now,
            });
        }
    }
}