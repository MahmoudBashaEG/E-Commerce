using E_Commerce.Core.Entities.BaseEntity;
using E_Commerce.Core.Entities.CompanyEntity;
using E_Commerce.Core.Entities.ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Entities.OrderEntity
{
    public class Order : Base
    {
        public string NameOfMakingOrder { get; set; } = "";
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
