using E_Commerce.Core.API;
using E_Commerce.Core.DTOs.ProductDTO;
using E_Commerce.Core.Entities.ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Services.ProductServ
{
    public interface IProductService
    {
        Task<OperationResult<Product>> AddProduct(AddNewProductModel newProduct);
        Task<OperationResult<IEnumerable<Product>>> GetAllProducts();
    }
}
