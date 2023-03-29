
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
