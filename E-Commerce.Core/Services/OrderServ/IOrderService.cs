using E_Commerce.Core.API;
using E_Commerce.Core.DTOs.OrderDTO;
using E_Commerce.Core.Entities.OrderEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Services.OrderServ
{
    public interface IOrderService
    {
        Task<OperationResult<Order>> MakeNewOrder(AddNewOrderModel newOrder);
        Task<OperationResult<IEnumerable<Order>>> GetAllOrders();
    }
}
