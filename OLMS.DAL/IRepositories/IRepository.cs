using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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
    void Destroy(T entity);
    ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes);
    IQueryable<T> GetAll(Expression<Func<T, bool>> expression, bool isNoTracked = true, string[] includes = null);
}