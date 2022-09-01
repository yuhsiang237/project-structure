using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using ProjectStructure.BusinessActor.Commands;
using ProjectStructure.BusinessActor.Queries;
using ProjectStructure.Models;

namespace ProjectStructure.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private IOrderQueryHandler _orderQueryHandler;
        private OrderCommandHandler _orderCommandHandler;

        public OrderController(
            IOrderQueryHandler orderQueryHandler,
            OrderCommandHandler orderCommandHandler
            )
        {
            _orderQueryHandler = orderQueryHandler;
            _orderCommandHandler = orderCommandHandler;
        }


        /// <summary>
        /// Get order
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpPost("GetOrderAsync")]
        public async Task<Response<RspGetOrder>> GetOrderListAsync([FromBody] Request<ReqGetOrder> req)
        {
            return new Response<RspGetOrder>
            {
                Data = await _orderQueryHandler.GetOrderAsync(req.Data)
            };
        }

        /// <summary>
        /// Get orders
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpPost("GetOrderListAsync")]
        public async Task<Response<List<RspGetOrderList>>> GetOrderListAsync([FromBody] Request<ReqGetOrderList> req)
        {
            return new Response<List<RspGetOrderList>>
            {
                Data = await _orderQueryHandler.GetOrderListAsync(req.Data)
            };
        }

        /// <summary>
        /// CreateOrderAsync
        /// </summary>
        /// <param name="req">ReqCreateOrder</param>
        /// <returns>bool</returns>
        [HttpPost("CreateOrderAsync")]
        public async Task<Response<RspCreateOrder>> CreateOrderAsync(Request<ReqCreateOrder> req)
        {
            return new Response<RspCreateOrder>
            {
                Data = await _orderCommandHandler.HandleAsync(req.Data),
            };
        }

        /// <summary>
        /// UpdateOrderAsync
        /// </summary>
        /// <param name="req">ReqUpdateOrder</param>
        /// <returns>bool</returns>
        [HttpPost("UpdateOrderAsync")]
        public async Task<Response<bool>> UpdateOrderAsync(Request<ReqUpdateOrder> req)
        {
            await _orderCommandHandler.HandleAsync(req.Data);
            return new Response<bool>
            {
                Data = true,
            };
        }

        /// <summary>
        /// DeleteOrderAsync
        /// </summary>
        /// <param name="req">DeleteOrderAsync</param>
        /// <returns>bool</returns>
        [HttpPost("DeleteOrderAsync")]
        public async Task<Response<bool>> DeleteOrderAsync(Request<ReqDeleteOrder> req)
        {
            await _orderCommandHandler.HandleAsync(req.Data);
            return new Response<bool>
            {
                Data = true,
            };
        }
    }
}
