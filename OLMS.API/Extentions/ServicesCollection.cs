using OLMS.DAL.IRepositories;
using OLMS.DAL.Repositories;
using OLMS.Service.Interfaces;
using OLMS.Service.Mappers;
using OLMS.Service.Services;

namespace OLMS.API.Extentions;

public static class ServicesCollection
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddAutoMapper(typeof(MapperProfile));
        services.AddScoped<ITeacherService, TeacherService>();
    }
}
