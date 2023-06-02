
using MusicShop.Domain.Entity;

namespace MusicShop.Service.Interfaces
{
    public interface IOrderService
    {
        Task<DataBaseResponse<Order>> Add(int productId, string userName);
        Task<DataBaseResponse<Order>> Delete(int orderId);
    }
}
