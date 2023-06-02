<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore;
using MusicShop.DAL.Interfaces;
using MusicShop.Domain.Entity;
using MusicShop.Service.Interfaces;

namespace MusicShop.Service.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<User> _userRepository;
        public OrderService(IRepository<User> userRepository, IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
        }
        public async Task<DataBaseResponse<Order>> Add(int productId, string userName)
        {
            DataBaseResponse<Order> response = new DataBaseResponse<Order>();
            try
            {
                User user = await _userRepository.GetAll()
                                    .Include(user => user.Basket)
                                    .FirstOrDefaultAsync(user => user.Name == userName);

                if (user == null)
                {
                    response.Status = Domain.Enum.StatusCode.UserNotFound;
                    return response;
                }

                Order order = new Order()
                {
                    BasketId = user.Basket.Id,
                    DateOfCreation = DateTime.Now,
                    ProductId = productId
                };

                await _orderRepository.Create(order);

                response.Status = Domain.Enum.StatusCode.OK;
                response.Data = order;
                return response;
            }
            catch (Exception ex)
            {
                response.Description = ex.Message;
                response.Status = Domain.Enum.StatusCode.InternalServerError;
                return response;
            }
        }

        public async Task<DataBaseResponse<Order>> Delete(int orderId)
        {
            DataBaseResponse<Order> response = new DataBaseResponse<Order>();
            try
            {
                Order order = await _orderRepository.GetAll().FirstOrDefaultAsync(order => order.Id == orderId);

                if (order == null)
                {
                    response.Status = Domain.Enum.StatusCode.UserNotFound;
                    return response;
                }

                await _orderRepository.Delete(order);
                response.Status = Domain.Enum.StatusCode.OK;
                response.Data = order;
                return response;
            }
            catch (Exception ex)
            {
                response.Description = ex.Message;
                response.Status = Domain.Enum.StatusCode.InternalServerError;
                return response;
            }
        }
    }
}
=======
﻿using Microsoft.EntityFrameworkCore;
using MusicShop.DAL.Interfaces;
using MusicShop.Domain.Entity;
using MusicShop.Service.Interfaces;

namespace MusicShop.Service.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<User> _userRepository;
        public OrderService(IRepository<User> userRepository, IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
        }
        public async Task<DataBaseResponse<Order>> Add(int productId, string userName)
        {
            DataBaseResponse<Order> response = new DataBaseResponse<Order>();
            try
            {
                User user = await _userRepository.GetAll()
                                    .Include(user => user.Basket)
                                    .FirstOrDefaultAsync(user => user.Name == userName);

                if (user == null)
                {
                    response.Status = Domain.Enum.StatusCode.UserNotFound;
                    return response;
                }

                Order order = new Order()
                {
                    BasketId = user.Basket.Id,
                    DateOfCreation = DateTime.Now,
                    ProductId = productId
                };

                await _orderRepository.Create(order);

                response.Status = Domain.Enum.StatusCode.OK;
                response.Data = order;
                return response;
            }
            catch (Exception ex)
            {
                response.Description = ex.Message;
                response.Status = Domain.Enum.StatusCode.InternalServerError;
                return response;
            }
        }

        public async Task<DataBaseResponse<Order>> Delete(int orderId)
        {
            DataBaseResponse<Order> response = new DataBaseResponse<Order>();
            try
            {
                Order order = await _orderRepository.GetAll().FirstOrDefaultAsync(order => order.Id == orderId);

                if (order == null)
                {
                    response.Status = Domain.Enum.StatusCode.UserNotFound;
                    return response;
                }

                await _orderRepository.Delete(order);
                response.Status = Domain.Enum.StatusCode.OK;
                response.Data = order;
                return response;
            }
            catch (Exception ex)
            {
                response.Description = ex.Message;
                response.Status = Domain.Enum.StatusCode.InternalServerError;
                return response;
            }
        }
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
