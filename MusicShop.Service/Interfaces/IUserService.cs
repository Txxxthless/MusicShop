
using MusicShop.Domain.Entity;

namespace MusicShop.Service.Interfaces
{
    public interface IUserService
    {
        Task<DataBaseResponse<List<User>>> GetUsers();
    }
}
