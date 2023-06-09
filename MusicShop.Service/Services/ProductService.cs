﻿using Microsoft.EntityFrameworkCore;
using MusicShop.DAL.Interfaces;
using MusicShop.Domain.Entity;
using MusicShop.Domain.Enum;
using MusicShop.Domain.ViewModels;
using MusicShop.Service.Interfaces;

namespace MusicShop.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productsRepository;
        public ProductService(IRepository<Product> productRepository)
        {
            _productsRepository = productRepository;
        }

        public async Task<DataBaseResponse<Product>> AddProduct(ProductViewModel product)
        {
            DataBaseResponse<Product> response = new DataBaseResponse<Product>();
            try
            {
                byte[] image;
                using (BinaryReader reader = new BinaryReader(product.Avatar.OpenReadStream()))
                {
                    image = reader.ReadBytes((int)product.Avatar.Length);
                }
                Product newProduct = new Product()
                {
                    Description = product.Description,
                    Image = image,
                    Manufacturer = product.Manufacturer,
                    Model = product.Model,
                    Type = product.Type,
                    Price= product.Price
                };

                await _productsRepository.Create(newProduct);
                response.Status = StatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                response.Description = ex.Message;
                response.Status = StatusCode.InternalServerError;
                return response;
            }
        }

        public async Task<DataBaseResponse<Product>> DeleteProduct(int id)
        {
            DataBaseResponse<Product> response = new DataBaseResponse<Product>();
            try
            {
                Product product = await _productsRepository.GetAll().FirstOrDefaultAsync(product => product.Id == id);
                
                if (product != null)
                {
                    await _productsRepository.Delete(product);
                    response.Status = StatusCode.OK;
                    return response;
                }

                response.Status = StatusCode.ProductNotFound;
                return response;
            }
            catch (Exception ex)
            {
                response.Description = ex.Message;
                response.Status = StatusCode.InternalServerError;
                return response;
            }
        }

        public async Task<DataBaseResponse<List<Product>>> GetAllProducts()
        {
            DataBaseResponse<List<Product>> response = new DataBaseResponse<List<Product>>();
            try
            {
                List<Product> products = await _productsRepository.GetAll().ToListAsync();
                response.Data = products;
                response.Status = StatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                response.Description = ex.Message;
                response.Status = StatusCode.InternalServerError;
                return response;
            }
        }

        public async Task<DataBaseResponse<Product>> GetProduct(int id)
        {
            DataBaseResponse<Product> response = new DataBaseResponse<Product>();
            try
            {
                Product product = await _productsRepository.GetAll().FirstOrDefaultAsync(product => product.Id == id);

                if (product != null)
                {
                    response.Data = product;
                    response.Status = StatusCode.OK;
                    return response;
                }

                response.Status = StatusCode.ProductNotFound;
                return response;
            }
            catch (Exception ex)
            {
                response.Description = ex.Message;
                response.Status = StatusCode.InternalServerError;
                return response;
            }
        }

        public async Task<DataBaseResponse<List<Product>>> GetProductsByType(InstrumentType type)
        {
            DataBaseResponse<List<Product>> response = new DataBaseResponse<List<Product>>();
            try
            {
                List<Product> responseProducts = await _productsRepository.GetAll()
                                                    .Where(product => product.Type == type)
                                                    .ToListAsync<Product>();
                response.Data = responseProducts;
                response.Status = StatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                response.Description = ex.Message;
                response.Status = StatusCode.InternalServerError;
                return response;
            }
        }

        public async Task<DataBaseResponse<List<Product>>> Search(string name)
        {
            DataBaseResponse<List<Product>> response = new DataBaseResponse<List<Product>>();
            try
            {
                List<Product> products = await _productsRepository.GetAll()
                                                    .Where(product => product.Manufacturer.ToLower().Contains(name.ToLower())
                                                                    || product.Model.ToLower().Contains(name.ToLower())
                                                                    || product.Description.ToLower().Contains(name.ToLower()))
                                                    .Select(product => product)
                                                    .ToListAsync();

                if (products == null)
                {
                    response.Status = StatusCode.ProductNotFound;
                    return response;
                }

                response.Data = products;
                response.Status = StatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                response.Description = ex.Message;
                response.Status = StatusCode.InternalServerError;
                return response;
            }
        }
    }
}
