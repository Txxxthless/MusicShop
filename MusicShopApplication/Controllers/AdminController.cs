using Microsoft.AspNetCore.Mvc;
using MusicShop.Domain.Entity;
using MusicShop.Domain.ViewModels;
using MusicShop.Service.Interfaces;

namespace MusicShopApplication.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductService _productService;
        private readonly IUserService _userService;
        public AdminController(IUserService userService, IProductService productService)
        {
            _userService = userService;
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Users()
        {
            DataBaseResponse<List<User>> response = await _userService.GetUsers();
            if (response.Status == MusicShop.Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Error");
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                DataBaseResponse<Product> response = await _productService.AddProduct(viewModel);
                if (response.Status == MusicShop.Domain.Enum.StatusCode.OK)
                {
                    return RedirectToAction("Index", "Admin");
                }
            }
            return View(viewModel);
        }
    }
}
