using server.Model;

namespace server.Data
{
    public class CartData
    {
        public static List<CartDto> datas = new()
        {
            new CartDto { id = 1, name = "Fitbit Sense 2 智慧手錶", price = 1351,  quantity = 2, image = "/images/products/1.png" },
            new CartDto { id = 2, name = "Apple iPhone 13 Pro（天峰藍）", price = 4590, quantity = 1,  image = "/images/products/2.png" },
        };
    }
}
