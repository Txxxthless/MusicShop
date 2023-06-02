<<<<<<< HEAD
﻿
using MusicShop.Domain.Entity;

namespace MusicShop.Service.Interfaces
{
    public interface ICommentService
    {
        Task<DataBaseResponse<List<Comment>>> GetAll(int productId);
        Task<DataBaseResponse<Comment>> Add(Comment comment);
    }
}
=======
﻿
using MusicShop.Domain.Entity;

namespace MusicShop.Service.Interfaces
{
    public interface ICommentService
    {
        Task<DataBaseResponse<List<Comment>>> GetAll(int productId);
        Task<DataBaseResponse<Comment>> Add(Comment comment);
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
