
using MusicShop.Domain.Entity;

namespace MusicShop.Service.Interfaces
{
    public interface ICommentService
    {
        Task<DataBaseResponse<List<Comment>>> GetAll(int productId);
        Task<DataBaseResponse<Comment>> Add(Comment comment);
    }
}
