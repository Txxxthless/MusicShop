<<<<<<< HEAD
﻿
namespace MusicShop.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task Create(T entity);
        Task Update(T entity);
        IQueryable<T> GetAll();
        Task Delete(T entity);
    }
}
=======
﻿
namespace MusicShop.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task Create(T entity);
        Task Update(T entity);
        IQueryable<T> GetAll();
        Task Delete(T entity);
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
