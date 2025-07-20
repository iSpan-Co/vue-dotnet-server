using Microsoft.AspNetCore.Mvc;
using server.Data;
using server.Model;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        // 取得所有訂單
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            List<OrderDto> orders = OrderData.datas;
            return Ok(orders);
        }

        // 根據 ID 取得單一訂單
        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            var order = OrderData.datas.FirstOrDefault(o => o.id == id);
            order.orderDetails = OrderData.details.Where(od => od.orderId == order.orderId).ToList();
            return order != null ? Ok(order) : NotFound(new { message = "找不到訂單" });
        }

        // 根據會員 ID 取得訂單
        [HttpGet("member/{memberId}")]
        public IActionResult GetOrdersByMember(int memberId)
        {
            var memberOrders = OrderData.datas.Where(o => o.memberId == memberId).ToList();
            return Ok(memberOrders);
        }

        // 根據訂單 ID 取得訂單明細
        [HttpGet("Details/{orderId}")]
        public IActionResult GetOrderDetails(string orderId)
        {
            List<OrderDetailDto> orderDetails = OrderData.details;
            var details = orderDetails.Where(od => od.orderId == orderId).ToList();
            return details.Any() ? Ok(details) : NotFound(new { message = "找不到訂單明細" });
        }

        // 建立新訂單
        [HttpPost]
        public IActionResult CreateOrder(NewOrderDto order)
        {
            int id = OrderData.datas.Any() ? OrderData.datas.Max(o => o.id) + 1 : 1;
            string oid = $"ORD{id.ToString().PadLeft(3, '0')}";
            var newOrder = new OrderDto
            {
                id = id,
                orderId = oid,
                memberId = order.memberId,
                orderDate = DateTime.Now,
                totalPrice = order.totalPrice,
                taxFee = order.taxFee,
                status = true,
            };
            OrderData.datas.Add(newOrder);

            // 建立訂單明細
            for (int i = 0; i < order.orderDetails.Count; i++)
            {
                var newDetail = new OrderDetailDto
                {
                    detailId = OrderData.details.Any() ? OrderData.details.Max(od => od.detailId) + 1 : 1,
                    orderId = oid,
                    productId = order.orderDetails[i].productId,
                    price = order.orderDetails[i].price,
                    quantity = order.orderDetails[i].quantity
                };
                OrderData.details.Add(newDetail);
            }

            CartData.datas.Clear();
            return Ok(true);
        }

    }
}