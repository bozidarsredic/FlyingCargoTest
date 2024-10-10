namespace WebApi.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CreatedAt { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
