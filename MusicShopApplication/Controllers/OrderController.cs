<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;
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
=======
﻿using Microsoft.AspNetCore.Mvc;
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
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
