using E_Commerce.Core.Entities.OrderEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.DTOs.OrderDTO
{
    public class AddNewOrderModel
    {
        [Required]
        public string NameOfMakingOrder { get; set; } = "";

        [Required]
        public int CompanyId { get; set; }

        [Required]
        public int ProductId { get; set; }

        public Order createOrderObjectFromMe()
        {
            return new Order()
            {
                NameOfMakingOrder = this.NameOfMakingOrder,
                CompanyId = this.CompanyId,
                ProductId = this.ProductId,
                OrderDate = DateTime.UtcNow
            };
        }
    }
}
