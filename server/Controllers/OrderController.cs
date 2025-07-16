using Microsoft.AspNetCore.Mvc;
using server.Data;
using server.Model;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private OrderData orderData = new OrderData();

        // ���o�Ҧ��q��
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            List<OrderDto> orders = orderData.datas;
            return Ok(orders);
        }

        // �ھ� ID ���o��@�q��
        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            var order = orderData.datas.FirstOrDefault(o => o.id == id);
            return order != null ? Ok(order) : NotFound(new { message = "�䤣��q��" });
        }

        //// �ھڷ|�� ID ���o�q��
        //[HttpGet("member/{memberId}")]
        //public IActionResult GetOrdersByMember(int memberId)
        //{
        //    var memberOrders = orderData.datas.Where(o => o.memberId == memberId).ToList();
        //    return Ok(memberOrders);
        //}

        // �ھڭq�� ID ���o�q�����
        [HttpGet("{orderId}/details")]
        public IActionResult GetOrderDetails(string orderId)
        {
            List<OrderDetailDto> orderDetails = orderData.details;
            var details = orderDetails.Where(od => od.orderId == orderId).ToList();
            return details.Any() ? Ok(details) : NotFound(new { message = "�䤣��q�����" });
        }


        // �إ߷s�q��
        [HttpPost]
        public IActionResult CreateOrder(NewOrderDto order)
        {
            int id = orderData.datas.Any() ? orderData.datas.Max(o => o.id) + 1 : 1;
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
            orderData.datas.Add(newOrder);

            // �إ߭q�����
            for (int i = 0; i < order.orderDetails.Count; i++)
            {
                var newDetail = new OrderDetailDto
                {
                    detailId = orderData.details.Any() ? orderData.details.Max(od => od.detailId) + 1 : 1,
                    orderId = oid,
                    productId = order.orderDetails[i].productId,
                    price = order.orderDetails[i].price,
                    quantity = order.orderDetails[i].quantity
                };
                orderData.details.Add(newDetail);
            }
            return Ok(true);
        }

    }
}