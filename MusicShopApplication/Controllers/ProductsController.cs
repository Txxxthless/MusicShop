<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;
using MusicShop.Domain.Entity;
using MusicShop.Service.Interfaces;
using System.Dynamic;

namespace MusicShopApplication.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICommentService _commentService;
        public ProductsController(
            IProductService productService
            , ICommentService commentService)
        {
            _productService = productService;
            _commentService = commentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Product(int id)
        {
            dynamic data = new ExpandoObject();
            DataBaseResponse<Product> productResponse = await _productService.GetProduct(id);
            if (productResponse.Status == MusicShop.Domain.Enum.StatusCode.OK)
            {
                DataBaseResponse<List<Comment>> commentResponse = 
                    await _commentService.GetAll(productResponse.Data.Id);
                data.Product = productResponse.Data;
                data.Comments = commentResponse.Data;
                return View(data);
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
            DataBaseResponse<List<Product>> response = await _productService.GetProductsByType(
                MusicShop.Domain.Enum.InstrumentType.Accessory);
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
=======
﻿using Microsoft.AspNetCore.Mvc;
using MusicShop.Domain.Entity;
using MusicShop.Service.Interfaces;
using System.Dynamic;

namespace MusicShopApplication.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICommentService _commentService;
        public ProductsController(
            IProductService productService
            , ICommentService commentService)
        {
            _productService = productService;
            _commentService = commentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Product(int id)
        {
            dynamic data = new ExpandoObject();
            DataBaseResponse<Product> productResponse = await _productService.GetProduct(id);
            if (productResponse.Status == MusicShop.Domain.Enum.StatusCode.OK)
            {
                DataBaseResponse<List<Comment>> commentResponse = 
                    await _commentService.GetAll(productResponse.Data.Id);
                data.Product = productResponse.Data;
                data.Comments = commentResponse.Data;
                return View(data);
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
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
