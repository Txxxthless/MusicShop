using Microsoft.AspNetCore.Mvc;
using MusicShop.Domain.Entity;
using MusicShop.Domain.ViewModels;
using MusicShop.Service.Interfaces;

namespace MusicShopApplication.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService; 
        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public async Task<IActionResult> Orders()
        {
            DataBaseResponse<List<OrderViewModel>> response = await _basketService.GetOrders(User.Identity.Name);
            if (response.Status == MusicShop.Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return View();
        }
    }
}
