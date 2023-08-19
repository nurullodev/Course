using OLMS.DAL.IRepositories;
using OLMS.Domain.Commons;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OLMS.DAL.Repositories;

public class Repository<T> : IRepository<T> where T : Auditable
{
    public ValueTask CreateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> GetAll(Expression<Func<bool, T>> expression, bool isNoTracked = true, string[] includes = null)
    {
        throw new NotImplementedException();
    }

    public ValueTask<T> GetAsync(Expression<Func<bool, T>> expression)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}
