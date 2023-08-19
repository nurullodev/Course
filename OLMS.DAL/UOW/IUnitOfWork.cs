using System;
using System.Threading.Tasks;

namespace OLMS.DAL.UOW;

public interface IUnitOfWork : IDisposable
{
    Task SaveAsync();
}