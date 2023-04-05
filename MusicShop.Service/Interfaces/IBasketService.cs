
using MusicShop.Domain.Entity;
using MusicShop.Domain.ViewModels;

namespace MusicShop.Service.Interfaces
{
    public interface IBasketService
    {
        Task<DataBaseResponse<List<OrderViewModel>>> GetOrders(string userName);
        Task<DataBaseResponse<Order>> GetOrder(string userName, int orderId);
    }
}
