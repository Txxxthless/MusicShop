
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
    }
}
