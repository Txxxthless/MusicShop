
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using MusicShop.DAL.Interfaces;
using MusicShop.Domain.Entity;
using MusicShop.Domain.ViewModels;
using MusicShop.Service.Interfaces;

namespace MusicShop.Service.Services
{
    public class BasketService : IBasketService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Basket> _basketRepository;
        private readonly IRepository<Product> _productRepository;
        public BasketService(IRepository<User> userRepository,
            IRepository<Product> productRepository,
            IRepository<Basket> basketRepository)
        {
            _userRepository = userRepository;
            _basketRepository = basketRepository;
            _productRepository = productRepository;
        }
        public async Task<DataBaseResponse<Order>> GetOrder(string userName, int orderId)
        {
            DataBaseResponse<Order> response = new DataBaseResponse<Order>();
            try
            {
                User user = await _userRepository.GetAll().FirstOrDefaultAsync(user => user.Name == userName);
                
                if (user == null)
                {
                    response.Status = Domain.Enum.StatusCode.UserNotFound;
                    return response;
                }

                Order order = user.Basket.Orders.FirstOrDefault(order => order.Id == orderId);

                if (order == null)
                {
                    response.Status = Domain.Enum.StatusCode.UserNotFound;
                    return response;
                }

                response.Data = order;
                response.Status = Domain.Enum.StatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                response.Description = ex.Message;
                response.Status = Domain.Enum.StatusCode.InternalServerError;
                return response;
            }
        }

        public async Task<DataBaseResponse<List<OrderViewModel>>> GetOrders(string userName)
        {
            DataBaseResponse<List<OrderViewModel>> response = new DataBaseResponse<List<OrderViewModel>>();
            try
            {
                User user = await _userRepository.GetAll()
                                        .Include(user => user.Basket).ThenInclude(basket => basket.Orders)
                                        .FirstOrDefaultAsync(user => user.Name == userName);

                if (user == null)
                {
                    response.Status = Domain.Enum.StatusCode.UserNotFound;
                    return response;
                }

                List<Order> orders = user.Basket.Orders.ToList();
                
                if (orders == null)
                {
                    response.Status = Domain.Enum.StatusCode.UserNotFound;
                    return response;
                }

                List<OrderViewModel> viewModels = new List<OrderViewModel>();

                foreach (Order order in orders)
                {
                    Product product = await _productRepository
                                        .GetAll()
                                        .FirstOrDefaultAsync(product => product.Id == order.ProductId);

                    if (product != null)
                    {
                        viewModels.Add(new OrderViewModel()
                        {
                            Id = order.Id,
                            DateOfCreation = order.DateOfCreation,
                            ProductName = $"{product.Manufacturer} {product.Model}",
                            ProductPrice = product.Price,
                        });
                    }
                }

                response.Data = viewModels;
                response.Status = Domain.Enum.StatusCode.OK;
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
