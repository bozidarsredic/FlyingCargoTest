using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using WebApi.IRepository;
using WebApi.Models;

namespace WebApi.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _data;

        public ProductRepository(DataContext data)
        {
            _data = data;
        }
        public async Task<bool> Create(Product product)
        {
            _data.Products.Add(product);
            await _data.SaveChangesAsync();
            return true;
        }

        public async Task<string> Delete(int id)
        {
            var product = await _data.Products.SingleOrDefaultAsync(x => x.ProductId == id);

            if (product == null)
                return "nouserfound";
            _data.Products.Remove(product);
            await _data.SaveChangesAsync();

            return "Ok";
        }

        public async Task<Product> GetProductDetails(int id)
        {
            var product = await _data.Products.SingleOrDefaultAsync(x => x.ProductId == id);
            return product;
        }

        public async Task<List<Product>> QuantityFilter(int from, int to)
        {
            return await _data.Products.Where(a => a.StockQuantity > from  && a.StockQuantity < to).ToListAsync();
        }

        public async Task<string> Update(Product updatedProduct)
        {
            var product = await _data.Products.SingleOrDefaultAsync(x => x.ProductId == updatedProduct.ProductId);

            if (product == null)
                return "nouserfound";

            product.ProductName = updatedProduct.ProductName;
            product.Price = updatedProduct.Price;
            product.Description = updatedProduct.Description;
            product.CreatedAt = updatedProduct.CreatedAt;
            product.StockQuantity = updatedProduct.StockQuantity;
            await _data.SaveChangesAsync();

            return "Ok";
        }
    }
}
