using E_Commerce.Core.API;
using E_Commerce.Core.DTOs.ProductDTO;
using E_Commerce.Core.Entities.CompanyEntity;
using E_Commerce.Core.Entities.ProductEntity;
using E_Commerce.Core.Enums.ErrorCodes;
using E_Commerce.Core.Repository.CrossCuttingRepository;
using E_Commerce.Core.Services.ProductServ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Services.ProductServiceImplementation
{
    public class ProductServices : IProductService {
    
        private readonly ICrossCuttingRepository<Company> _companyRepository;
        private readonly ICrossCuttingRepository<Product> _productRepository;

        public ProductServices(ICrossCuttingRepository<Product> productRepository, ICrossCuttingRepository<Company> companyRepository)
        {
            _productRepository = productRepository;
            _companyRepository = companyRepository;
        }

        public async Task<OperationResult<Product>> AddProduct(AddNewProductModel newProduct)
        {
            try
            {
                if (newProduct is null)
                    return OperationResult<Product>.Fail(HttpCodes.NotFound, SystemErrors.INVALID_INPUT);

                var company = await _companyRepository.FindOneAsync(comp => comp.Id == newProduct.CompanyId);
                if(company is null)
                    return OperationResult<Product>.Fail(HttpCodes.NotFound, SystemErrors.COMPANY_NOT_FOUND);

                var product = newProduct.cretaeProductObjectFromMe();
                await _productRepository.Add(product);

                return OperationResult<Product>.Success(product);
            }
            catch (Exception ex)
            {
                return OperationResult<Product>.Fail(HttpCodes.ServerError, SystemErrors.INTERNAL_SERVER_ERROR, ex.ToString());
            }
        }
        public async Task<OperationResult<IEnumerable<Product>>> GetAllProducts()
        {
            try
            {
                var products = await _productRepository.FindAllAsync(prod => true);
                return OperationResult<IEnumerable<Product>>.Success(products);
            }
            catch (Exception ex)
            {
                return OperationResult<IEnumerable<Product>>.Fail(HttpCodes.ServerError, SystemErrors.INTERNAL_SERVER_ERROR, ex.ToString());
            }
        }
    }
}
