using Clean.WinF.Applications.Features.Order.DTOs;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Order.Interfaces
{
    public interface IOrderCommandServices
    {
        Task<OrderDto> CreateNewOrder(OrderDto addedOrder);
        Task<OrderDto> UpdateOrder(OrderDto updatedOrder);
        Task<OrderDto> DeleteOrder(OrderDto deletedOrder);
    }
}
