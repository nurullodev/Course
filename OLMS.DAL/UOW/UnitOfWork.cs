using System;
using OLMS.DAL.DbContexts;
using System.Threading.Tasks;

namespace OLMS.DAL.UOW;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _appDbContext;

    public async Task SaveAsync()
    {
        await _appDbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        GC.SuppressFinalize(true);
    }
}
