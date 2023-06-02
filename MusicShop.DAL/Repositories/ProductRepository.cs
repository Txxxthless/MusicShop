<<<<<<< HEAD
﻿
using MusicShop.DAL.Interfaces;
using MusicShop.Domain.Entity;

namespace MusicShop.DAL.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly ApplicationDataBaseContext _dataBase;
        public ProductRepository(ApplicationDataBaseContext dataBase)
        {
            _dataBase = dataBase;
        }

        public async Task Create(Product entity)
        {
            await _dataBase.AddAsync(entity);
            await _dataBase.SaveChangesAsync();
        }

        public async Task Delete(Product entity)
        {
            _dataBase.Remove(entity);
            await _dataBase.SaveChangesAsync();
        }

        public IQueryable<Product> GetAll()
        {
            return _dataBase.Products;
        }

        public async Task Update(Product entity)
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
    public class ProductRepository : IRepository<Product>
    {
        private readonly ApplicationDataBaseContext _dataBase;
        public ProductRepository(ApplicationDataBaseContext dataBase)
        {
            _dataBase = dataBase;
        }

        public async Task Create(Product entity)
        {
            await _dataBase.AddAsync(entity);
            await _dataBase.SaveChangesAsync();
        }

        public async Task Delete(Product entity)
        {
            _dataBase.Remove(entity);
            await _dataBase.SaveChangesAsync();
        }

        public IQueryable<Product> GetAll()
        {
            return _dataBase.Products;
        }

        public async Task Update(Product entity)
        {
            _dataBase.Update(entity);
            await _dataBase.SaveChangesAsync();
        }
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
