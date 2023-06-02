<<<<<<< HEAD
﻿
using MusicShop.DAL.Interfaces;
using MusicShop.Domain.Entity;

namespace MusicShop.DAL.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly ApplicationDataBaseContext _dataBase;
        public OrderRepository(ApplicationDataBaseContext dataBase)
        {
            _dataBase = dataBase;
        }
        public async Task Create(Order entity)
        {
            await _dataBase.AddAsync(entity);
            await _dataBase.SaveChangesAsync();
        }

        public async Task Delete(Order entity)
        {
            _dataBase.Remove(entity);
            await _dataBase.SaveChangesAsync();
        }

        public IQueryable<Order> GetAll()
        {
            return _dataBase.Orders;
        }

        public async Task Update(Order entity)
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
    public class OrderRepository : IRepository<Order>
    {
        private readonly ApplicationDataBaseContext _dataBase;
        public OrderRepository(ApplicationDataBaseContext dataBase)
        {
            _dataBase = dataBase;
        }
        public async Task Create(Order entity)
        {
            await _dataBase.AddAsync(entity);
            await _dataBase.SaveChangesAsync();
        }

        public async Task Delete(Order entity)
        {
            _dataBase.Remove(entity);
            await _dataBase.SaveChangesAsync();
        }

        public IQueryable<Order> GetAll()
        {
            return _dataBase.Orders;
        }

        public async Task Update(Order entity)
        {
            _dataBase.Update(entity);
            await _dataBase.SaveChangesAsync();
        }
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
