namespace server.Model
{
    public class ProductDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int originalPrice { get; set; }
        public int nowPrice { get; set; }
        public string category { get; set; }
        public int rate { get; set; }
        public int stock { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public bool status { get; set; }
    }

    public class QueryDto
    {
        public string keyword { get; set; }
        public string category { get; set; }
        public int? priceLower { get; set; }
        public int? priceUpper { get; set; }
        public int? rateLower { get; set; }
        public int? rate { get; set; }
    }
}
