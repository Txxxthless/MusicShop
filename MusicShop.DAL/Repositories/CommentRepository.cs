<<<<<<< HEAD
﻿
using MusicShop.DAL.Interfaces;
using MusicShop.Domain.Entity;

namespace MusicShop.DAL.Repositories
{
    public class CommentRepository : IRepository<Comment>
    {
        private readonly ApplicationDataBaseContext _dataBase;
        public CommentRepository(ApplicationDataBaseContext dataBase)
        {
            _dataBase = dataBase;
        }
        public async Task Create(Comment entity)
        {
            await _dataBase.AddAsync(entity);
            await _dataBase.SaveChangesAsync();
        }

        public async Task Delete(Comment entity)
        {
            _dataBase.Remove(entity);
            await _dataBase.SaveChangesAsync();
        }

        public IQueryable<Comment> GetAll()
        {
            return _dataBase.Comments;
        }

        public async Task Update(Comment entity)
        {
            _dataBase.Update(entity);
            await _dataBase.SaveChangesAsync();
        }
    }
}
=======
﻿
using MusicShop.DAL.Interfaces;
using MusicShop.Domain.Entity;

namespace MusicShop.DAL.Repositories
{
    public class CommentRepository : IRepository<Comment>
    {
        private readonly ApplicationDataBaseContext _dataBase;
        public CommentRepository(ApplicationDataBaseContext dataBase)
        {
            _dataBase = dataBase;
        }
        public async Task Create(Comment entity)
        {
            await _dataBase.AddAsync(entity);
            await _dataBase.SaveChangesAsync();
        }

        public async Task Delete(Comment entity)
        {
            _dataBase.Remove(entity);
            await _dataBase.SaveChangesAsync();
        }

        public IQueryable<Comment> GetAll()
        {
            return _dataBase.Comments;
        }

        public async Task Update(Comment entity)
        {
            _dataBase.Update(entity);
            await _dataBase.SaveChangesAsync();
        }
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
