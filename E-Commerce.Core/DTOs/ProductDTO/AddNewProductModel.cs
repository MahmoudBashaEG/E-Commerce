using E_Commerce.Core.Entities.ProductEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.DTOs.ProductDTO
{
    public class AddNewProductModel
    {
        [Required]
        public string ProductName { get; set; } = "";

        [Required]
        public long Stock { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int CompanyId { get; set; }

        public Product cretaeProductObjectFromMe()
        {
            return new Product()
            {
                CompanyId = this.CompanyId,
                ProductName = this.ProductName,
                Price = this.Price,
                Stock = this.Stock
            };
        }
    }
}
