using System;
using System.Linq.Expressions;
using AuthServer.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AuthServer.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            // memorye entitie ekledim v.t ye yansımadı -> ne zamanki servis katmanında commit metodları çağırırsam o zaman v.t ye yansıyacak
            await _dbSet.AddAsync(entity); 
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            // eger entitie varsa memory de takip edilmesin
            //
            if (entity != null)
            {
                _context.Entry(entity).State = EntityState.Detached;
            }
            return entity;
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity); // entity state delete olarak işaretlendi
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return entity; 
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }
    }
}

