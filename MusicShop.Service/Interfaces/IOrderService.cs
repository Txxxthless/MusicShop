<<<<<<< HEAD
﻿
using MusicShop.Domain.Entity;

namespace MusicShop.Service.Interfaces
{
    public interface IOrderService
    {
        Task<DataBaseResponse<Order>> Add(int productId, string userName);
        Task<DataBaseResponse<Order>> Delete(int orderId);
    }
}
=======
﻿
using MusicShop.Domain.Entity;

namespace MusicShop.Service.Interfaces
{
    public interface IOrderService
    {
        Task<DataBaseResponse<Order>> Add(int productId, string userName);
        Task<DataBaseResponse<Order>> Delete(int orderId);
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
