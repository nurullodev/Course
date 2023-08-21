using System;
using System.Linq;
using OLMS.Domain.Commons;
using OLMS.DAL.DbContexts;
using OLMS.DAL.IRepositories;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace OLMS.DAL.Repositories;

public class Repository<T> : IRepository<T> where T : Auditable
{
    private readonly AppDbContext dbContext;
    private readonly DbSet<T> dbSet;

    public Repository(AppDbContext appDbContext)
    {
        this.dbContext = appDbContext;
        dbSet = dbContext.Set<T>();
    }

    public async ValueTask CreateAsync(T entity)
    {
        entity.CreatedAt = DateTime.UtcNow;
        await this.dbSet.AddAsync(entity);  
    }

    public void Update(T entity)
    {
        entity.UpdatedAt = DateTime.UtcNow;
        this.dbContext.Entry(entity).State = EntityState.Modified;
    }

    public void Delete(T entity)
    {
        entity.IsDeleted = true;
    }

    public void Destroy(T entity)
    {
        this.dbContext.Remove(entity);
    }

    public async ValueTask<T> SelectAsync(Expression<Func<T, bool>> expression, string[] includes = null)
    {
        IQueryable<T> query = expression is null ? dbSet.AsQueryable() : dbSet.Where(expression).AsQueryable();
        if (includes is not null)
            foreach (var include in includes)
                query = query.Include(include);

        var sortQuery = query.Where(t => !t.IsDeleted);
        var entity = await sortQuery.FirstOrDefaultAsync(expression);
        return entity;
    }

    public IQueryable<T> SelectAll(Expression<Func<T, bool>> expression = null, bool isNoTracked = true, string[] includes = null)
    {
        IQueryable<T> query = expression is null ? dbSet.AsQueryable() : dbSet.Where(expression).AsQueryable().Where(t => !t.IsDeleted);
        
        query = isNoTracked ? query.AsNoTracking() : query;
        if (includes is not null)
            foreach (var include in includes)
                query = query.Include(include);

        return query;
    }

    public async ValueTask SaveAsync()
    {
        await this.dbContext.SaveChangesAsync();
    }
}