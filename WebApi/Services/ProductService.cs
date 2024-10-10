using AutoMapper;
using WebApi.DTO;
using WebApi.IRepository;
using WebApi.IServices;
using WebApi.Models;

namespace WebApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<bool> Create(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            
            return await _productRepository.Create(product);
        }

        public async Task<string> Delete(int id)
        {
            return await _productRepository.Delete(id);
        }

        public async Task<ProductDto> GetProductDetails(int id)
        {
            var result = await _productRepository.GetProductDetails(id);
            var returnValue = _mapper.Map<ProductDto>(result);
            return returnValue;
        }

        public async Task<List<ProductDto>> QuantityFilter(int from, int to)
        {
            var result = await _productRepository.QuantityFilter(from,to);
            var returnValue = _mapper.Map<List<ProductDto>>(result);
            return returnValue;
        }

        public async Task<string> Update(UpdateProductDto updatedProductDto)
        {
            var product = _mapper.Map<Product>(updatedProductDto);

            return await _productRepository.Update(product);
        }
    }
}
