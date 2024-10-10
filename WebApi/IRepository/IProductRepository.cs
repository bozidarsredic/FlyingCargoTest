using WebApi.DTO;
using WebApi.Models;

namespace WebApi.IRepository
{
    public interface IProductRepository
    {
       public Task<bool> Create(Product product);
       public Task<Product> GetProductDetails(int id);
       public Task<string> Update(Product updatedProduct);
        public Task<string> Delete(int id);
        public Task<List<Product>> QuantityFilter(int from, int to);
    }
}
