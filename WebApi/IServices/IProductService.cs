using WebApi.DTO;

namespace WebApi.IServices
{
    public interface IProductService
    {
        public Task<bool> Create(ProductDto productDto);
        public Task<ProductDto> GetProductDetails(int id);
        public Task<string> Update(UpdateProductDto updatedProductDto);
        public Task<string> Delete(int id);
        public Task<List<ProductDto>> QuantityFilter(int from, int to);
    }
}
