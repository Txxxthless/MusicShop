using Microsoft.AspNetCore.Mvc;
using MusicShop.Domain.Entity;
using MusicShop.Service.Interfaces;

namespace MusicShopApplication.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Product(int id)
        {
            var response = await _productService.GetProduct(id);
            if (response.Status == MusicShop.Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Error");
        }

        [HttpGet]
        public async Task<IActionResult> Guitars()
        {
            DataBaseResponse<List<Product>> response = await _productService.GetProductsByType(
                MusicShop.Domain.Enum.InstrumentType.String);
            if (response.Status == MusicShop.Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Index", "Products");
        }

        [HttpGet]
        public async Task<IActionResult> Keyboards()
        {
            DataBaseResponse<List<Product>> response = await _productService.GetProductsByType(
                MusicShop.Domain.Enum.InstrumentType.Keyboard);
            if (response.Status == MusicShop.Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Index", "Products");
        }

        [HttpGet]
        public async Task<IActionResult> Percussion()
        {
            DataBaseResponse<List<Product>> response = await _productService.GetProductsByType(
                MusicShop.Domain.Enum.InstrumentType.Percussion);
            if (response.Status == MusicShop.Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Index", "Products");
        }

        [HttpGet]
        public async Task<IActionResult> Accessories()
        {
            DataBaseResponse<List<Product>> response = await _productService.GetProductsByType(MusicShop.Domain.Enum.InstrumentType.Accessory);
            if (response.Status == MusicShop.Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Index", "Products");
        }

        [HttpPost]
        public async Task<IActionResult> Search()
        {
            string requestedName = Request.Form["itemToSearch"];
            if (requestedName != null)
            {
                DataBaseResponse<List<Product>> response = await _productService.Search(requestedName);
                if (response.Status == MusicShop.Domain.Enum.StatusCode.OK)
                {
                    return View(response.Data);
                }
            }
            return RedirectToAction("Error");
        }
    }
}
