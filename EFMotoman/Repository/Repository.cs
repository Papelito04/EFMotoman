﻿using EFMotoman.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using EFMotoman.Data;

namespace EFMotoman.Repository
{
    public class Repository<T> : IRepository<T> where T: class
    {
        
            private readonly MMContext _db;
            internal DbSet<T> dbSet;

            public Repository(MMContext db)
            {
                _db = db;
                dbSet = db.Set<T>();
            }

            public async Task Add(T entity)
            {
                await dbSet.AddAsync(entity);
                await Save();
            }

            public async Task<T> Get(Expression<Func<T, bool>>? filter = null, bool tracked = true)
            {
                IQueryable<T> query = dbSet;
                if (!tracked)
                {
                    query = query.AsNoTracking();
                }
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                return await query.FirstOrDefaultAsync();
            }

            public async Task<List<T>> GetAll(Expression<Func<T, bool>>? filter = null)
            {
                IQueryable<T> query = dbSet;
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                return await query.ToListAsync();
            }

            public async Task Remove(T entity)
            {
                dbSet.Remove(entity);
                await Save();
            }

            public async Task Save()
            {
                await _db.SaveChangesAsync();
            }
        
    }
}
