using OLMS.Domain.Commons;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OLMS.DAL.IRepositories;

public interface IRepository<T> where T : Auditable
{
    ValueTask CreateAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    ValueTask<T> GetAsync(Expression<Func<bool, T>> expression);
    IQueryable<T> GetAll(Expression<Func<bool, T>> expression, bool isNoTracked = true, string[] includes = null);
}