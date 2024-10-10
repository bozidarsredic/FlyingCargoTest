using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.IServices;

using Microsoft.AspNetCore.Http;


using System.Data;
using WebApi.Models;
using WebApi.DTO;

namespace WebApi.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;


        public ProductController(IProductService productService)
        {
            _productService = productService;

        }
        [HttpPost("create")]
        [AllowAnonymous]
           
         public async Task<IActionResult> Create([FromForm] ProductDto productDto)
         {
            if (!await _productService.Create(productDto))
               return BadRequest("User not valid");
            return Ok();
         }


        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> ReadDetails(int id)
        {
            if (id < 1)
                return BadRequest("Invalid id");
            var result = await _productService.GetProductDetails(id);
            if (result == null)
                return BadRequest("No user found");
            return Ok(result);
        }

        [HttpPatch("update")]
        [AllowAnonymous]
        public async Task<IActionResult> Update(UpdateProductDto productDto)
        {
           
           var response = await _productService.Update(productDto);

            if (response== "nouserfound")
                   return BadRequest("User not found");
            return Ok();

        }

        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int id)
        {
            if (id < 1)
                return BadRequest("Invalid id");
            var result = await _productService.Delete(id);
            if (result == "nouserfound")
                return BadRequest("No user found");
            return Ok(result);

        }

        [HttpGet("filter/{from}/{to}")]
        [AllowAnonymous]
        public async Task<IActionResult> QuantityFilter(int from, int to)
        {
            var result = await _productService.QuantityFilter(from,to);
            return Ok(result);
        }

    }
    }

