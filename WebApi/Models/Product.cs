namespace WebApi.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }
        public string CreatedAt { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
