<<<<<<< HEAD
﻿
using MusicShop.Domain.Entity;
using MusicShop.Domain.Enum;
using MusicShop.Domain.ViewModels;

namespace MusicShop.Service.Interfaces
{
    public interface IProductService
    {
        Task<DataBaseResponse<List<Product>>> GetAllProducts();
        Task<DataBaseResponse<Product>> GetProduct(int id);
        Task<DataBaseResponse<List<Product>>> GetProductsByType(InstrumentType type);
        Task<DataBaseResponse<Product>> DeleteProduct(int id);
        Task<DataBaseResponse<Product>> AddProduct(ProductViewModel product);
        Task<DataBaseResponse<List<Product>>> Search(string name);
    }
}
=======
﻿
using MusicShop.Domain.Entity;
using MusicShop.Domain.Enum;
using MusicShop.Domain.ViewModels;

namespace MusicShop.Service.Interfaces
{
    public interface IProductService
    {
        Task<DataBaseResponse<List<Product>>> GetAllProducts();
        Task<DataBaseResponse<Product>> GetProduct(int id);
        Task<DataBaseResponse<List<Product>>> GetProductsByType(InstrumentType type);
        Task<DataBaseResponse<Product>> DeleteProduct(int id);
        Task<DataBaseResponse<Product>> AddProduct(ProductViewModel product);
        Task<DataBaseResponse<List<Product>>> Search(string name);
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
