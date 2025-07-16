namespace server.Model
{
    public class OrderDto
    {
        public int id { get; set; }
        public string orderId { get; set; }
        public int memberId { get; set; }
        public DateTime orderDate { get; set; }
        public int totalPrice { get; set; }
        public int taxFee { get; set; }
        public bool status { get; set; }
    }

    public class OrderDetailDto
    {
        public int detailId { get; set; }
        public string orderId { get; set; }
        public int productId { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
    }

    public class NewOrderDto
    {
        public int memberId { get; set; }
        public DateTime orderDate { get; set; }
        public int totalPrice { get; set; }
        public int taxFee { get; set; }
        public List<OrderDetailDto> orderDetails { get; set; }
    }

}
