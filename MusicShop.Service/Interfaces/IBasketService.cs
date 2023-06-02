<<<<<<< HEAD
﻿
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
=======
﻿
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
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
