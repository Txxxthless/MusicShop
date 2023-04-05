using Microsoft.AspNetCore.Mvc;
using MusicShop.Domain.Entity;
using MusicShop.Service.Interfaces;

namespace MusicShopApplication.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(int id)
        {
            DataBaseResponse<Order> resposne = await _orderService.Add(id, User.Identity.Name);
            if (resposne.Status == MusicShop.Domain.Enum.StatusCode.OK)
            {
                return RedirectToAction("Orders", "Basket");
            }
            return RedirectToAction("Error");
        }

        public async Task<IActionResult> DeleteOrder(int id)
        {
            DataBaseResponse<Order> response = await _orderService.Delete(id);
            if (response.Status == MusicShop.Domain.Enum.StatusCode.OK)
            {
                return RedirectToAction("Orders", "Basket");
            }
            return RedirectToAction("Error");
        }
    }
}
