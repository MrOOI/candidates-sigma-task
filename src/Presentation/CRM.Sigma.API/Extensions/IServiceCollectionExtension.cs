using CRM.Sigma.Data;
using CRM.Sigma.Business;
using CRM.Sigma.Business.Mapping;
using CRM.Sigma.API.Mapping;

namespace CRM.Sigma.API.Extensions
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            return services
                .AddAutoMapper(typeof(MappingProfile))
                .AddAutoMapper(typeof(APIMappingProfile));
        }
        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            return services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services.AddScoped<IService, Services>();
        }
    }
}
