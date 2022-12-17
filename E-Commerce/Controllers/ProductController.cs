using E_Commerce.Core.API;
using E_Commerce.Core.DTOs.ProductDTO;
using E_Commerce.Core.Entities.ProductEntity;
using E_Commerce.Core.Enums.ErrorCodes;
using E_Commerce.Core.Services.ProductServ;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerProcess
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("AddProduct")]
        [ProducesResponseType(typeof(Product), (int)HttpCodes.Succeded)]
        [ProducesResponseType(typeof(Product), (int)HttpCodes.NotFound)]
        [ProducesResponseType(typeof(Product), (int)HttpCodes.ServerError)]
        public async Task<IActionResult> AddProduct(AddNewProductModel newProduct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var res = await _productService.AddProduct(newProduct);
            return this.ProccessResult(res);
        }
        [HttpGet("GetAllProducts")]
        [ProducesResponseType(typeof(IEnumerable<Product>), (int)HttpCodes.Succeded)]
        [ProducesResponseType(typeof(IEnumerable<Product>), (int)HttpCodes.ServerError)]
        public async Task<IActionResult> GetAllProducts()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var res = await _productService.GetAllProducts();
            return this.ProccessResult(res);
        }
    }
}
