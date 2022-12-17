using E_Commerce.Core.Entities.BaseEntity;
using E_Commerce.Core.Entities.CompanyEntity;
using E_Commerce.Core.Entities.OrderEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Entities.ProductEntity
{
    public class Product :Base
    {
        public string ProductName { get; set; } = "";
        public long Stock { get; set; }
        public double Price { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}
