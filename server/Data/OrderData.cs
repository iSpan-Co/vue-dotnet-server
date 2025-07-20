using server.Model;

namespace server.Data
{
    public class OrderData
    {
        public static List<OrderDto> datas = new()
        {
            // 訂單 1 - 小橘的訂單
            new OrderDto
            {
                id = 1,
                orderId = "ORD001",
                memberId = 1,
                orderDate = DateTime.Now.AddDays(-5),
                totalPrice = 8075,
                taxFee = 403,
                status = true
            },
            // 訂單 2 - 小花的訂單
            new OrderDto
            {
                id = 2,
                orderId = "ORD002",
                memberId = 1,
                orderDate = DateTime.Now.AddDays(-3),
                totalPrice = 4615,
                taxFee = 230,
                status = true
            },
            // 訂單 3 - 小橘的訂單
            new OrderDto
            {
                id = 3,
                orderId = "ORD003",
                memberId = 1,
                orderDate = DateTime.Now.AddDays(-1),
                totalPrice = 7658,
                taxFee = 382,
                status = false
            }
        };

        public static List<OrderDetailDto> details = new()
        {
            // 訂單 1 的明細
            new OrderDetailDto { detailId = 1, orderId = "ORD001", productId = 2, price = 3989, quantity = 1 },
            new OrderDetailDto { detailId = 2, orderId = "ORD001", productId = 16, price = 1349, quantity = 2 },
            new OrderDetailDto { detailId = 3, orderId = "ORD001", productId = 10, price = 3422, quantity = 1 }, 
            
            // 訂單 2 的明細
            new OrderDetailDto { detailId = 4, orderId = "ORD002", productId = 1, price = 1351, quantity = 1 },
            new OrderDetailDto { detailId = 5, orderId = "ORD002", productId = 5, price = 1264, quantity = 1 },
            new OrderDetailDto { detailId = 6, orderId = "ORD002", productId = 17, price = 1561, quantity = 1 },
            new OrderDetailDto { detailId = 7, orderId = "ORD002", productId = 25, price = 1732, quantity = 1 },
            
            // 訂單 3 的明細
            new OrderDetailDto { detailId = 8, orderId = "ORD003", productId = 7, price = 3516, quantity = 1 },
            new OrderDetailDto { detailId = 9, orderId = "ORD003", productId = 9, price = 1067, quantity = 1 },
            new OrderDetailDto { detailId = 10, orderId = "ORD003", productId = 13, price = 3087, quantity = 1 },
            new OrderDetailDto { detailId = 11, orderId = "ORD003", productId = 19, price = 2142, quantity = 1 }
        };
    }
}
