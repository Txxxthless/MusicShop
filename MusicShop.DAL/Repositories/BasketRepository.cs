<<<<<<< HEAD
﻿
using MusicShop.DAL.Interfaces;
using MusicShop.Domain.Entity;

namespace MusicShop.DAL.Repositories
{
    public class BasketRepository : IRepository<Basket>
    {
        private readonly ApplicationDataBaseContext _dataBase;
        public BasketRepository(ApplicationDataBaseContext dataBase)
        {
            _dataBase = dataBase;
        }
        public async Task Create(Basket entity)
        {
            await _dataBase.AddAsync(entity);
            await _dataBase.SaveChangesAsync();
        }

        public async Task Delete(Basket entity)
        {
            _dataBase.Remove(entity);
            await _dataBase.SaveChangesAsync();
        }

        public IQueryable<Basket> GetAll()
        {
            return _dataBase.Baskets;
        }

        public async Task Update(Basket entity)
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
    public class BasketRepository : IRepository<Basket>
    {
        private readonly ApplicationDataBaseContext _dataBase;
        public BasketRepository(ApplicationDataBaseContext dataBase)
        {
            _dataBase = dataBase;
        }
        public async Task Create(Basket entity)
        {
            await _dataBase.AddAsync(entity);
            await _dataBase.SaveChangesAsync();
        }

        public async Task Delete(Basket entity)
        {
            _dataBase.Remove(entity);
            await _dataBase.SaveChangesAsync();
        }

        public IQueryable<Basket> GetAll()
        {
            return _dataBase.Baskets;
        }

        public async Task Update(Basket entity)
        {
            _dataBase.Update(entity);
            await _dataBase.SaveChangesAsync();
        }
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
